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
    public partial class FormUpdateRashod : Form
    {
        DataGridView dataGrid;
        string oldTipRashoda, oldSemya, oldData;
        double oldSumma;

        public FormUpdateRashod(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
        }

        private void FormUpdateRashod_Load(object sender, EventArgs e)
        {
            dataGrid.SelectionChanged += dataGridView1_SelectionChanged;
            UpdateData();
            dataGrid.Rows[0].Selected = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = e.Start.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipRashoda = "", semya = "", data = "";
            double summa = 0;

            if (comboBox1.SelectedItem != null && comboBox2.SelectedItem != null)
            {
                tipRashoda = comboBox1.SelectedItem.ToString();
                semya = comboBox2.SelectedItem.ToString();
            }

            double.TryParse(textBox1.Text, out summa);
            data = textBox2.Text;


            using (DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.UpdateQueries.GetRashodUpdateSQL(oldTipRashoda, oldSemya, oldSumma, oldData, tipRashoda, semya, summa, data));
                dataGrid.DataSource = db.SelectData(Queries.SelectQueries.Rashod);
            }

            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                oldTipRashoda = dataGrid.SelectedCells[0].Value.ToString();
                oldSemya = dataGrid.SelectedCells[1].Value.ToString();
                oldSumma = int.Parse(dataGrid.SelectedCells[2].Value.ToString());
                oldData = ((DateTime)dataGrid.SelectedCells[3].Value).ToShortDateString();

                comboBox1.SelectedItem = oldTipRashoda.ToString();
                comboBox2.SelectedItem = oldSemya.ToString();
                textBox1.Text = oldSumma.ToString();
                textBox2.Text = oldData.ToString();
            }
            catch
            {

            }

        }
        private void UpdateData()
        {
            using (DataBase db = new DataBase())
            {
                db.Open();
                DataTable dt = db.SelectData(Queries.SelectQueries.TipRashoda);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dt.Rows[i][0]);
                }

                dt = db.SelectData(Queries.SelectQueries.Semya);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    comboBox2.Items.Add(dt.Rows[i][0]);
                }
            }
        }
    }
}
