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
    public partial class FormDeleteFamily : Form
    {
        string name, username;
        DataGridView dataGrid;

        public FormDeleteFamily(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
        }

        private void FormDeleteFamily_Load(object sender, EventArgs e)
        {
            dataGrid.SelectionChanged += dataGridView1_SelectionChanged;
            dataGrid.Rows[0].Selected = true;
            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("При удалении данной записи будут удалены данные в другой таблице", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                using (DataBase db = new DataBase())
                {
                    db.Open();
                    db.InsertOrDeleteData($"delete dohod where id_semya = (select id from Semya where username = '{username}' and name = '{name}')");
                    db.InsertOrDeleteData($"delete rashod where id_semya = (select id from Semya where username = '{username}' and name = '{name}')");
                    db.InsertOrDeleteData(Queries.DeleteQueries.GetFamilyDeleteSQL(username, name));
                    dataGrid.DataSource = db.SelectData(Queries.SelectQueries.Semya);
                }
            }
            else return;
            

            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                name = dataGrid.SelectedCells[0].Value.ToString();
                username = dataGrid.SelectedCells[1].Value.ToString();
                textBox1.Text = name;
                textBox2.Text = username;
            }
            catch
            {

            }

        }
    }
}
