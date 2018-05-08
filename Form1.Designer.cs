﻿namespace GoraniBrowser
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
            this.tabBrowser = new System.Windows.Forms.TabControl();
            this.tpTabPage = new System.Windows.Forms.TabPage();
            this.wbBrowser = new System.Windows.Forms.WebBrowser();
            this.pnlBookmark = new System.Windows.Forms.Panel();
            this.picBack = new System.Windows.Forms.PictureBox();
            this.picForward = new System.Windows.Forms.PictureBox();
            this.picMemo = new System.Windows.Forms.PictureBox();
            this.picMenu = new System.Windows.Forms.PictureBox();
            this.picBookmark = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.picNewTab = new System.Windows.Forms.PictureBox();
            this.tabBrowser.SuspendLayout();
            this.tpTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMemo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookmark)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewTab)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBrowser
            // 
            this.tabBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBrowser.Controls.Add(this.tpTabPage);
            this.tabBrowser.Location = new System.Drawing.Point(1, 48);
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
            this.wbBrowser.MinimumSize = new System.Drawing.Size(20, 20);
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
            this.pnlBookmark.Enabled = false;
            this.pnlBookmark.Location = new System.Drawing.Point(1, 73);
            this.pnlBookmark.Name = "pnlBookmark";
            this.pnlBookmark.Size = new System.Drawing.Size(985, 605);
            this.pnlBookmark.TabIndex = 1;
            this.pnlBookmark.Visible = false;
            // 
            // picBack
            // 
            this.picBack.Image = ((System.Drawing.Image)(resources.GetObject("picBack.Image")));
            this.picBack.Location = new System.Drawing.Point(1, 9);
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
            // picForward
            // 
            this.picForward.Image = global::GoraniBrowser.Properties.Resources.Forword;
            this.picForward.Location = new System.Drawing.Point(37, 9);
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
            // picMemo
            // 
            this.picMemo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMemo.Image = global::GoraniBrowser.Properties.Resources.Memo;
            this.picMemo.Location = new System.Drawing.Point(916, 9);
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
            // picMenu
            // 
            this.picMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMenu.Image = global::GoraniBrowser.Properties.Resources.Menu;
            this.picMenu.Location = new System.Drawing.Point(952, 9);
            this.picMenu.Name = "picMenu";
            this.picMenu.Size = new System.Drawing.Size(30, 30);
            this.picMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenu.TabIndex = 10;
            this.picMenu.TabStop = false;
            this.picMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseDown);
            this.picMenu.MouseLeave += new System.EventHandler(this.picButton_MouseLeave);
            this.picMenu.MouseHover += new System.EventHandler(this.picButton_MouseHover);
            this.picMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picButton_MouseUp);
            // 
            // picBookmark
            // 
            this.picBookmark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBookmark.Image = global::GoraniBrowser.Properties.Resources.Bookmark;
            this.picBookmark.Location = new System.Drawing.Point(880, 9);
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
            // picRefresh
            // 
            this.picRefresh.Image = global::GoraniBrowser.Properties.Resources.Refresh;
            this.picRefresh.Location = new System.Drawing.Point(73, 9);
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
            // picHome
            // 
            this.picHome.Image = global::GoraniBrowser.Properties.Resources.Home;
            this.picHome.Location = new System.Drawing.Point(109, 9);
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
            // picNewTab
            // 
            this.picNewTab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picNewTab.BackColor = System.Drawing.Color.LightGray;
            this.picNewTab.Image = global::GoraniBrowser.Properties.Resources.NewTab;
            this.picNewTab.Location = new System.Drawing.Point(958, 50);
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
            // frmGoraniBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.Name = "frmGoraniBrowser";
            this.Text = "Gorani Browser";
            this.tabBrowser.ResumeLayout(false);
            this.tpTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMemo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBookmark)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNewTab)).EndInit();
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
    }
}

