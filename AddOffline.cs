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
    public partial class frmAddOffline : Form
    {
        public frmAddOffline()
        {
            InitializeComponent();
        }

        public string txtNameText
        {
            get { return txtName.Text; }
            set { txtName.Text = value; }
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
