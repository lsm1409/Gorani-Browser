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
            this.btnBefore = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wbMain
            // 
            this.wbMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wbMain.Location = new System.Drawing.Point(14, 49);
            this.wbMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.wbMain.MinimumSize = new System.Drawing.Size(23, 25);
            this.wbMain.Name = "wbMain";
            this.wbMain.ScriptErrorsSuppressed = true;
            this.wbMain.Size = new System.Drawing.Size(923, 534);
            this.wbMain.TabIndex = 4;
            this.wbMain.Url = new System.Uri("http://www.google.com/", System.UriKind.Absolute);
            this.wbMain.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wbMain_DocumentCompleted);
            // 
            // txtUrl
            // 
            this.txtUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUrl.Location = new System.Drawing.Point(112, 15);
            this.txtUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(735, 25);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://www.google.com/";
            this.txtUrl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUrl_KeyDown);
            // 
            // btnBefore
            // 
            this.btnBefore.BackColor = System.Drawing.Color.Black;
            this.btnBefore.Location = new System.Drawing.Point(14, 15);
            this.btnBefore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBefore.Name = "btnBefore";
            this.btnBefore.Size = new System.Drawing.Size(43, 26);
            this.btnBefore.TabIndex = 2;
            this.btnBefore.Text = "<";
            this.btnBefore.UseVisualStyleBackColor = true;
            this.btnBefore.Click += new System.EventHandler(this.btnBefore_Click);
            // 
            // btnForward
            // 
            this.btnForward.BackColor = System.Drawing.Color.Black;
            this.btnForward.Location = new System.Drawing.Point(64, 15);
            this.btnForward.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(43, 26);
            this.btnForward.TabIndex = 3;
            this.btnForward.Text = ">";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // btnGo
            // 
            this.btnGo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGo.BackColor = System.Drawing.Color.Black;
            this.btnGo.Location = new System.Drawing.Point(855, 15);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(82, 26);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "GO";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmGoraniBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(951, 598);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBefore);
            this.Controls.Add(this.txtUrl);
            this.Controls.Add(this.wbMain);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGoraniBrowser";
            this.Text = "Gorani Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbMain;
        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.Button btnBefore;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Button btnGo;
    }
}

