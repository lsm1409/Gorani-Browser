using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoraniBrowser
{
    public class PageBox
    {
        public PictureBox pic;
        public Label name;

        public PageBox()
        {
            pic = new PictureBox();
            name = new Label();
        }
    }
}
