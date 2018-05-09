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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.picMenuctxtMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.새탭TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.새창NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.인쇄PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.즐겨찾기추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.탭저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.오프라인으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.인쇄PToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picNewTab = new System.Windows.Forms.PictureBox();
            this.picForward = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.picMemo = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picBookmark = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tabBrowser.SuspendLayout();
            this.tpTabPage.SuspendLayout();
            this.picMenuctxtMenuStrip.SuspendLayout();
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
            this.tabBrowser.Location = new System.Drawing.Point(1, 38);
            this.tabBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabBrowser.Name = "tabBrowser";
            this.tabBrowser.SelectedIndex = 0;
            this.tabBrowser.Size = new System.Drawing.Size(862, 504);
            this.tabBrowser.TabIndex = 14;
            this.tabBrowser.DoubleClick += new System.EventHandler(this.tabBrowser_DoubleClick);
            // 
            // tpTabPage
            // 
            this.tpTabPage.Controls.Add(this.wbBrowser);
            this.tpTabPage.Location = new System.Drawing.Point(4, 22);
            this.tpTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTabPage.Name = "tpTabPage";
            this.tpTabPage.Size = new System.Drawing.Size(854, 478);
            this.tpTabPage.TabIndex = 0;
            this.tpTabPage.UseVisualStyleBackColor = true;
            this.tpTabPage.Enter += new System.EventHandler(this.tpTabPage_Enter);
            // 
            // wbBrowser
            // 
            this.wbBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbBrowser.Location = new System.Drawing.Point(0, 0);
            this.wbBrowser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wbBrowser.MinimumSize = new System.Drawing.Size(18, 16);
            this.wbBrowser.Name = "wbBrowser";
            this.wbBrowser.Size = new System.Drawing.Size(854, 478);
            this.wbBrowser.TabIndex = 0;
            this.wbBrowser.Url = new System.Uri("", System.UriKind.Relative);
            this.wbBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbBrowser_DocumentCompleted);
            // 
            // pnlBookmark
            // 
            this.pnlBookmark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookmark.Enabled = false;
            this.pnlBookmark.Location = new System.Drawing.Point(1, 58);
            this.pnlBookmark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBookmark.Name = "pnlBookmark";
            this.pnlBookmark.Size = new System.Drawing.Size(862, 484);
            this.pnlBookmark.TabIndex = 1;
            this.pnlBookmark.Visible = false;
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(127, 10);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(638, 21);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // picMenuctxtMenuStrip
            // 
            this.picMenuctxtMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새탭TToolStripMenuItem,
            this.새창NToolStripMenuItem,
            this.toolStripSeparator1,
            this.인쇄PToolStripMenuItem,
            this.즐겨찾기추가ToolStripMenuItem,
            this.탭저장ToolStripMenuItem,
            this.오프라인으로저장ToolStripMenuItem,
            this.toolStripSeparator2,
            this.인쇄PToolStripMenuItem1,
            this.toolStripSeparator3,
            this.종료ToolStripMenuItem});
            this.picMenuctxtMenuStrip.Name = "picMenuctxtMenuStrip";
            this.picMenuctxtMenuStrip.Size = new System.Drawing.Size(175, 220);
            // 
            // 새탭TToolStripMenuItem
            // 
            this.새탭TToolStripMenuItem.Name = "새탭TToolStripMenuItem";
            this.새탭TToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.새탭TToolStripMenuItem.Text = "새 탭(T)";
            this.새탭TToolStripMenuItem.Click += new System.EventHandler(this.새탭TToolStripMenuItem_Click);
            // 
            // 새창NToolStripMenuItem
            // 
            this.새창NToolStripMenuItem.Name = "새창NToolStripMenuItem";
            this.새창NToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.새창NToolStripMenuItem.Text = "새 창(N)";
            this.새창NToolStripMenuItem.Click += new System.EventHandler(this.새창NToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(171, 6);
            // 
            // 인쇄PToolStripMenuItem
            // 
            this.인쇄PToolStripMenuItem.Name = "인쇄PToolStripMenuItem";
            this.인쇄PToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.인쇄PToolStripMenuItem.Text = "홈페이지 변경";
            // 
            // 즐겨찾기추가ToolStripMenuItem
            // 
            this.즐겨찾기추가ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.추가ToolStripMenuItem,
            this.toolStripSeparator5});
            this.즐겨찾기추가ToolStripMenuItem.Name = "즐겨찾기추가ToolStripMenuItem";
            this.즐겨찾기추가ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.즐겨찾기추가ToolStripMenuItem.Text = "즐겨찾기 추가";
            // 
            // 탭저장ToolStripMenuItem
            // 
            this.탭저장ToolStripMenuItem.Name = "탭저장ToolStripMenuItem";
            this.탭저장ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.탭저장ToolStripMenuItem.Text = "탭 저장";
            // 
            // 오프라인으로저장ToolStripMenuItem
            // 
            this.오프라인으로저장ToolStripMenuItem.Name = "오프라인으로저장ToolStripMenuItem";
            this.오프라인으로저장ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.오프라인으로저장ToolStripMenuItem.Text = "오프라인으로 저장";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // 인쇄PToolStripMenuItem1
            // 
            this.인쇄PToolStripMenuItem1.Name = "인쇄PToolStripMenuItem1";
            this.인쇄PToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.인쇄PToolStripMenuItem1.Text = "인쇄(P)";
            this.인쇄PToolStripMenuItem1.Click += new System.EventHandler(this.인쇄PToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(171, 6);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.종료ToolStripMenuItem.Text = "종료(X)";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종ToolStripMenuItem_Click);
            // 
            // picNewTab
            // 
            this.picNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNewTab.BackColor = System.Drawing.Color.LightGray;
            this.picNewTab.Image = global::GoraniBrowser.Properties.Resources.NewTab;
            this.picNewTab.Location = new System.Drawing.Point(838, 40);
            this.picNewTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picNewTab.Name = "picNewTab";
            this.picNewTab.Size = new System.Drawing.Size(16, 16);
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
            this.picForward.Location = new System.Drawing.Point(32, 7);
            this.picForward.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picForward.Name = "picForward";
            this.picForward.Size = new System.Drawing.Size(26, 24);
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
            this.picMenu.Location = new System.Drawing.Point(833, 7);
            this.picMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(26, 24);
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
            this.picMemo.Location = new System.Drawing.Point(802, 7);
            this.picMemo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMemo.Name = "picMemo";
            this.picMemo.Size = new System.Drawing.Size(26, 24);
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
            this.picBack.Location = new System.Drawing.Point(1, 7);
            this.picBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(26, 24);
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
            this.picBookmark.Location = new System.Drawing.Point(770, 7);
            this.picBookmark.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBookmark.Name = "picBookmark";
            this.picBookmark.Size = new System.Drawing.Size(26, 24);
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
            this.picHome.Location = new System.Drawing.Point(95, 7);
            this.picHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(26, 24);
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
            this.picRefresh.Location = new System.Drawing.Point(64, 7);
            this.picRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(26, 24);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 7;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            this.picRefresh.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picRefresh.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picRefresh.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picRefresh.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // 추가ToolStripMenuItem
            // 
            this.추가ToolStripMenuItem.Name = "추가ToolStripMenuItem";
            this.추가ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.추가ToolStripMenuItem.Text = "추가";
            this.추가ToolStripMenuItem.Click += new System.EventHandler(this.추가ToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // frmGoraniBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(861, 543);
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
            this.tabBrowser.ResumeLayout(false);
            this.tpTabPage.ResumeLayout(false);
            this.picMenuctxtMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.ContextMenuStrip picMenuctxtMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem 새탭TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 새창NToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 인쇄PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 즐겨찾기추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 탭저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 오프라인으로저장ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 인쇄PToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 추가ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

