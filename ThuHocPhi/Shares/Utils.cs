using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuHocPhi.Shares
{
    class Utils
    {
        public static void ShowFormInPanel(Panel p, Form f)
        {
            p.Controls.Clear();
            f.TopLevel = false;
            p.Controls.Add(f);
            f.Show();
        }

        public static void ShowFormCenterOfPanel(Form f)
        {
            f.Top = (f.Parent.Height - f.Height) / 3;
            f.Left = (f.Parent.Width - f.Width) / 2;
        }

        public static void ShowFormFullPanel(Form f)
        {
            f.Width = f.Parent.Width;
            f.Height = f.Parent.Height - 5;
        }

        public static void ShowExceptionMsg(Exception ex)
        {
            if (MessageBox.Show(Constants.msg_Err_Exception, Constants.msg_capt_Err, MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                MessageBox.Show(ex.ToString(), Constants.msg_capt_Err, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
