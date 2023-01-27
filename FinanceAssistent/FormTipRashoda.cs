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
    public partial class FormTipRashoda : Form
    {
        DataGridView dataGridView;
        public FormTipRashoda(DataGridView dataGridView)
        {
            this.dataGridView = dataGridView;
            InitializeComponent();
        }

        private void FormTipRashoda_Load(object sender, EventArgs e)
        {
            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(DataBase db = new DataBase())
            {
                db.Open();
                db.InsertOrDeleteData(Queries.InsertQueries.GetTipRashodaInsertSQL(textBox1.Text));
                dataGridView.DataSource = db.SelectData(Queries.SelectQueries.TipRashoda);
                this.Close();
            }
        }
    }
}
