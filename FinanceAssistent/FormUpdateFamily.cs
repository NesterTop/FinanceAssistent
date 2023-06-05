using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinanceAssistent
{
    public partial class FormUpdateFamily : Form
    {
        string oldUsername, oldName;
        DataGridView dataGrid;

        public FormUpdateFamily(DataGridView dataGrid)
        {
            InitializeComponent();
            this.dataGrid = dataGrid;
        }

        private void FormUpdateFamily_Load(object sender, EventArgs e)
        {
            dataGrid.SelectionChanged += dataGridView1_SelectionChanged;
            dataGrid.Rows[0].Selected = true;
            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string username = textBox2.Text;

            using(DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.UpdateQueries.GetFamilyUpdateSQL(oldUsername, oldName, username, name));
                dataGrid.DataSource = db.SelectData(Queries.SelectQueries.Semya);
            }

            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                oldName = dataGrid.SelectedCells[0].Value.ToString();
                oldUsername = dataGrid.SelectedCells[1].Value.ToString();

                textBox1.Text = oldName;
                textBox2.Text = oldUsername;
            }
            catch
            {

            }

        }
    }
}
