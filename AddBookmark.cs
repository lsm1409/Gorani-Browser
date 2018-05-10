using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoraniBrowser
{
    public partial class frmPicMenuBM : Form
    {
        public frmPicMenuBM()
        {
            InitializeComponent();
        }

        //txtUrlName.Text 값 읽고 쓰는 속성
        public string txtUrlText
        {
            get { return txtUrlName.Text; }
            set { txtUrlName.Text = value; }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
