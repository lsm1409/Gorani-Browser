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

        private void btnBefore_Click(object sender, EventArgs e)
        {
            // 페이지 뒤로가기
            wbMain.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            // 페이지 앞으로가기
            wbMain.GoForward();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            // txtUrl의 텍스트 문자열 url에 저장
            String url = txtUrl.Text;
            // url 주소로 페이지 이동
            wbMain.Navigate(url);
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Go 버튼 클릭 함수 불러서 페이지 이동
                btnGo_Click(sender, e);
            }
        }

        private void wbMain_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            // form 상단 Text 변경
            this.Text = wbMain.DocumentTitle;
        }
    }
}
