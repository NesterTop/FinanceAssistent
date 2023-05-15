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
            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.InsertQueries.GetSemyaInsertSQL(textBox2.Text, textBox1.Text));
                dataGridView.DataSource = db.SelectData(Queries.SelectQueries.Semya);
                this.Close();
            }
        }
    }
}
