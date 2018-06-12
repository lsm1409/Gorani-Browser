using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoraniBrowser
{
    public partial class frmGoraniBrowser : Form
    {
        string setupPath = Application.StartupPath + "\\GoraniSetup\\";
        string homepage;
        WebBrowser wbNewTab = null;   // 새 탭의 웹브라우저
        int favoriteCount = 0;
        int TabBundleCount = 0;
        int offlineCount = 0;

        public frmGoraniBrowser()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", Application.ProductName + ".exe", 11001);
                Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\Internet Explorer\MAIN\FeatureControl\FEATURE_BROWSER_EMULATION", Application.ProductName + ".vshost.exe", 11001);
            }
            else
            {
                Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", Application.ProductName + ".exe", 11001);
                Microsoft.Win32.Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", Application.ProductName + ".vshost.exe", 11001);
            }

            InitializeComponent();
            wbBrowser.ScriptErrorsSuppressed = true;    // 자바 스크립트 오류 창 안뜨게하기
            GoWebSite(homepage);
            DirectoryInfo di = new DirectoryInfo(setupPath);
            if (di.Exists == false) // Setup 폴더 없으면 생성
            {
                di.Create();
                di = new DirectoryInfo(setupPath + "Favorite\\");
                di.Create();
                di = new DirectoryInfo(setupPath + "OfflinePage\\");
                di.Create();
                di = new DirectoryInfo(setupPath + "TabBundle\\");
                di.Create();
                File.WriteAllText(setupPath + "homepage.txt", "https://www.google.com/"); // 첫 홈페이지 구글로 초기화
            }
            else
            {
                // 저장된 즐겨찾기 목록 가져오기
                di = new DirectoryInfo(setupPath + "Favorite\\");
                foreach(FileInfo fi in di.GetFiles())
                {
                    if (fi.Extension.ToLower() == ".jpg")
                    {
                        PageBox box = new PageBox();
                        // PageBox 이미지 PictureBox 설정
                        box.pic.Image = Image.FromFile(fi.FullName);    // 저장된 이미지 가져오기
                        box.pic.Tag = File.ReadAllText(setupPath + "Favorite\\" + fi.Name.Substring(0, fi.Name.Length - 4) + ".txt");   // PictureBox 태그로 URL 저장
                        // PageBox 이름 Label 설정
                        box.name.Text = fi.Name.Substring(0, fi.Name.Length - 4); // 확장자 제외한 파일 이름으로 PageBox 이름 텍스트 설정
                        // 정렬
                        if (favoriteCount % 2 == 0)
                            box.pic.Location = new Point(20 + favoriteCount / 2 * 380, 80);
                        else
                            box.pic.Location = new Point(20 + favoriteCount / 2 * 380, 380);
                        box.name.Location = new Point(box.pic.Location.X, box.pic.Location.Y - 25);
                        box.pic.Click += new EventHandler(favoriteBox_Click);   // 이미지 클릭 시 페이지 이동 핸들러 발동
                        favoriteCount++;
                        // 컨트롤에 추가
                        pnlFavorite.Controls.Add(box.name);
                        pnlFavorite.Controls.Add(box.pic);
                    }
                }

                // 저장된 탭묶음 목록 가져오기
                di = new DirectoryInfo(setupPath + "TabBundle\\");
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Name.Length >= 7 && fi.Name.Substring(fi.Name.Length - 7, 3) == "URL")
                    {
                        TabBox box = new TabBox();
                        box.name.Text = fi.Name.Substring(0, fi.Name.Length - 7);
                        box.list.Text = File.ReadAllText(setupPath + "TabBundle\\" + fi.Name.Substring(0, fi.Name.Length - 7) + ".txt");
                        box.list.Tag = File.ReadAllText(fi.FullName);

                        if (TabBundleCount % 2 == 0)
                        {
                            box.back1.Location = new Point(30 + TabBundleCount / 2 * 380, 70);
                            box.back2.Location = new Point(25 + TabBundleCount / 2 * 380, 75);
                            box.list.Location = new Point(20 + TabBundleCount / 2 * 380, 105);
                        }
                        else
                        {
                            box.back1.Location = new Point(30 + TabBundleCount / 2 * 380, 370);
                            box.back2.Location = new Point(25 + TabBundleCount / 2 * 380, 375);
                            box.list.Location = new Point(20 + TabBundleCount / 2 * 380, 405);
                        }
                        box.name.Location = new Point(box.list.Location.X, box.list.Location.Y - 25);
                        box.list.Click += new EventHandler(tabBundleBox_Click);
                        TabBundleCount++;
                        pnlTabBundle.Controls.Add(box.list);
                        pnlTabBundle.Controls.Add(box.name);
                        pnlTabBundle.Controls.Add(box.back2);
                        pnlTabBundle.Controls.Add(box.back1);
                    }
                }

                // 저장된 오프라인페이지 목록 가져오기
                di = new DirectoryInfo(setupPath + "OfflinePage\\");
                foreach (FileInfo fi in di.GetFiles())
                {
                    if (fi.Extension.ToLower() == ".jpg")
                    {
                        PageBox box = new PageBox();
                        // PageBox의 이미지 PictureBox 설정
                        box.pic.Image = Image.FromFile(fi.FullName);    // 저장된 이미지 가져오기
                        box.pic.Tag = fi.FullName.Substring(0, fi.FullName.Length - 4) + ".html";   // PictureBox 태그로 html 파일 경로 저장
                        // PageBox의 이름 Label 설정
                        box.name.Text = "☻ " + fi.Name.Substring(0, fi.Name.Length - 4);    // 확장자 제외한 파일 이름으로 PageBox 이름 텍스트 설정
                        // 정렬
                        if (offlineCount % 2 == 0)
                            box.pic.Location = new Point(20 + offlineCount / 2 * 380, 80);
                        else
                            box.pic.Location = new Point(20 + offlineCount / 2 * 380, 380);
                        box.name.Location = new Point(box.pic.Location.X, box.pic.Location.Y - 25);
                        box.pic.Click += new EventHandler(offlineBox_Click);    // 이미지 클릭 시 페이지 이동 핸들러 발동
                        offlineCount++;
                        pnlOffline.Controls.Add(box.name);
                        pnlOffline.Controls.Add(box.pic);
                    }
                }
            }
            homepage = File.ReadAllText(setupPath + "homepage.txt"); // homepage.txt 내용으로 homepage 설정
            wbBrowser.Navigate(homepage);
            AddHistory();
        }

        // 웹 페이지 이동 메서드
        private void GoWebSite(string urlString)
        {
            WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;
            if (wb != null)
                wb.Navigate(urlString);
            wb.DocumentCompleted += wbBrowser_DocumentCompleted;    // 웹페이지 로드되면 주소창과 탭 이름 변경
        }

        // 방문 기록 추가
        private void AddHistory()
        {
            ListViewItem lvt = new ListViewItem(tabBrowser.SelectedTab.Text);
            lvt.SubItems.Add(txtUrl.Text);
            lvt.SubItems.Add(DateTime.Now.ToString("HH시 mm분 ss초 (yyyy-MM-dd)"));
            lvwHistory.Items.Add(lvt);
        }

        private void wbBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) // 웹페이지 로딩이 완료될 때
        {
            txtUrl.Text = ((WebBrowser)sender).Url.ToString(); // 주소창 Text 변경
            tabBrowser.SelectedTab.Text = ((WebBrowser)sender).DocumentTitle; // 탭 제목 Text 변경
            pnlBookmark.Visible = false;

            if (lvwHistory.Items[lvwHistory.Items.Count - 1].SubItems[1].Text != txtUrl.Text)
                AddHistory();
        }

        private void txtUrl_KeyDown(object sender, KeyEventArgs e)
        {
            /* 주소창에서 Enter 키 누르면 페이지 이동 */
            if (e.KeyCode == Keys.Enter)
            {
                GoWebSite(txtUrl.Text);
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
            wbNewTab = tabBrowser.SelectedTab.Controls[0] as WebBrowser;
            wbNewTab.Navigate(homepage);
            wbNewTab.DocumentCompleted += wbBrowser_DocumentCompleted;    // 웹페이지 로드되면 주소창과 탭 이름 변경
            tp.Enter += tpTabPage_Enter;    // 탭 전환하면 주소창 Text 변경
        }

        // 탭 전환할 때
        private void tpTabPage_Enter(object sender, EventArgs e)
        {
            WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;  // 현재 선택된 탭의 웹브라우저 컨트롤 가져오기
            if (wb.Url != null)
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
            {
                wb.Refresh();
                tabBrowser.SelectedTab.Text = wb.DocumentTitle; // 탭 제목 Text 변경
            }
        }

        /* 현재 탭 웹페이지 홈으로 이동 */
        private void picHome_Click(object sender, EventArgs e) => GoWebSite(homepage);

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
        private void picButton_MouseDown(object sender, MouseEventArgs e) => ((PictureBox)sender).BackColor = Color.White;

        private void picButton_MouseUp(object sender, MouseEventArgs e) => ((PictureBox)sender).BackColor = Color.Gainsboro;

        // picMenu 클릭 시 ContextMenuStrip
        private void picMenu_Click(object sender, EventArgs e)
        {
            PictureBox btnSender = (PictureBox)sender;
            Point ptLowerLeft = new Point(0, btnSender.Height);
            ptLowerLeft = btnSender.PointToScreen(ptLowerLeft);
            cmsMenu.Show(ptLowerLeft);            
        }

        // picMenu ContextMenuStrip의 종료
        private void tsmiClose_Click(object sender, EventArgs e) => this.Close();

        // picMenu ContextMenuStrip의 인쇄
        private void tsmiPrint_Click(object sender, EventArgs e)
        {
            WebBrowser wb = tabBrowser.SelectedTab.Controls[0] as WebBrowser;
            if (wb != null)
            {
                wb.Print();
            }
        }

        // picMenu ContextMenuStrip의 새 탭
        private void tsmiNewTab_Click(object sender, EventArgs e)
        {
            picNewTab_Click(sender, e);
        }

        // picMenu ContextMenuStrip의 새 창
        private void tsmiNewWindow_Click(object sender, EventArgs e)
        {
            frmGoraniBrowser newForm = new frmGoraniBrowser();
            newForm.Show();
        }

        // picMenu ContextMenuStrip의 홈페이지 변경
        private void tsmiHomepage_Click(object sender, EventArgs e)
        {
            frmHomepage frm = new frmHomepage();

            if (txtUrl.Text != "")
            {
                // 텍스트 상자에 현재 URL 입력
                frm.txtUrlText = txtUrl.Text;
            }

            if (frm.ShowDialog() == DialogResult.OK) // 확인버튼을 누르면
            {
                if (frm.txtUrlText != "")
                {
                    homepage = frm.txtUrlText;
                    File.WriteAllText(setupPath + "homepage.txt", frm.txtUrlText);
                }
            }
        }

        // picMenu ContextMenuStrip의 즐겨찾기 추가
        private void tsmiAddBookmark_Click(object sender, EventArgs e)
        {
            frmAddFavorite frm = new frmAddFavorite();
            WebBrowser wb = (WebBrowser)tabBrowser.SelectedTab.Controls[0];

            if (wb.DocumentTitle != "")
            {
                // 즐겨찾기 등록 창 텍스트 상자에 제목 입력
                frm.txtNameText = wb.DocumentTitle;
            }
            
            if (txtUrl.Text != "")
            {
                // 즐겨찾기 등록 창 텍스트 상자에 URL 입력
                frm.txtUrlText = txtUrl.Text;
            }

            if (frm.ShowDialog() == DialogResult.OK) // 확인버튼을 누르면
            {
                try
                {
                    // 패널에 PictureBox, Label 동적 생성
                    PageBox box = new PageBox();
                    Bitmap img = Screenshot.Create(wb);
                    img.Save(setupPath + "Favorite\\" + frm.txtNameText + ".jpg");
                    File.WriteAllText(setupPath + "Favorite\\" + frm.txtNameText + ".txt", frm.txtUrlText);
                    box.pic.Image = Image.FromFile(setupPath + "Favorite\\" + frm.txtNameText + ".jpg");
                    box.pic.Tag = File.ReadAllText(setupPath + "Favorite\\" + frm.txtNameText + ".txt");
                    box.name.Text = Path.GetFileNameWithoutExtension(setupPath + "Favorite\\" + frm.txtNameText + ".jpg");
                    if (favoriteCount % 2 == 0)
                        box.pic.Location = new Point(20 + favoriteCount / 2 * 380, 80);
                    else
                        box.pic.Location = new Point(20 + favoriteCount / 2 * 380, 380);
                    box.name.Location = new Point(box.pic.Location.X, box.pic.Location.Y - 25);
                    box.pic.Click += new EventHandler(favoriteBox_Click);
                    favoriteCount++;
                    pnlFavorite.Controls.Add(box.name);
                    pnlFavorite.Controls.Add(box.pic);
                }
                catch
                {
                    MessageBox.Show("저장에 실패했습니다. 이름을 확인하세요.");
                }
            }
        }

        // picMenu ContextMenuStrip의 오프라인으로 저장
        private void tsmiSaveOffline_Click(object sender, EventArgs e)
        {
            frmSaveOffline frm = new frmSaveOffline();
            WebBrowser wb = (WebBrowser)tabBrowser.SelectedTab.Controls[0];

            // 오프라인 등록 창 텍스트 상자에 제목 입력
            if (wb.DocumentTitle != "")
                frm.txtNameText = wb.DocumentTitle;

            if (frm.ShowDialog() == DialogResult.OK) // 확인버튼을 누르면 오프라인으로 저장
            {
                // 패널에 PictureBox, Label 동적 생성
                try
                {
                    PageBox box = new PageBox();
                    Bitmap img = Screenshot.Create(wb);
                    img.Save(setupPath + "OfflinePage\\" + frm.txtNameText + ".jpg");
                    box.pic.Image = img;
                    box.pic.Tag = setupPath + "OfflinePage\\" + frm.txtNameText + ".html";
                    box.name.Text = "☻ " + frm.txtNameText;
                    if (offlineCount % 2 == 0)
                        box.pic.Location = new Point(20 + offlineCount / 2 * 380, 80);
                    else
                        box.pic.Location = new Point(20 + offlineCount / 2 * 380, 380);
                    box.name.Location = new Point(box.pic.Location.X, box.pic.Location.Y - 25);
                    box.pic.Click += new EventHandler(offlineBox_Click);
                    offlineCount++;
                    pnlOffline.Controls.Add(box.name);
                    pnlOffline.Controls.Add(box.pic);
                    File.WriteAllText(setupPath + "OfflinePage\\" + frm.txtNameText + ".html", wb.Document.Body.Parent.OuterHtml, Encoding.GetEncoding(wb.Document.Encoding));
                }
                catch
                {
                    MessageBox.Show("저장에 실패했습니다. 이름을 확인하세요.");
                }
            }
        }

        // picMenu ContextMenuStrip의 탭묶음 저장
        private void tsmiSaveTab_Click(object sender, EventArgs e)
        {
            frmSaveTabBundle frm = new frmSaveTabBundle();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    TabBox box = new TabBox();
                    box.name.Text = frm.txtNameText;
                    TabControl.TabPageCollection tpc = tabBrowser.TabPages;
                    foreach (TabPage tp in tpc)
                    {
                        WebBrowser wb = (WebBrowser)tp.Controls[0];
                        box.list.Text += wb.DocumentTitle + '\n';
                        box.list.Tag += wb.Url.ToString() + '\n';
                    }

                    File.WriteAllText(setupPath + "TabBundle\\" + frm.txtNameText + ".txt", box.list.Text);
                    File.WriteAllText(setupPath + "TabBundle\\" + frm.txtNameText + "URL.txt", box.list.Tag.ToString());

                    if (TabBundleCount % 2 == 0)
                    {
                        box.back1.Location = new Point(30 + TabBundleCount / 2 * 380, 70);
                        box.back2.Location = new Point(25 + TabBundleCount / 2 * 380, 75);
                        box.list.Location = new Point(20 + TabBundleCount / 2 * 380, 105);
                    }
                    else
                    {
                        box.back1.Location = new Point(30 + TabBundleCount / 2 * 380, 370);
                        box.back2.Location = new Point(25 + TabBundleCount / 2 * 380, 375);
                        box.list.Location = new Point(20 + TabBundleCount / 2 * 380, 405);
                    }
                    box.name.Location = new Point(box.list.Location.X, box.list.Location.Y - 25);
                    box.list.Click += new EventHandler(tabBundleBox_Click);
                    TabBundleCount++;
                    pnlTabBundle.Controls.Add(box.list);
                    pnlTabBundle.Controls.Add(box.name);
                    pnlTabBundle.Controls.Add(box.back2);
                    pnlTabBundle.Controls.Add(box.back1);
                }
                catch
                {
                    MessageBox.Show("저장에 실패했습니다. 이름을 확인하세요.");
                }
            }
        }

        // 즐겨찾기 구성 요소 클릭
        private void favoriteBox_Click(object sender, EventArgs e)
        {
            pnlBookmark.Visible = false;
            GoWebSite(((PictureBox)sender).Tag.ToString());
        }

        private void tabBundleBox_Click(object sender, EventArgs e)
        {
            pnlBookmark.Visible = false;
            string[] urls = ((Label)sender).Tag.ToString().Split('\n');
            string[] list = ((Label)sender).Text.Split('\n');
            int count = 0;
            foreach (string url in urls)
            {
                if (url != "")
                {
                    TabPage tp = new TabPage("");    // 탭 컨트롤에 추가할 탭 페이지 생성
                    tabBrowser.TabPages.Add(tp);   // 탭 컨트롤에 탭 페이지 추가
                    tabBrowser.SelectTab(tabBrowser.TabCount - 1);  // 추가한 탭 페이지 선택
                    wbNewTab = new WebBrowser() { ScriptErrorsSuppressed = true };  // 새 탭에 들어갈 웹브라우저 생성
                    wbNewTab.Parent = tp;  // 해당 웹브라우저의 부모 컨테이너는 새로 추가한 탭 페이지
                    wbNewTab.Dock = DockStyle.Fill; // 부모 컨테이너에 도킹
                    wbNewTab.Navigate(url);   // 새 탭을 HTML의 경로(PictureBox의 Tag에 저장된 내용)로 이동
                    wbNewTab.DocumentCompleted += wbBrowser_DocumentCompleted;  // 웹페이지 로드되면 주소창과 탭 이름 변경
                    tabBrowser.SelectedTab.Text = list[count++];
                    tp.Enter += tpTabPage_Enter;    // 탭 전환하면 주소창 Text 변경
                }
            }
        }

        // 오프라인 구성 요소 클릭
        private void offlineBox_Click(object sender, EventArgs e)
        {
            // 구성 요소를 선택했을 때 새 탭에 페이지 로드
            pnlBookmark.Visible = false;
            TabPage tp = new TabPage("");    // 탭 컨트롤에 추가할 탭 페이지 생성
            tabBrowser.TabPages.Add(tp);   // 탭 컨트롤에 탭 페이지 추가
            tabBrowser.SelectTab(tabBrowser.TabCount - 1);  // 추가한 탭 페이지 선택
            wbNewTab = new WebBrowser() { ScriptErrorsSuppressed = true };  // 새 탭에 들어갈 웹브라우저 생성
            wbNewTab.Parent = tp;  // 해당 웹브라우저의 부모 컨테이너는 새로 추가한 탭 페이지
            wbNewTab.Dock = DockStyle.Fill; // 부모 컨테이너에 도킹
            wbNewTab.Navigate("file:///" + ((PictureBox)sender).Tag.ToString());   // 새 탭을 HTML의 경로(PictureBox의 Tag에 저장된 내용)로 이동
            wbNewTab.DocumentCompleted += wbBrowser_DocumentCompleted;  // 웹페이지 로드되면 주소창과 탭 이름 변경
            tp.Enter += tpTabPage_Enter;    // 탭 전환하면 주소창 Text 변경
        }

        /* 북마크 내 툴바 메뉴 전환 */
        private void picFavorite_Click(object sender, EventArgs e)
        {
            picFavorite.Image = Properties.Resources.Favorite_clicked;
            picTabBundle.Image = Properties.Resources.TabBundle;
            picOfflinePage.Image = Properties.Resources.OfflinePage;
            picHistory.Image = Properties.Resources.History;

            pnlFavorite.Visible = true;
            pnlTabBundle.Visible = false;
            pnlOffline.Visible = false;
            pnlHistory.Visible = false;
        }

        private void picTabBundle_Click(object sender, EventArgs e)
        {
            picFavorite.Image = Properties.Resources.Favorite;
            picTabBundle.Image = Properties.Resources.TabBundle_clicked;
            picOfflinePage.Image = Properties.Resources.OfflinePage;
            picHistory.Image = Properties.Resources.History;

            pnlFavorite.Visible = false;
            pnlTabBundle.Visible = true;
            pnlOffline.Visible = false;
            pnlHistory.Visible = false;
        }

        private void picOfflinePage_Click(object sender, EventArgs e)
        {
            picFavorite.Image = Properties.Resources.Favorite;
            picTabBundle.Image = Properties.Resources.TabBundle;
            picOfflinePage.Image = Properties.Resources.OfflinePage_clicked;
            picHistory.Image = Properties.Resources.History;

            pnlFavorite.Visible = false;
            pnlTabBundle.Visible = false;
            pnlOffline.Visible = true;
            pnlHistory.Visible = false;
        }

        private void picHistory_Click(object sender, EventArgs e)
        {
            picFavorite.Image = Properties.Resources.Favorite;
            picTabBundle.Image = Properties.Resources.TabBundle;
            picOfflinePage.Image = Properties.Resources.OfflinePage;
            picHistory.Image = Properties.Resources.History_clicked;

            pnlFavorite.Visible = false;
            pnlTabBundle.Visible = false;
            pnlOffline.Visible = false;
            pnlHistory.Visible = true;
        }

        private void lvwHistory_DoubleClick(object sender, EventArgs e)
        {
            GoWebSite(lvwHistory.Items[lvwHistory.FocusedItem.Index].SubItems[0].Text);
            pnlBookmark.Visible = false;
        }

        private void tsmiHistoryClear_Click(object sender, EventArgs e) => lvwHistory.Items.Clear();
    }
}
