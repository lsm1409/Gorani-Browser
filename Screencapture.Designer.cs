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
            this.picboxScrn = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPaint = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnDrawing = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxScrn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(797, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 22);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(223, 2);
            this.trackBar.Maximum = 50;
            this.trackBar.Minimum = 1;
            this.trackBar.Margin = new System.Windows.Forms.Padding(2);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(73, 45);
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Value = 1;
            this.trackBar.TabIndex = 7;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // ShowColor
            // 
            this.ShowColor.BackColor = System.Drawing.Color.Black;
            this.ShowColor.Location = new System.Drawing.Point(300, 2);
            this.ShowColor.Margin = new System.Windows.Forms.Padding(2);
            this.ShowColor.Name = "ShowColor";
            this.ShowColor.Size = new System.Drawing.Size(52, 24);
            this.ShowColor.TabIndex = 8;
            this.ShowColor.Click += new System.EventHandler(this.ShowColor_Click);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(300, 31);
            this.btnColor.Margin = new System.Windows.Forms.Padding(2);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(52, 25);
            this.btnColor.TabIndex = 0;
            this.btnColor.Text = "색";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // picboxScrn
            // 
            this.picboxScrn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picboxScrn.Location = new System.Drawing.Point(8, 86);
            this.picboxScrn.Margin = new System.Windows.Forms.Padding(2);
            this.picboxScrn.Name = "picboxScrn";
            this.picboxScrn.Size = new System.Drawing.Size(780, 362);
            this.picboxScrn.TabIndex = 0;
            this.picboxScrn.TabStop = false;
            this.picboxScrn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picboxScrn_MouseDown);
            this.picboxScrn.MouseEnter += new System.EventHandler(this.picboxScrn_MouseEnter);
            this.picboxScrn.MouseLeave += new System.EventHandler(this.picboxScrn_MouseLeave);
            this.picboxScrn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picboxScrn_MouseMove);
            this.picboxScrn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picboxScrn_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnPaint);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnEraser);
            this.panel1.Controls.Add(this.btnDrawing);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.ShowColor);
            this.panel1.Controls.Add(this.trackBar);
            this.panel1.Location = new System.Drawing.Point(8, 24);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 58);
            this.panel1.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::GoraniBrowser.Properties.Resources.Save;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSave.Location = new System.Drawing.Point(430, 0);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 56);
            this.btnSave.TabIndex = 14;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPaint
            // 
            this.btnPaint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPaint.BackgroundImage = global::GoraniBrowser.Properties.Resources.Paint;
            this.btnPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPaint.Location = new System.Drawing.Point(356, 0);
            this.btnPaint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaint.Name = "btnPaint";
            this.btnPaint.Size = new System.Drawing.Size(70, 56);
            this.btnPaint.TabIndex = 13;
            this.btnPaint.UseVisualStyleBackColor = false;
            this.btnPaint.Click += new System.EventHandler(this.btnPaint_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = global::GoraniBrowser.Properties.Resources.Shapemode;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRectangle.Location = new System.Drawing.Point(150, 1);
            this.btnRectangle.Margin = new System.Windows.Forms.Padding(2);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(72, 55);
            this.btnRectangle.TabIndex = 12;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.SystemColors.Control;
            this.btnEraser.BackgroundImage = global::GoraniBrowser.Properties.Resources.Rubber;
            this.btnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEraser.Location = new System.Drawing.Point(76, 2);
            this.btnEraser.Margin = new System.Windows.Forms.Padding(2);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(70, 54);
            this.btnEraser.TabIndex = 11;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnDrawing
            // 
            this.btnDrawing.BackColor = System.Drawing.SystemColors.Control;
            this.btnDrawing.BackgroundImage = global::GoraniBrowser.Properties.Resources.Pencil;
            this.btnDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDrawing.Location = new System.Drawing.Point(2, 2);
            this.btnDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.btnDrawing.Name = "btnDrawing";
            this.btnDrawing.Size = new System.Drawing.Size(70, 54);
            this.btnDrawing.TabIndex = 10;
            this.btnDrawing.UseVisualStyleBackColor = false;
            this.btnDrawing.Click += new System.EventHandler(this.btnDrawing_Click);
            // 
            // frmScreencapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 451);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picboxScrn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmScreencapture";
            this.Text = "스크린캡쳐";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxScrn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}