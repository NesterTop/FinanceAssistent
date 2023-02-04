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
        
        public bool CheckNumsInName(string str)
        {
            for(int i = 0; i < str.Length; i++)
            {
                if (char.IsNumber(str, i))
                {
                    return false;
                }
            }
            return true;
        }

        public bool CheckRegistration(string log, string pass, string nam)
        {
            string login = log;
            string password = pass;
            string name = nam;

            if (login != "" && password != "" && name != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Поля не могут быть пустыми");
                return false;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            string name = textBox3.Text;

            if (CheckRegistration(textBox1.Text, textBox2.Text, textBox3.Text))
            {
                using (DataBase db = new DataBase())
                {
                    db.Open();
                    db.InsertOrDeleteData(Queries.InsertQueries.GetUserInsertSQL(login, password, name));
                }
                this.Close();
            }
        }

        private void FormReg_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAuth formAuth = new FormAuth();
            formAuth.Show();
        }
    }
}
