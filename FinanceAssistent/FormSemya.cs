using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAssistent
{
    public partial class FormSemya : Form
    {
        DataGridView dataGridView;
        public FormSemya(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            InitializeComponent();
        }

        private void FormSemya_Load(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                db.Open();
                DataTable dt = db.SelectData(Queries.SelectQueries.Users);
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][3]);
                }

            }
            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                db.Open();
                int idUser = Convert.ToInt32(db.SelectData($"select * from Users where name = '{comboBox1.SelectedItem}'").Rows[0][0]);
                db.InsertOrDeleteData(Queries.InsertQueries.GetSemyaInsertSQL(idUser, textBox1.Text));
                dataGridView.DataSource = db.SelectData(Queries.SelectQueries.Semya);
                this.Close();
            }
        }
    }
}
