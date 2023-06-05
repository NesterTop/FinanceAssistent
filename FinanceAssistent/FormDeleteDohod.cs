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
    public partial class FormDeleteDohod : Form
    {
        string tipDohoda;
        string semya;
        double summa;
        string data;

        DataGridView dataGrid;

        public FormDeleteDohod(DataGridView dataGridView)
        {
            InitializeComponent();
            this.dataGrid = dataGridView;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                tipDohoda = dataGrid.SelectedCells[0].Value.ToString();
                semya = dataGrid.SelectedCells[1].Value.ToString();
                summa = double.Parse(dataGrid.SelectedCells[2].Value.ToString());
                data = ((DateTime)dataGrid.SelectedCells[3].Value).ToShortDateString();

                textBox1.Text = tipDohoda;
                textBox2.Text = semya;
                textBox3.Text = summa.ToString();
                textBox4.Text = data;
            }
            catch
            {

            }

        }

        private void FormDeleteDohod_Load(object sender, EventArgs e)
        {
            dataGrid.SelectionChanged += dataGridView1_SelectionChanged;
            dataGrid.Rows[0].Selected = true;
            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.DeleteQueries.GetDohodDeleteSQL(tipDohoda, semya, summa, data));
                dataGrid.DataSource = db.SelectData(Queries.SelectQueries.Dohod);
            }

            this.Close();
        }
    }
}
