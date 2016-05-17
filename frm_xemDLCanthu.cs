using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuHocPhi.Shares;

namespace ThuHocPhi.Views.Thuhocphi
{
    public partial class frm_xemDLCanthu : Form
    {
        public frm_xemDLCanthu()
        {
            InitializeComponent();
        }

        private void frm_xemDLCanthu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataHocphi.kqdk_dqt1' table. You can move, or remove it, as needed.
            this.kqdk_dqt1TableAdapter.Fill(this.dataHocphi.kqdk_dqt1);
            Utils.ShowFormCenterOfPanel(this);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string ma = textBox1.Text;
            if(ma=="")
            {
                this.kqdk_dqt1DataGridView.DataSource = kqdk_dqt1TableAdapter.GetData();
            }
            else
            {
                this.kqdk_dqt1TableAdapter.FillBy(this.dataHocphi.kqdk_dqt1,ma);
            }
        }
    }
}
