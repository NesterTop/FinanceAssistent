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
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string name = textBox3.Text;
            
            if(login != "" && password != "" && name != "")
            {
                using (DataBase db = new DataBase())
                {
                    db.Open();
                    db.InsertOrDeleteData(Queries.InsertQueries.GetUserInsertSQL(login, password, name));
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Поля не могут быть пустыми");
            }

            
        }

        private void FormReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAuth formAuth = new FormAuth();
            formAuth.Show();
        }
    }
}
