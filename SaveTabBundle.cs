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
    public partial class frmSaveTabBundle : Form
    {
        public frmSaveTabBundle()
        {
            InitializeComponent();
        }

        public string txtNameText
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void btnOK_Click(object sender, EventArgs e) => DialogResult = DialogResult.OK;
    }
}
