namespace GoraniBrowser
{
    partial class frmScreencapture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScreencapture));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.ShowColor = new System.Windows.Forms.Panel();
            this.btnColor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnDrawing = new System.Windows.Forms.Button();
            this.picboxScrn = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxScrn)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1139, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(319, 3);
            this.trackBar.Maximum = 50;
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(104, 69);
            this.trackBar.TabIndex = 7;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Value = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // ShowColor
            // 
            this.ShowColor.BackColor = System.Drawing.Color.Black;
            this.ShowColor.Location = new System.Drawing.Point(429, 3);
            this.ShowColor.Name = "ShowColor";
            this.ShowColor.Size = new System.Drawing.Size(74, 36);
            this.ShowColor.TabIndex = 8;
            this.ShowColor.Click += new System.EventHandler(this.ShowColor_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(429, 46);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(74, 38);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "색";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnPaint);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnDrawing);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.ShowColor);
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Location = new System.Drawing.Point(11, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1114, 87);
            this.panel1.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::GoraniBrowser.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(614, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 84);
            this.btnSave.TabIndex = 14;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPaint.BackgroundImage = global::GoraniBrowser.Properties.Resources.Paint;
            this.btnPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaint.Location = new System.Drawing.Point(509, 0);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(100, 84);
            this.btnPaint.TabIndex = 13;
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = global::GoraniBrowser.Properties.Resources.Shapemode;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRectangle.Location = new System.Drawing.Point(214, 2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(103, 82);
            this.btnRectangle.TabIndex = 12;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.SystemColors.Control;
            this.btnEraser.BackgroundImage = global::GoraniBrowser.Properties.Resources.Rubber;
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEraser.Location = new System.Drawing.Point(109, 3);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(100, 81);
            this.btnEraser.TabIndex = 11;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnDrawing
            // 
            this.btnDrawing.BackColor = System.Drawing.SystemColors.Control;
            this.btnDrawing.BackgroundImage = global::GoraniBrowser.Properties.Resources.Pencil;
            this.btnDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawing.Location = new System.Drawing.Point(3, 3);
            this.btnDrawing.Name = "btnDrawing";
            this.btnDrawing.Size = new System.Drawing.Size(100, 81);
            this.btnDrawing.TabIndex = 10;
            this.btnDrawing.UseVisualStyleBackColor = false;
            this.btnDrawing.Click += new System.EventHandler(this.btnDrawing_Click);
            // 
            // picboxScrn
            // 
            this.picboxScrn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxScrn.BackColor = System.Drawing.Color.Transparent;
            this.picboxScrn.Location = new System.Drawing.Point(0, 0);
            this.picboxScrn.Name = "picboxScrn";
            this.picboxScrn.Size = new System.Drawing.Size(1114, 543);
            this.picboxScrn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxScrn.TabIndex = 0;
            this.picboxScrn.TabStop = false;
            this.picboxScrn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picboxScrn_MouseDown);
            this.picboxScrn.MouseEnter += new System.EventHandler(this.picboxScrn_MouseEnter);
            this.picboxScrn.MouseLeave += new System.EventHandler(this.picboxScrn_MouseLeave);
            this.picboxScrn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picboxScrn_MouseMove);
            this.picboxScrn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picboxScrn_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.picboxScrn);
            this.panel2.Location = new System.Drawing.Point(11, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1114, 535);
            this.panel2.TabIndex = 11;
            // 
            // frmScreencapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1139, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmScreencapture";
            this.Text = "스크린캡쳐";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxScrn)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox picboxScrn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Panel ShowColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDrawing;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPaint;
        private System.Windows.Forms.Panel panel2;
    }
}