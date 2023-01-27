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
    public partial class FormTipDohoda : Form
    {
        DataGridView dataGridView;
        public FormTipDohoda(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            InitializeComponent();
        }

        private void FormTipDohoda_Load(object sender, EventArgs e)
        {
            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.InsertQueries.GetTipDohodaInsertSQL(textBox1.Text));
                dataGridView.DataSource = db.SelectData(Queries.SelectQueries.TipDohoda);
                this.Close();
            }
        }
    }
}
