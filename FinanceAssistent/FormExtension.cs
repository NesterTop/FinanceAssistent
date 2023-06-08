using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceAssistent
{
    public static class FormExtension
    {
        public static void ChangeDisigne(this Form form)
        {
            form.MaximizeBox = false;
            form.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            foreach(Control c in form.Controls)
            {
                c.Font = new Font("Microsoft YaHei", 9, FontStyle.Regular);
            }
        }
    }
}
