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
    public partial class FormDeleteTipRashoda : Form
    {
        string nazvanie;
        DataGridView dataGrid;
        public FormDeleteTipRashoda(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
        }

        private void FormDeleteTipRashoda_Load(object sender, EventArgs e)
        {
            dataGrid.SelectionChanged += dataGridView1_SelectionChanged;
            dataGrid.Rows[0].Selected = true;
            this.ChangeDisigne();
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                nazvanie = dataGrid.SelectedCells[0].Value.ToString();
                textBox1.Text = nazvanie;
            }
            catch
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.DeleteQueries.GetTipRashodaDeleteSQL(nazvanie));
                dataGrid.DataSource = db.SelectData(Queries.SelectQueries.TipRashoda);
            }

            this.Close();
        }
    }
}
