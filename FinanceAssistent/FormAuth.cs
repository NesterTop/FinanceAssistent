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

    public partial class FormAuth : Form
    {
        Form form;

        string result = "";
        string str = "QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiopasdfghjklzxcvbnm1234567890";

        int clicks = 0;

        public FormAuth(Form form)
        {
            this.form = form;
            form.Enabled = false;
            InitializeComponent();
        }
        public FormAuth()
        {
            InitializeComponent();
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            SetCaptcha();
            this.ChangeDisigne();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DELETE
            result = "";

            clicks += 1;
            bool isAdmin = false;
            bool state = false;
            string login = textBox1.Text;
            string password = textBox2.Text;
            
            if (clicks >= 3)
            {
                MessageBox.Show("Повторите попытку через 5 секунд");
                button1.Enabled = false;
                timer1.Interval = 5000;
                timer1.Start();
                return;
            }

            if (textBox3.Text != result)
            {
                MessageBox.Show("Попробуйте еще раз ввести капчу");
                SetCaptcha();
                return;
            }

            using (DataBase db = new DataBase())
            {
                db.Open();
                DataTable table = db.SelectData(Queries.SelectQueries.Users);

                for(int i = 0; i < table.Rows.Count; i++)
                {
                    for(int j = 0; j < table.Rows[i].ItemArray.Length; j++)
                    {
                        string checkLog = table.Rows[i].ItemArray[1].ToString();
                        string checkPass = table.Rows[i].ItemArray[2].ToString();
                        bool checkIsAdmin = (bool)table.Rows[i].ItemArray[4];

                        if (login == checkLog && password == checkPass)
                        {
                            state = true;
                            if (checkIsAdmin)
                            {
                                isAdmin = true;
                            }
                        }
                    }
                }
                
            }

            

            if (state)
            {
                if (isAdmin)
                {
                    FormAdmin formAdmin = new FormAdmin();
                    formAdmin.Show();
                }

                form.Enabled = true;
                this.Close();
            }

            else
                MessageBox.Show("Пользователя с таким логином или паролем не существует");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormReg formReg = new FormReg();
            formReg.Show();
            this.Close();
            
        }

        private void SetStringCaptcha()
        {
            result = "";
            char[] chars = str.ToCharArray();
            Random random = new Random();

            for (int i = 1; i <= 5; i++)
            {
                result += chars[random.Next(0, chars.Length)];
            }
        }

        private void SetCaptcha()
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(bitmap);

            SetStringCaptcha();

            using (Font myFont = new Font("Arial", 20, FontStyle.Bold))
            {
                Point[] points2 =
                {
                    new Point(0, 20),
                    new Point(20, 10),
                    new Point(40, 20),
                    new Point(60, 10),
                    new Point(80, 20),
                    new Point(100, 10),
                };

                Point[] points1 =
                {
                    new Point(0, 30),
                    new Point(20, 20),
                    new Point(40, 30),
                    new Point(60, 20),
                    new Point(80, 30),
                    new Point(100, 20),
                };

                Point[] points3 =
                {
                    new Point(0, 40),
                    new Point(20, 30),
                    new Point(40, 40),
                    new Point(60, 30),
                    new Point(80, 40),
                    new Point(100, 30),
                };
                
                g.Clear(Color.Black);
                g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
                g.DrawString(result, myFont, Brushes.Green, new Point(0, pictureBox1.Height / 4));
                g.DrawCurve(new Pen(Color.Red, (float)1.5), points1);
                g.DrawCurve(new Pen(Color.Red, (float)1.5), points2);
                g.DrawCurve(new Pen(Color.Red, (float)1.5), points3);

                pictureBox1.Image = bitmap;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            button1.Enabled = true;
            clicks = 0;
            timer1.Stop();
        }
    }
}
