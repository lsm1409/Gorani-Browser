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
    public partial class frmGoraniBrowser : Form
    {
        string homepage = "https://www.google.com/";
        WebBrowser wbNewTab = null;   // 새 탭의 웹브라우저

        public frmGoraniBrowser()
        {
            InitializeComponent();
            wbBrowser.ScriptErrorsSuppressed = true;    // 자바 스크립트 오류 창 안뜨게하기
            wbBrowser.Navigate(homepage);
        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) // 웹페이지 로딩이 완료될 때
        {
            txtUrl.Text = ((WebBrowser)sender).Url.ToString(); // 주소창 Text 변경
            tabBrowser.SelectedTab.Text = ((WebBrowser)sender).DocumentTitle; // 탭 제목 Text 변경
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            /* 주소창에서 Enter 키 누르면 페이지 이동 */
            if (e.KeyCode == Keys.Enter)
            {
                WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;  // 현재 선택된 탭의 웹브라우저 컨트롤 가져오기
                if (wb != null)
                    wb.Navigate(txtUrl.Text);
                e.SuppressKeyPress = true;  // 시스템 경고음 제거
            }
        }

        private void picNewTab_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("");    // 탭 컨트롤에 추가할 탭 페이지 생성
            tabBrowser.TabPages.Add(tp);   // 탭 컨트롤에 탭 페이지 추가
            tabBrowser.SelectTab(tabBrowser.TabCount - 1);  // 추가한 탭 페이지 선택
            wbNewTab = new WebBrowser() { ScriptErrorsSuppressed = true };  // 새 탭에 들어갈 웹브라우저 생성
            wbNewTab.Parent = tp;  // 해당 웹브라우저의 부모 컨테이너는 새로 추가한 탭 페이지
            wbNewTab.Dock = DockStyle.Fill; // 부모 컨테이너에 도킹
            wbNewTab.Navigate(homepage);   // 새 탭을 홈페이지로 이동
            wbNewTab.DocumentCompleted += wbBrowser_DocumentCompleted;  // 웹페이지 로드되면 주소창과 탭 이름 변경
            tp.Enter += tpTabPage_Enter;    // 탭 전환하면 주소창과 탭 제목 Text 변경
        }

        private void tpTabPage_Enter(object sender, EventArgs e)    // 탭 전환할 때
        {
            WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;  // 현재 선택된 탭의 웹브라우저 컨트롤 가져오기
            if (wb != null)
                txtUrl.Text = wb.Url.ToString();    // 주소창의 Text 변경
        }

        private void tabBrowser_DoubleClick(object sender, EventArgs e)
        {
            /* 탭 더블클릭하면 현재 탭 삭제 */
            if (tabBrowser.TabCount == 1)
                this.Close();   // 남은 탭이 하나라면 폼 종료
            else
            {
                TabPage tp = tabBrowser.SelectedTab;    // 선택된 탭 컨트롤 가져오기
                if (tp != null)
                {
                    tabBrowser.TabPages.Remove(tp);
                    tabBrowser.SelectTab(tabBrowser.TabCount - 1);  // 마지막 탭 페이지 선택
                }
            }
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            /* 현재 탭 웹페이지 뒤로 가기 */
            WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;
            if (wb != null)
            {
                if(wb.CanGoBack)
                    wbBrowser.GoBack();
            }
        }

        private void picForward_Click(object sender, EventArgs e)
        {
            /* 현재 탭 웹페이지 앞으로 가기 */
            WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;
            if (wb != null)
            {
                if (wb.CanGoForward)
                    wbBrowser.GoForward();
            }
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            /* 현재 탭 웹페이지 새로고침 */
            WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;
            if (wb != null)
                wb.Refresh();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            /* 현재 탭 웹페이지 홈으로 이동 */
            WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;
            if (wb != null)
                wb.Navigate(homepage);
        }

        private void picBookmark_Click(object sender, EventArgs e)
        {
            /* 북마크 패널 보이기 / 숨기기 */
            if (pnlBookmark.Visible == false)
            {
                pnlBookmark.Enabled = true;
                pnlBookmark.Visible = true;
            }
            else
            {
                pnlBookmark.Enabled = false;
                pnlBookmark.Visible = false;
            }
        }

        /* 아이콘 마우스 오버 */
        private void picButton_MouseHover(object sender, EventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Gainsboro;
        }

        private void picButton_MouseLeave(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Name != "picNewTab")
                ((PictureBox)sender).BackColor = Color.WhiteSmoke;
            else
                ((PictureBox)sender).BackColor = Color.LightGray;
        }

        /* 아이콘 마우스 클릭 */
        private void picButton_MouseDown(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.White;
        }
        private void picButton_MouseUp(object sender, MouseEventArgs e)
        {
            ((PictureBox)sender).BackColor = Color.Gainsboro;
        }

        //picMenu클릭시 메뉴
        private void picMenu_Click(object sender, EventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            picMenuctxtMenuStrip.Show(ptLowerLeft);            
        }

        //picMenu 윈도우창 닫기
        private void 종ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //picMenu 인쇄기능
        private void 인쇄PToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;
            if (wb != null)
            {
                wbBrowser.Print();
            }
        }

        //picMenu 새 탭
        private void 새탭TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("");    // 탭 컨트롤에 추가할 탭 페이지 생성
            tabBrowser.TabPages.Add(tp);   // 탭 컨트롤에 탭 페이지 추가
            tabBrowser.SelectTab(tabBrowser.TabCount - 1);  // 추가한 탭 페이지 선택
            wbNewTab = new WebBrowser() { ScriptErrorsSuppressed = true };  // 새 탭에 들어갈 웹브라우저 생성
            wbNewTab.Parent = tp;  // 해당 웹브라우저의 부모 컨테이너는 새로 추가한 탭 페이지
            wbNewTab.Dock = DockStyle.Fill; // 부모 컨테이너에 도킹
            wbNewTab.Navigate(homepage);   // 새 탭을 홈페이지로 이동
            wbNewTab.DocumentCompleted += wbBrowser_DocumentCompleted;  // 웹페이지 로드되면 주소창과 탭 이름 변경
            tp.Enter += tpTabPage_Enter;    // 탭 전환하면 주소창과 탭 제목 Text 변경
        }

        //picMenu 새 창
        private void 새창NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGoraniBrowser newForm = new frmGoraniBrowser();
            newForm.Show();
        }   

        //picMenu 즐겨찾기 추가
        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPicMenuBM frm = new frmPicMenuBM();

            if (txtUrl.Text != "")
            {
                //Url에 내용이 있으면 frmPicMenuBM의 텍스트박스에 입력
                frm.txtUrlText = txtUrl.Text;
            }

            if (frm.ShowDialog() == DialogResult.OK) //frmPicMenuBM에서 확인버튼을 누르면
            {
                ToolStripMenuItem menu = new ToolStripMenuItem(frm.txtUrlText);
                menu.Click += new EventHandler(menu_Click); // click 이벤트 등록
                즐겨찾기추가ToolStripMenuItem.DropDownItems.Add(menu); // 즐겨찾기 추가
            }
        }

        //picMenu 즐겨찾기 클릭 이벤트
        private void menu_Click(object sender, EventArgs e)
        {
            TabPage tp = new TabPage("");    // 탭 컨트롤에 추가할 탭 페이지 생성
            tabBrowser.TabPages.Add(tp);   // 탭 컨트롤에 탭 페이지 추가
            tabBrowser.SelectTab(tabBrowser.TabCount - 1);  // 추가한 탭 페이지 선택
            wbNewTab = new WebBrowser() { ScriptErrorsSuppressed = true };  // 새 탭에 들어갈 웹브라우저 생성
            wbNewTab.Parent = tp;  // 해당 웹브라우저의 부모 컨테이너는 새로 추가한 탭 페이지
            wbNewTab.Dock = DockStyle.Fill; // 부모 컨테이너에 도킹
            wbNewTab.Navigate(((ToolStripMenuItem)sender).Text); // 새 탭을 즐겨찾기url주소로 이동
            wbNewTab.DocumentCompleted += wbBrowser_DocumentCompleted;  // 웹페이지 로드되면 주소창과 탭 이름 변경
            tp.Enter += tpTabPage_Enter;    // 탭 전환하면 주소창과 탭 제목 Text 변경
        }
    }
}
