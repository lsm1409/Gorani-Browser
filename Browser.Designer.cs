namespace GoraniBrowser
{
    partial class frmGoraniBrowser
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoraniBrowser));
            this.tabBrowser = new System.Windows.Forms.TabControl();
            this.tpTabPage = new System.Windows.Forms.TabPage();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.pnlBookmark = new System.Windows.Forms.Panel();
            this.pnlFavorite = new System.Windows.Forms.Panel();
            this.pnlOffline = new System.Windows.Forms.Panel();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.lvwHistory = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colURL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlTabBundle = new System.Windows.Forms.Panel();
            this.picHistory = new System.Windows.Forms.PictureBox();
            this.picOfflinePage = new System.Windows.Forms.PictureBox();
            this.picTabBundle = new System.Windows.Forms.PictureBox();
            this.picFavorite = new System.Windows.Forms.PictureBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.cmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiNewTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiHomepage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddBookmark = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveTab = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaveOffline = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHistoryClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiClose = new System.Windows.Forms.ToolStripMenuItem();
            this.picNewTab = new System.Windows.Forms.PictureBox();
            this.picForward = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.picMemo = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picBookmark = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.tabBrowser.SuspendLayout();
            this.tpTabPage.SuspendLayout();
            this.pnlBookmark.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOfflinePage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabBundle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFavorite)).BeginInit();
            this.cmsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picNewTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBrowser
            // 
            this.tabBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBrowser.Controls.Add(this.tpTabPage);
            this.tabBrowser.ItemSize = new System.Drawing.Size(120, 21);
            this.tabBrowser.Location = new System.Drawing.Point(1, 46);
            this.tabBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBrowser.Name = "tabBrowser";
            this.tabBrowser.SelectedIndex = 0;
            this.tabBrowser.Size = new System.Drawing.Size(985, 630);
            this.tabBrowser.TabIndex = 14;
            this.tabBrowser.DoubleClick += new System.EventHandler(this.tabBrowser_DoubleClick);
            // 
            // tpTabPage
            // 
            this.tpTabPage.Controls.Add(this.wbBrowser);
            this.tpTabPage.Location = new System.Drawing.Point(4, 25);
            this.tpTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTabPage.Name = "tpTabPage";
            this.tpTabPage.Size = new System.Drawing.Size(977, 601);
            this.tpTabPage.TabIndex = 0;
            this.tpTabPage.UseVisualStyleBackColor = true;
            this.tpTabPage.Enter += new System.EventHandler(this.tpTabPage_Enter);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBrowser.Location = new System.Drawing.Point(0, 0);
            this.wbBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(21, 20);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(977, 601);
            this.wbBrowser.TabIndex = 0;
            this.wbBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.wbBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbBrowser_DocumentCompleted);
            // 
            // pnlBookmark
            // 
            this.pnlBookmark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookmark.Controls.Add(this.pnlFavorite);
            this.pnlBookmark.Controls.Add(this.pnlOffline);
            this.pnlBookmark.Controls.Add(this.pnlHistory);
            this.pnlBookmark.Controls.Add(this.pnlTabBundle);
            this.pnlBookmark.Controls.Add(this.picHistory);
            this.pnlBookmark.Controls.Add(this.picOfflinePage);
            this.pnlBookmark.Controls.Add(this.picTabBundle);
            this.pnlBookmark.Controls.Add(this.picFavorite);
            this.pnlBookmark.Location = new System.Drawing.Point(1, 72);
            this.pnlBookmark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBookmark.Name = "pnlBookmark";
            this.pnlBookmark.Size = new System.Drawing.Size(985, 605);
            this.pnlBookmark.TabIndex = 1;
            this.pnlBookmark.Visible = false;
            // 
            // pnlFavorite
            // 
            this.pnlFavorite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFavorite.AutoScroll = true;
            this.pnlFavorite.Location = new System.Drawing.Point(0, 104);
            this.pnlFavorite.Name = "pnlFavorite";
            this.pnlFavorite.Size = new System.Drawing.Size(985, 501);
            this.pnlFavorite.TabIndex = 1;
            // 
            // pnlOffline
            // 
            this.pnlOffline.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlOffline.AutoScroll = true;
            this.pnlOffline.Location = new System.Drawing.Point(0, 104);
            this.pnlOffline.Name = "pnlOffline";
            this.pnlOffline.Size = new System.Drawing.Size(985, 501);
            this.pnlOffline.TabIndex = 3;
            // 
            // pnlHistory
            // 
            this.pnlHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlHistory.AutoScroll = true;
            this.pnlHistory.Controls.Add(this.lvwHistory);
            this.pnlHistory.Location = new System.Drawing.Point(0, 104);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(985, 501);
            this.pnlHistory.TabIndex = 16;
            // 
            // lvwHistory
            // 
            this.lvwHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwHistory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colURL,
            this.colTime});
            this.lvwHistory.FullRowSelect = true;
            this.lvwHistory.Location = new System.Drawing.Point(30, 30);
            this.lvwHistory.Name = "lvwHistory";
            this.lvwHistory.Size = new System.Drawing.Size(925, 441);
            this.lvwHistory.TabIndex = 0;
            this.lvwHistory.UseCompatibleStateImageBehavior = false;
            this.lvwHistory.View = System.Windows.Forms.View.Details;
            this.lvwHistory.DoubleClick += new System.EventHandler(this.lvwHistory_DoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "웹페이지 제목";
            this.colName.Width = 400;
            // 
            // colURL
            // 
            this.colURL.Text = "웹페이지 URL";
            this.colURL.Width = 400;
            // 
            // colTime
            // 
            this.colTime.Text = "방문 시간";
            this.colTime.Width = 400;
            // 
            // pnlTabBundle
            // 
            this.pnlTabBundle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTabBundle.AutoScroll = true;
            this.pnlTabBundle.Location = new System.Drawing.Point(0, 104);
            this.pnlTabBundle.Name = "pnlTabBundle";
            this.pnlTabBundle.Size = new System.Drawing.Size(985, 501);
            this.pnlTabBundle.TabIndex = 2;
            // 
            // picHistory
            // 
            this.picHistory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picHistory.Image = ((System.Drawing.Image)(resources.GetObject("picHistory.Image")));
            this.picHistory.Location = new System.Drawing.Point(748, 33);
            this.picHistory.Name = "picHistory";
            this.picHistory.Size = new System.Drawing.Size(228, 50);
            this.picHistory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHistory.TabIndex = 2;
            this.picHistory.TabStop = false;
            this.picHistory.Click += new System.EventHandler(this.picHistory_Click);
            // 
            // picOfflinePage
            // 
            this.picOfflinePage.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picOfflinePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOfflinePage.Image = ((System.Drawing.Image)(resources.GetObject("picOfflinePage.Image")));
            this.picOfflinePage.Location = new System.Drawing.Point(501, 33);
            this.picOfflinePage.Name = "picOfflinePage";
            this.picOfflinePage.Size = new System.Drawing.Size(228, 50);
            this.picOfflinePage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOfflinePage.TabIndex = 2;
            this.picOfflinePage.TabStop = false;
            this.picOfflinePage.Click += new System.EventHandler(this.picOfflinePage_Click);
            // 
            // picTabBundle
            // 
            this.picTabBundle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picTabBundle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picTabBundle.Image = ((System.Drawing.Image)(resources.GetObject("picTabBundle.Image")));
            this.picTabBundle.Location = new System.Drawing.Point(254, 33);
            this.picTabBundle.Name = "picTabBundle";
            this.picTabBundle.Size = new System.Drawing.Size(228, 50);
            this.picTabBundle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTabBundle.TabIndex = 2;
            this.picTabBundle.TabStop = false;
            this.picTabBundle.Click += new System.EventHandler(this.picTabBundle_Click);
            // 
            // picFavorite
            // 
            this.picFavorite.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picFavorite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picFavorite.Image = ((System.Drawing.Image)(resources.GetObject("picFavorite.Image")));
            this.picFavorite.Location = new System.Drawing.Point(7, 33);
            this.picFavorite.Name = "picFavorite";
            this.picFavorite.Size = new System.Drawing.Size(228, 50);
            this.picFavorite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFavorite.TabIndex = 2;
            this.picFavorite.TabStop = false;
            this.picFavorite.Click += new System.EventHandler(this.picFavorite_Click);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(145, 12);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(729, 25);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // cmsMenu
            // 
            this.cmsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiNewTab,
            this.tsmiNewWindow,
            this.toolStripSeparator1,
            this.tsmiHomepage,
            this.tsmiAddBookmark,
            this.tsmiSaveTab,
            this.tsmiSaveOffline,
            this.tsmiHistoryClear,
            this.toolStripSeparator2,
            this.tsmiPrint,
            this.toolStripSeparator3,
            this.tsmiClose});
            this.cmsMenu.Name = "picMenuctxtMenuStrip";
            this.cmsMenu.Size = new System.Drawing.Size(209, 238);
            // 
            // tsmiNewTab
            // 
            this.tsmiNewTab.Name = "tsmiNewTab";
            this.tsmiNewTab.Size = new System.Drawing.Size(208, 24);
            this.tsmiNewTab.Text = "새 탭(&T)";
            this.tsmiNewTab.Click += new System.EventHandler(this.tsmiNewTab_Click);
            // 
            // tsmiNewWindow
            // 
            this.tsmiNewWindow.Name = "tsmiNewWindow";
            this.tsmiNewWindow.Size = new System.Drawing.Size(208, 24);
            this.tsmiNewWindow.Text = "새 창(&N)";
            this.tsmiNewWindow.Click += new System.EventHandler(this.tsmiNewWindow_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(205, 6);
            // 
            // tsmiHomepage
            // 
            this.tsmiHomepage.Name = "tsmiHomepage";
            this.tsmiHomepage.Size = new System.Drawing.Size(208, 24);
            this.tsmiHomepage.Text = "홈페이지 변경";
            this.tsmiHomepage.Click += new System.EventHandler(this.tsmiHomepage_Click);
            // 
            // tsmiAddBookmark
            // 
            this.tsmiAddBookmark.Name = "tsmiAddBookmark";
            this.tsmiAddBookmark.Size = new System.Drawing.Size(208, 24);
            this.tsmiAddBookmark.Text = "즐겨찾기 추가";
            this.tsmiAddBookmark.Click += new System.EventHandler(this.tsmiAddBookmark_Click);
            // 
            // tsmiSaveTab
            // 
            this.tsmiSaveTab.Name = "tsmiSaveTab";
            this.tsmiSaveTab.Size = new System.Drawing.Size(208, 24);
            this.tsmiSaveTab.Text = "탭묶음 저장";
            this.tsmiSaveTab.Click += new System.EventHandler(this.tsmiSaveTab_Click);
            // 
            // tsmiSaveOffline
            // 
            this.tsmiSaveOffline.Name = "tsmiSaveOffline";
            this.tsmiSaveOffline.Size = new System.Drawing.Size(208, 24);
            this.tsmiSaveOffline.Text = "오프라인으로 저장";
            this.tsmiSaveOffline.Click += new System.EventHandler(this.tsmiSaveOffline_Click);
            // 
            // tsmiHistoryClear
            // 
            this.tsmiHistoryClear.Name = "tsmiHistoryClear";
            this.tsmiHistoryClear.Size = new System.Drawing.Size(208, 24);
            this.tsmiHistoryClear.Text = "방문기록 전부 삭제";
            this.tsmiHistoryClear.Click += new System.EventHandler(this.tsmiHistoryClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(205, 6);
            // 
            // tsmiPrint
            // 
            this.tsmiPrint.Name = "tsmiPrint";
            this.tsmiPrint.Size = new System.Drawing.Size(208, 24);
            this.tsmiPrint.Text = "인쇄(&P)";
            this.tsmiPrint.Click += new System.EventHandler(this.tsmiPrint_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(205, 6);
            // 
            // tsmiClose
            // 
            this.tsmiClose.Name = "tsmiClose";
            this.tsmiClose.Size = new System.Drawing.Size(208, 24);
            this.tsmiClose.Text = "종료(&X)";
            this.tsmiClose.Click += new System.EventHandler(this.tsmiClose_Click);
            // 
            // picNewTab
            // 
            this.picNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNewTab.BackColor = System.Drawing.Color.LightGray;
            this.picNewTab.Image = global::GoraniBrowser.Properties.Resources.NewTab;
            this.picNewTab.Location = new System.Drawing.Point(958, 50);
            this.picNewTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picNewTab.Name = "picNewTab";
            this.picNewTab.Size = new System.Drawing.Size(18, 20);
            this.picNewTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewTab.TabIndex = 15;
            this.picNewTab.TabStop = false;
            this.picNewTab.Click += new System.EventHandler(this.picNewTab_Click);
            this.picNewTab.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picNewTab.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picNewTab.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picNewTab.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // picForward
            // 
            this.picForward.Image = global::GoraniBrowser.Properties.Resources.Forword;
            this.picForward.Location = new System.Drawing.Point(37, 9);
            this.picForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picForward.Name = "picForward";
            this.picForward.Size = new System.Drawing.Size(30, 30);
            this.picForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForward.TabIndex = 6;
            this.picForward.TabStop = false;
            this.picForward.Click += new System.EventHandler(this.picForward_Click);
            this.picForward.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picForward.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picForward.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picForward.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // picMenu
            // 
            this.picMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMenu.Image = global::GoraniBrowser.Properties.Resources.Menu;
            this.picMenu.Location = new System.Drawing.Point(952, 9);
            this.picMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(30, 30);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 10;
            this.picMenu.TabStop = false;
            this.picMenu.Click += new System.EventHandler(this.picMenu_Click);
            this.picMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picMenu.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picMenu.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // picMemo
            // 
            this.picMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMemo.Image = global::GoraniBrowser.Properties.Resources.Memo;
            this.picMemo.Location = new System.Drawing.Point(917, 9);
            this.picMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMemo.Name = "picMemo";
            this.picMemo.Size = new System.Drawing.Size(30, 30);
            this.picMemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMemo.TabIndex = 9;
            this.picMemo.TabStop = false;
            this.picMemo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picMemo.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picMemo.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picMemo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // picBack
            // 
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(1, 9);
            this.picBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(30, 30);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 5;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            this.picBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picBack.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picBack.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picBack.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // picBookmark
            // 
            this.picBookmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBookmark.Image = global::GoraniBrowser.Properties.Resources.Bookmark;
            this.picBookmark.Location = new System.Drawing.Point(880, 9);
            this.picBookmark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBookmark.Name = "picBookmark";
            this.picBookmark.Size = new System.Drawing.Size(30, 30);
            this.picBookmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBookmark.TabIndex = 11;
            this.picBookmark.TabStop = false;
            this.picBookmark.Click += new System.EventHandler(this.picBookmark_Click);
            this.picBookmark.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picBookmark.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picBookmark.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picBookmark.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // picHome
            // 
            this.picHome.Image = global::GoraniBrowser.Properties.Resources.Home;
            this.picHome.Location = new System.Drawing.Point(109, 9);
            this.picHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(30, 30);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 8;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            this.picHome.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picHome.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picHome.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picHome.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::GoraniBrowser.Properties.Resources.Refresh;
            this.picRefresh.Location = new System.Drawing.Point(73, 9);
            this.picRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(30, 30);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 7;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            this.picRefresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picRefresh.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picRefresh.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picRefresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // frmGoraniBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 679);
            this.Controls.Add(this.pnlBookmark);
            this.Controls.Add(this.picNewTab);
            this.Controls.Add(this.picForward);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.picMemo);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.picBookmark);
            this.Controls.Add(this.tabBrowser);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picRefresh);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmGoraniBrowser";
            this.Text = "Gorani Browser";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabBrowser.ResumeLayout(false);
            this.tpTabPage.ResumeLayout(false);
            this.pnlBookmark.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOfflinePage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTabBundle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFavorite)).EndInit();
            this.cmsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picNewTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TabControl tabBrowser;
        private System.Windows.Forms.TabPage tpTabPage;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picForward;
        private System.Windows.Forms.PictureBox picMemo;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.PictureBox picBookmark;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.PictureBox picNewTab;
        private System.Windows.Forms.WebBrowser wbBrowser;
        private System.Windows.Forms.Panel pnlBookmark;
        private System.Windows.Forms.ContextMenuStrip cmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewTab;
        private System.Windows.Forms.ToolStripMenuItem tsmiNewWindow;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiHomepage;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddBookmark;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveTab;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaveOffline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiClose;
        private System.Windows.Forms.Panel pnlFavorite;
        private System.Windows.Forms.PictureBox picHistory;
        private System.Windows.Forms.PictureBox picOfflinePage;
        private System.Windows.Forms.PictureBox picTabBundle;
        private System.Windows.Forms.PictureBox picFavorite;
        private System.Windows.Forms.Panel pnlOffline;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.ListView lvwHistory;
        private System.Windows.Forms.ColumnHeader colURL;
        private System.Windows.Forms.ColumnHeader colTime;
        private System.Windows.Forms.ToolStripMenuItem tsmiHistoryClear;
        private System.Windows.Forms.Panel pnlTabBundle;
        private System.Windows.Forms.ColumnHeader colName;
    }
}

