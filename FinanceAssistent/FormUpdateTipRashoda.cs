using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinanceAssistent
{
    public partial class FormUpdateTipRashoda : Form
    {
        DataGridView dataGrid;
        public FormUpdateTipRashoda(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
        }

        private void FormUpdateTipRashoda_Load(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                db.Open();
                DataTable dt = db.SelectData(Queries.SelectQueries.TipRashoda);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][0]);
                }
            }

            comboBox1.SelectedIndex = 0;

            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            string rename = textBox1.Text;

            using (DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.UpdateQueries.GetTipRashodaUpdateSQL(name, rename));
                dataGrid.DataSource = db.SelectData(Queries.SelectQueries.TipRashoda);
            }
            this.Close();
        }
    }
}
