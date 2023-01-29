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
    public partial class FormDohod : Form
    {
        DataGridView dataGrid;
        public FormDohod(DataGridView dataGridView)
        {
            dataGrid = dataGridView;
            InitializeComponent();
        }

        private void FormDohod_Load(object sender, EventArgs e)
        {
            this.ChangeDisigne();
            
            textBox2.Text = monthCalendar1.SelectionStart.ToShortDateString();
            
            using (DataBase db = new DataBase())
            {
                db.Open();
                DataTable dtTipDohoda = db.SelectData(Queries.SelectQueries.TipDohoda);
                DataTable dtSemya = db.SelectData(Queries.SelectQueries.Semya);

                for (int i = 0; i < dtTipDohoda.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dtTipDohoda.Rows[i][0]);
                }

                for (int i = 0; i < dtSemya.Rows.Count; i++)
                {
                    comboBox2.Items.Add(dtSemya.Rows[i][0]);
                }
            }

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox2.Text = e.Start.ToShortDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idTipDohoda = 0;
            int idSemya = 0;
            double summa = 0;
            string data = "";

            using (DataBase db = new DataBase())
            {
                db.Open();
                
                if (comboBox1.SelectedItem != null)
                {
                    idTipDohoda = Convert.ToInt32(db.SelectData($"select id from TipDohoda where nazvanie = '{comboBox1.SelectedItem}'").Rows[0][0]);
                }
                else
                {
                    MessageBox.Show("Не выбран тип дохода");
                    return;
                }

                if (comboBox2.SelectedItem != null)
                {
                    idSemya = Convert.ToInt32(db.SelectData($"select id from Semya where name = '{comboBox2.SelectedItem}'").Rows[0][0]);
                }
                else
                {
                    MessageBox.Show("Не выбран член семьи");
                    return;
                }


                if (!double.TryParse(textBox1.Text, out summa))
                {
                    MessageBox.Show("Неверный формат данных в поле сумма");
                    return;
                }
                
                data = textBox2.Text;
            }
            
            using (DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.InsertQueries.GetDohodInsertSQL(idTipDohoda, idSemya, summa, data));
                dataGrid.DataSource = db.SelectData(Queries.SelectQueries.Dohod);
            }
        }
    }
}
