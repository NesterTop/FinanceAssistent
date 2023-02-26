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
    public partial class FormRashod : Form
    {
        bool state;
        Form1 form;
        public FormRashod(Form1 form, bool state)
        {
            InitializeComponent();
            this.form = form;
            this.state = state;
        }

        private void FormRashod_Load(object sender, EventArgs e)
        {
            this.ChangeDisigne();

            textBox2.Text = monthCalendar1.SelectionStart.ToShortDateString();

            using (DataBase db = new DataBase())
            {
                db.Open();
                DataTable dtTipRashoda = db.SelectData(Queries.SelectQueries.TipRashoda);
                DataTable dtSemya = db.SelectData(Queries.SelectQueries.Semya);

                for (int i = 0; i < dtTipRashoda.Rows.Count; i++)
                {
                    comboBox1.Items.Add(dtTipRashoda.Rows[i][0]);
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

            int idTipRashoda = 0;
            int idSemya = 0;
            double summa = 0;
            string data = "";

            using (DataBase db = new DataBase())
            {
                db.Open();

                if (comboBox1.SelectedItem != null)
                {
                    idTipRashoda = Convert.ToInt32(db.SelectData($"select id from TipRashoda where nazvanie = '{comboBox1.SelectedItem}'").Rows[0][0]);
                }
                else
                {
                    MessageBox.Show("Не выбран тип расхода");
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
                db.InsertOrDeleteData(Queries.InsertQueries.GetRashodInsertSQL(idTipRashoda, idSemya, summa, data));
                form.dataGridView1.DataSource = db.SelectData(Queries.SelectQueries.Rashod);
                if (state)
                {
                    form.UpdateGraphic();
                }
            }
        }
    }
}
