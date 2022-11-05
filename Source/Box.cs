using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

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

            pic.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            pic.Size = new Size(350, 200);
            pic.SizeMode = PictureBoxSizeMode.StretchImage;
            pic.BorderStyle = BorderStyle.FixedSingle;
            pic.Cursor = Cursors.Hand;

            name.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            name.Size = new Size(350, 25);
            name.Font = new Font(new FontFamily("맑은 고딕"), 10, FontStyle.Regular);
            name.BorderStyle = BorderStyle.FixedSingle;
            name.BackColor = Color.White;
            name.TextAlign = ContentAlignment.MiddleLeft;
        }
    }
    public class TabBox
    {
        public Label back1;
        public Label back2;
        public Label list;
        public Label name;

        public TabBox()
        {
            back1 = new Label();
            back2 = new Label();
            list = new Label();
            name = new Label();

            back1.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            back1.Size = new Size(350, 225);
            back1.BackColor = Color.White;
            back1.BorderStyle = BorderStyle.FixedSingle;

            back2.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            back2.Size = new Size(350, 225);
            back2.BackColor = Color.White;
            back2.BorderStyle = BorderStyle.FixedSingle;

            list.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            list.Size = new Size(350, 200);
            list.BackColor = Color.White;
            list.BorderStyle = BorderStyle.FixedSingle;
            list.AutoEllipsis = true;
            list.Padding = new Padding(5);
            list.TextAlign = ContentAlignment.MiddleLeft;
            list.Font = new Font(new FontFamily("맑은 고딕"), 10, FontStyle.Underline);
            list.Cursor = Cursors.Hand;

            name.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            name.Size = new Size(350, 25);
            name.BackColor = Color.White;
            name.BorderStyle = BorderStyle.FixedSingle;
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.Font = new Font(new FontFamily("맑은 고딕"), 10, FontStyle.Regular);
        }
    }
}
