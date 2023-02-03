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
    public partial class FormUpdateTipDohoda : Form
    {
        DataGridView dataGrid;
        public FormUpdateTipDohoda(DataGridView dataGrid)
        {
            this.dataGrid = dataGrid;
            InitializeComponent();
        }

        private void FormUpdateTipDohoda_Load(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                db.Open();
                DataTable dt = db.SelectData(Queries.SelectQueries.TipDohoda);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][0]);
                }
            }

            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = comboBox1.SelectedItem.ToString();
            string rename = textBox1.Text;
            
            using (DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.UpdateQueries.GetTipDohodaUpdateSQL(name, rename));
                dataGrid.DataSource = db.SelectData(Queries.SelectQueries.TipDohoda);
            }
            this.Close();
        }
    }
}
