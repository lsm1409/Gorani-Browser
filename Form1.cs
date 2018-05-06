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
        public frmGoraniBrowser()
        {
            InitializeComponent();
            // 자바 스크립트 오류 창 안뜨게하기
            wbMain.ScriptErrorsSuppressed = true;
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            // 페이지 뒤로가기
            wbMain.GoBack();
        }

        private void picForward_Click(object sender, EventArgs e)
        {
            // 페이지 앞으로가기
            wbMain.GoForward();
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // txtUrl의 텍스트 문자열 url에 저장
                String url = txtUrl.Text;
                // url 주소로 페이지 이동
                wbMain.Navigate(url);
            }
        }

        private void wbMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // form 상단 Text 변경
            this.Text = wbMain.DocumentTitle;
            // 주소창 Text 변경
            txtUrl.Text = wbMain.Url.ToString();
        }

        private void picRefresh_Click(object sender, EventArgs e)
        {
            // 새로고침
            wbMain.Refresh();
        }

        private void picBookmark_Click(object sender, EventArgs e)
        {
            // 북마크 패널 보이기 / 숨기기
            if (pnlBookmark.Visible == false)
                pnlBookmark.Visible = true;
            else
                pnlBookmark.Visible = false;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            // 홈페이지로 이동
            wbMain.GoHome();
        }
    }
}
