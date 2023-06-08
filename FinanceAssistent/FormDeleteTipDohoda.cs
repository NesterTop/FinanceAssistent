using Microsoft.Office.Interop.Excel;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinanceAssistent
{
    public partial class FormDeleteTipDohoda : Form
    {
        string nazvanie;
        DataGridView dataGrid;
        public FormDeleteTipDohoda(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
        }

        private void FormDeleteTipDohoda_Load(object sender, EventArgs e)
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
            if (MessageBox.Show("При удалении данной записи будут удалены данные в другой таблице", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataBase db = new DataBase())
                {
                    db.Open();
                    db.InsertOrDeleteData($"delete dohod where id_tip_dohoda = (select id from TipDohoda where nazvanie = '{nazvanie}')");
                    db.InsertOrDeleteData(Queries.DeleteQueries.GetTipDohodaDeleteSQL(nazvanie));
                    dataGrid.DataSource = db.SelectData(Queries.SelectQueries.TipDohoda);
                }
            }
            else return;
            

            this.Close();
        }
    }
}
