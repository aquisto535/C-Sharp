namespace easyCareApp
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pat_consult = new System.Windows.Forms.TextBox();
            this.saveRecordBtn = new System.Windows.Forms.Button();
            this.diag_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1190, 459);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pat_consult
            // 
            this.pat_consult.Location = new System.Drawing.Point(12, 547);
            this.pat_consult.Multiline = true;
            this.pat_consult.Name = "pat_consult";
            this.pat_consult.Size = new System.Drawing.Size(984, 86);
            this.pat_consult.TabIndex = 1;
            // 
            // saveRecordBtn
            // 
            this.saveRecordBtn.Location = new System.Drawing.Point(1017, 547);
            this.saveRecordBtn.Name = "saveRecordBtn";
            this.saveRecordBtn.Size = new System.Drawing.Size(154, 36);
            this.saveRecordBtn.TabIndex = 2;
            this.saveRecordBtn.Text = "기록 저장";
            this.saveRecordBtn.UseVisualStyleBackColor = true;
            this.saveRecordBtn.Click += new System.EventHandler(this.saveRecordBtn_Click);
            // 
            // diag_exit
            // 
            this.diag_exit.Location = new System.Drawing.Point(1017, 598);
            this.diag_exit.Name = "diag_exit";
            this.diag_exit.Size = new System.Drawing.Size(157, 35);
            this.diag_exit.TabIndex = 3;
            this.diag_exit.Text = "진료 종료";
            this.diag_exit.UseVisualStyleBackColor = true;
            this.diag_exit.Click += new System.EventHandler(this.diag_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 658);
            this.Controls.Add(this.diag_exit);
            this.Controls.Add(this.saveRecordBtn);
            this.Controls.Add(this.pat_consult);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(1, 64);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox pat_consult;
        private System.Windows.Forms.Button saveRecordBtn;
        private System.Windows.Forms.Button diag_exit;
    }
}

