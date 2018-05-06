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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGoraniBrowser));
            this.wbMain = new System.Windows.Forms.WebBrowser();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.pnlBookmark = new System.Windows.Forms.Panel();
            this.picNewTab = new System.Windows.Forms.PictureBox();
            this.picBookmark = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.picMemo = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picForward = new System.Windows.Forms.PictureBox();
            this.picBack = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picNewTab)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            this.SuspendLayout();
            // 
            // wbMain
            // 
            this.wbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbMain.Location = new System.Drawing.Point(14, 100);
            this.wbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wbMain.MinimumSize = new System.Drawing.Size(23, 25);
            this.wbMain.Name = "wbMain";
            this.wbMain.ScriptErrorsSuppressed = true;
            this.wbMain.Size = new System.Drawing.Size(923, 554);
            this.wbMain.TabIndex = 4;
            this.wbMain.Url = new System.Uri("http://www.google.com/", System.UriKind.Absolute);
            this.wbMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMain_DocumentCompleted);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(178, 63);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(636, 25);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://www.google.com/";
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // pnlBookmark
            // 
            this.pnlBookmark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBookmark.BackColor = System.Drawing.Color.Transparent;
            this.pnlBookmark.Location = new System.Drawing.Point(12, 100);
            this.pnlBookmark.Name = "pnlBookmark";
            this.pnlBookmark.Size = new System.Drawing.Size(927, 554);
            this.pnlBookmark.TabIndex = 12;
            this.pnlBookmark.Visible = false;
            // 
            // picNewTab
            // 
            this.picNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNewTab.Image = global::GoraniBrowser.Properties.Resources.NewTab;
            this.picNewTab.Location = new System.Drawing.Point(913, 15);
            this.picNewTab.Name = "picNewTab";
            this.picNewTab.Size = new System.Drawing.Size(25, 25);
            this.picNewTab.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNewTab.TabIndex = 13;
            this.picNewTab.TabStop = false;
            // 
            // picBookmark
            // 
            this.picBookmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBookmark.Image = global::GoraniBrowser.Properties.Resources.Bookmark;
            this.picBookmark.Location = new System.Drawing.Point(820, 53);
            this.picBookmark.Name = "picBookmark";
            this.picBookmark.Size = new System.Drawing.Size(35, 35);
            this.picBookmark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBookmark.TabIndex = 11;
            this.picBookmark.TabStop = false;
            this.picBookmark.Click += new System.EventHandler(this.picBookmark_Click);
            // 
            // picMenu
            // 
            this.picMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMenu.Image = global::GoraniBrowser.Properties.Resources.Menu;
            this.picMenu.Location = new System.Drawing.Point(902, 53);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(35, 35);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 10;
            this.picMenu.TabStop = false;
            // 
            // picMemo
            // 
            this.picMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMemo.Image = global::GoraniBrowser.Properties.Resources.Memo;
            this.picMemo.Location = new System.Drawing.Point(861, 53);
            this.picMemo.Name = "picMemo";
            this.picMemo.Size = new System.Drawing.Size(35, 35);
            this.picMemo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMemo.TabIndex = 9;
            this.picMemo.TabStop = false;
            // 
            // picHome
            // 
            this.picHome.Image = global::GoraniBrowser.Properties.Resources.Home;
            this.picHome.Location = new System.Drawing.Point(137, 53);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(35, 35);
            this.picHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHome.TabIndex = 8;
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // picRefresh
            // 
            this.picRefresh.Image = global::GoraniBrowser.Properties.Resources.Refresh;
            this.picRefresh.Location = new System.Drawing.Point(96, 53);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(35, 35);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picRefresh.TabIndex = 7;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // picForward
            // 
            this.picForward.Image = global::GoraniBrowser.Properties.Resources.Forword;
            this.picForward.Location = new System.Drawing.Point(55, 53);
            this.picForward.Name = "picForward";
            this.picForward.Size = new System.Drawing.Size(35, 35);
            this.picForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForward.TabIndex = 6;
            this.picForward.TabStop = false;
            this.picForward.Click += new System.EventHandler(this.picForward_Click);
            // 
            // picBack
            // 
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(14, 53);
            this.picBack.Name = "picBack";
            this.picBack.Size = new System.Drawing.Size(35, 35);
            this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBack.TabIndex = 5;
            this.picBack.TabStop = false;
            this.picBack.Click += new System.EventHandler(this.picBack_Click);
            // 
            // frmGoraniBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(951, 669);
            this.Controls.Add(this.picNewTab);
            this.Controls.Add(this.pnlBookmark);
            this.Controls.Add(this.picBookmark);
            this.Controls.Add(this.picMenu);
            this.Controls.Add(this.picMemo);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.picForward);
            this.Controls.Add(this.picBack);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.wbMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGoraniBrowser";
            this.Text = "Gorani Browser";
            ((System.ComponentModel.ISupportInitialize)(this.picNewTab)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.PictureBox picBack;
        private System.Windows.Forms.PictureBox picForward;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.PictureBox picMemo;
        private System.Windows.Forms.PictureBox picMenu;
        private System.Windows.Forms.PictureBox picBookmark;
        private System.Windows.Forms.Panel pnlBookmark;
        private System.Windows.Forms.PictureBox picNewTab;
    }
}

