namespace Drawing_App
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.toolstripBtnLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonblack = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRed = new System.Windows.Forms.ToolStripButton();
            this.green = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripComboThick = new System.Windows.Forms.ToolStripComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menubar = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripnew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripexit = new System.Windows.Forms.ToolStripMenuItem();
            this.도형ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstriprect = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripcircle = new System.Windows.Forms.ToolStripMenuItem();
            this.색상ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripcolor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolbar.SuspendLayout();
            this.menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripBtnLine,
            this.toolStripButton2,
            this.toolStripButton1,
            this.toolStripButtonblack,
            this.toolStripButtonRed,
            this.green,
            this.toolStripButtonBlue,
            this.toolStripComboThick});
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(1005, 25);
            this.toolbar.TabIndex = 0;
            this.toolbar.Text = "toolStrip1";
            // 
            // toolstripBtnLine
            // 
            this.toolstripBtnLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolstripBtnLine.Image = ((System.Drawing.Image)(resources.GetObject("toolstripBtnLine.Image")));
            this.toolstripBtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolstripBtnLine.Name = "toolstripBtnLine";
            this.toolstripBtnLine.Size = new System.Drawing.Size(23, 22);
            this.toolstripBtnLine.Text = "직선";
            this.toolstripBtnLine.Click += new System.EventHandler(this.toolstripBtnLine_Click);
            this.toolstripBtnLine.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolstripBtnLine_MouseDown);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "원";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "사각형";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButtonblack
            // 
            this.toolStripButtonblack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonblack.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonblack.Image")));
            this.toolStripButtonblack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonblack.Name = "toolStripButtonblack";
            this.toolStripButtonblack.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonblack.Text = "toolStripButton5";
            this.toolStripButtonblack.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButtonRed
            // 
            this.toolStripButtonRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRed.Image")));
            this.toolStripButtonRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRed.Name = "toolStripButtonRed";
            this.toolStripButtonRed.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRed.Text = "빨간색";
            this.toolStripButtonRed.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // green
            // 
            this.green.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.green.Image = ((System.Drawing.Image)(resources.GetObject("green.Image")));
            this.green.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(23, 22);
            this.green.Text = "toolStripButton4";
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // toolStripButtonBlue
            // 
            this.toolStripButtonBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBlue.Image")));
            this.toolStripButtonBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBlue.Name = "toolStripButtonBlue";
            this.toolStripButtonBlue.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBlue.Text = "파란색";
            this.toolStripButtonBlue.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripComboThick
            // 
            this.toolStripComboThick.Items.AddRange(new object[] {
            "1.",
            "2.",
            "3.",
            "4.",
            "5."});
            this.toolStripComboThick.Name = "toolStripComboThick";
            this.toolStripComboThick.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboThick.Text = "1";
            this.toolStripComboThick.ToolTipText = "선굵기";
            this.toolStripComboThick.SelectedIndexChanged += new System.EventHandler(this.toolStripComboThick_SelectedIndexChanged);
            this.toolStripComboThick.Click += new System.EventHandler(this.toolStripComboThick_Click);
            // 
            // menubar
            // 
            this.menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도형ToolStripMenuItem,
            this.색상ToolStripMenuItem});
            this.menubar.Location = new System.Drawing.Point(0, 0);
            this.menubar.Name = "menubar";
            this.menubar.Size = new System.Drawing.Size(1005, 24);
            this.menubar.TabIndex = 1;
            this.menubar.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripnew,
            this.toolstripexit});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            this.파일ToolStripMenuItem.Click += new System.EventHandler(this.파일ToolStripMenuItem_Click);
            // 
            // toolstripnew
            // 
            this.toolstripnew.Name = "toolstripnew";
            this.toolstripnew.Size = new System.Drawing.Size(180, 22);
            this.toolstripnew.Text = "새로 만들기";
            this.toolstripnew.Click += new System.EventHandler(this.toolstripnew_Click);
            // 
            // toolstripexit
            // 
            this.toolstripexit.Name = "toolstripexit";
            this.toolstripexit.Size = new System.Drawing.Size(180, 22);
            this.toolstripexit.Text = "끝내기";
            this.toolstripexit.Click += new System.EventHandler(this.toolstripexit_Click);
            // 
            // 도형ToolStripMenuItem
            // 
            this.도형ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripline,
            this.toolstriprect,
            this.toolstripcircle});
            this.도형ToolStripMenuItem.Name = "도형ToolStripMenuItem";
            this.도형ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.도형ToolStripMenuItem.Text = "도형";
            // 
            // toolstripline
            // 
            this.toolstripline.Name = "toolstripline";
            this.toolstripline.Size = new System.Drawing.Size(180, 22);
            this.toolstripline.Text = "직선";
            this.toolstripline.Click += new System.EventHandler(this.toolstripline_Click);
            // 
            // toolstriprect
            // 
            this.toolstriprect.Name = "toolstriprect";
            this.toolstriprect.Size = new System.Drawing.Size(180, 22);
            this.toolstriprect.Text = "사각형";
            this.toolstriprect.Click += new System.EventHandler(this.toolstriprect_Click);
            // 
            // toolstripcircle
            // 
            this.toolstripcircle.Name = "toolstripcircle";
            this.toolstripcircle.Size = new System.Drawing.Size(180, 22);
            this.toolstripcircle.Text = "원";
            this.toolstripcircle.Click += new System.EventHandler(this.toolstripcircle_Click);
            // 
            // 색상ToolStripMenuItem
            // 
            this.색상ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripcolor});
            this.색상ToolStripMenuItem.Name = "색상ToolStripMenuItem";
            this.색상ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.색상ToolStripMenuItem.Text = "색상";
            // 
            // toolstripcolor
            // 
            this.toolstripcolor.Name = "toolstripcolor";
            this.toolstripcolor.Size = new System.Drawing.Size(180, 22);
            this.toolstripcolor.Text = "색깔 선택";
            this.toolstripcolor.Click += new System.EventHandler(this.toolstripcolor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1005, 592);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menubar);
            this.MainMenuStrip = this.menubar;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.toolbar.ResumeLayout(false);
            this.toolbar.PerformLayout();
            this.menubar.ResumeLayout(false);
            this.menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.MenuStrip menubar;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstripnew;
        private System.Windows.Forms.ToolStripMenuItem toolstripexit;
        private System.Windows.Forms.ToolStripMenuItem 도형ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstripline;
        private System.Windows.Forms.ToolStripMenuItem toolstriprect;
        private System.Windows.Forms.ToolStripMenuItem toolstripcircle;
        private System.Windows.Forms.ToolStripMenuItem 색상ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstripcolor;
        private System.Windows.Forms.ToolStripButton toolstripBtnLine;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButtonblack;
        private System.Windows.Forms.ToolStripButton toolStripButtonRed;
        private System.Windows.Forms.ToolStripButton green;
        private System.Windows.Forms.ToolStripButton toolStripButtonBlue;
        private System.Windows.Forms.ToolStripComboBox toolStripComboThick;
    }
}

