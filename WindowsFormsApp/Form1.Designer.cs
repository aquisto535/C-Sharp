namespace WindowsFormsApp
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
            this.btnevent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbame = new System.Windows.Forms.CheckBox();
            this.ckblatte = new System.Windows.Forms.CheckBox();
            this.ckbmoca = new System.Windows.Forms.CheckBox();
            this.ckbgreen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblorder = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioagree1 = new System.Windows.Forms.RadioButton();
            this.radiodisagree = new System.Windows.Forms.RadioButton();
            this.btnenter = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbpay = new System.Windows.Forms.ComboBox();
            this.lbInfo = new System.Windows.Forms.ListBox();
            this.lblpay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnevent
            // 
            this.btnevent.BackColor = System.Drawing.Color.DarkRed;
            this.btnevent.Font = new System.Drawing.Font("굵은안상수체", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnevent.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnevent.Location = new System.Drawing.Point(798, 537);
            this.btnevent.Name = "btnevent";
            this.btnevent.Size = new System.Drawing.Size(175, 91);
            this.btnevent.TabIndex = 0;
            this.btnevent.Text = "주 문";
            this.btnevent.UseVisualStyleBackColor = false;
            this.btnevent.Click += new System.EventHandler(this.btnevent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굵은안상수체", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(446, 9);
            this.label1.MaximumSize = new System.Drawing.Size(229, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 64);
            this.label1.TabIndex = 1;
            this.label1.Text = "주문";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ckbame
            // 
            this.ckbame.AutoSize = true;
            this.ckbame.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold);
            this.ckbame.Location = new System.Drawing.Point(110, 116);
            this.ckbame.Name = "ckbame";
            this.ckbame.Size = new System.Drawing.Size(171, 31);
            this.ckbame.TabIndex = 2;
            this.ckbame.Text = "아메리카노";
            this.ckbame.UseVisualStyleBackColor = true;
            // 
            // ckblatte
            // 
            this.ckblatte.AutoSize = true;
            this.ckblatte.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckblatte.Location = new System.Drawing.Point(317, 116);
            this.ckblatte.Name = "ckblatte";
            this.ckblatte.Size = new System.Drawing.Size(143, 31);
            this.ckblatte.TabIndex = 3;
            this.ckblatte.Text = "카페라떼";
            this.ckblatte.UseVisualStyleBackColor = true;
            // 
            // ckbmoca
            // 
            this.ckbmoca.AutoSize = true;
            this.ckbmoca.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbmoca.Location = new System.Drawing.Point(513, 116);
            this.ckbmoca.Name = "ckbmoca";
            this.ckbmoca.Size = new System.Drawing.Size(143, 31);
            this.ckbmoca.TabIndex = 4;
            this.ckbmoca.Text = "카페모카";
            this.ckbmoca.UseVisualStyleBackColor = true;
            // 
            // ckbgreen
            // 
            this.ckbgreen.AutoSize = true;
            this.ckbgreen.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ckbgreen.Location = new System.Drawing.Point(703, 116);
            this.ckbgreen.Name = "ckbgreen";
            this.ckbgreen.Size = new System.Drawing.Size(87, 31);
            this.ckbgreen.TabIndex = 5;
            this.ckbgreen.Text = "녹차";
            this.ckbgreen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굵은안상수체", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(88, 554);
            this.label2.MaximumSize = new System.Drawing.Size(229, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 64);
            this.label2.TabIndex = 6;
            this.label2.Text = "주문결과 :";
            // 
            // lblorder
            // 
            this.lblorder.AutoSize = true;
            this.lblorder.Font = new System.Drawing.Font("굴림", 20F);
            this.lblorder.Location = new System.Drawing.Point(256, 527);
            this.lblorder.Name = "lblorder";
            this.lblorder.Size = new System.Drawing.Size(0, 27);
            this.lblorder.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.Color.PeachPuff;
            this.label3.Location = new System.Drawing.Point(105, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(510, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "이벤트 응모를 위한 개인정보 수집 동의";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // radioagree1
            // 
            this.radioagree1.AutoSize = true;
            this.radioagree1.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radioagree1.Location = new System.Drawing.Point(55, 20);
            this.radioagree1.Name = "radioagree1";
            this.radioagree1.Size = new System.Drawing.Size(86, 31);
            this.radioagree1.TabIndex = 9;
            this.radioagree1.TabStop = true;
            this.radioagree1.Text = "동의";
            this.radioagree1.UseVisualStyleBackColor = true;
            // 
            // radiodisagree
            // 
            this.radiodisagree.AutoSize = true;
            this.radiodisagree.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.radiodisagree.Location = new System.Drawing.Point(182, 20);
            this.radiodisagree.Name = "radiodisagree";
            this.radiodisagree.Size = new System.Drawing.Size(152, 31);
            this.radiodisagree.TabIndex = 10;
            this.radiodisagree.TabStop = true;
            this.radiodisagree.Text = "동의 안함";
            this.radiodisagree.UseVisualStyleBackColor = true;
            // 
            // btnenter
            // 
            this.btnenter.BackColor = System.Drawing.Color.Salmon;
            this.btnenter.Font = new System.Drawing.Font("굴림", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnenter.Location = new System.Drawing.Point(546, 209);
            this.btnenter.Name = "btnenter";
            this.btnenter.Size = new System.Drawing.Size(124, 63);
            this.btnenter.TabIndex = 11;
            this.btnenter.Text = "확인";
            this.btnenter.UseVisualStyleBackColor = false;
            this.btnenter.Click += new System.EventHandler(this.btnenter_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioagree1);
            this.groupBox1.Controls.Add(this.radiodisagree);
            this.groupBox1.Location = new System.Drawing.Point(115, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 59);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtOrder
            // 
            this.txtOrder.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.txtOrder.Location = new System.Drawing.Point(110, 327);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.Size = new System.Drawing.Size(546, 66);
            this.txtOrder.TabIndex = 13;
            this.txtOrder.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Violet;
            this.label4.Location = new System.Drawing.Point(105, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 27);
            this.label4.TabIndex = 14;
            this.label4.Text = "주문 시 요구사항";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SlateBlue;
            this.label5.Location = new System.Drawing.Point(112, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "결제 방법";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SlateBlue;
            this.label6.Location = new System.Drawing.Point(374, 419);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "결제정보";
            // 
            // cbpay
            // 
            this.cbpay.Font = new System.Drawing.Font("굵은안상수체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cbpay.FormattingEnabled = true;
            this.cbpay.Items.AddRange(new object[] {
            "신용카드",
            "현금",
            "포인트"});
            this.cbpay.Location = new System.Drawing.Point(110, 453);
            this.cbpay.Name = "cbpay";
            this.cbpay.Size = new System.Drawing.Size(184, 35);
            this.cbpay.TabIndex = 17;
            this.cbpay.Text = "신용카드";
            this.cbpay.SelectedIndexChanged += new System.EventHandler(this.cbpay_SelectedIndexChanged);
            // 
            // lbInfo
            // 
            this.lbInfo.Font = new System.Drawing.Font("굵은안상수체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbInfo.FormattingEnabled = true;
            this.lbInfo.ItemHeight = 27;
            this.lbInfo.Items.AddRange(new object[] {
            "일시불",
            "3개월 할부",
            "6개월 할부"});
            this.lbInfo.Location = new System.Drawing.Point(377, 453);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(194, 85);
            this.lbInfo.TabIndex = 18;
            this.lbInfo.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblpay
            // 
            this.lblpay.AutoSize = true;
            this.lblpay.Font = new System.Drawing.Font("굵은안상수체", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblpay.Location = new System.Drawing.Point(571, 576);
            this.lblpay.Name = "lblpay";
            this.lblpay.Size = new System.Drawing.Size(0, 27);
            this.lblpay.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1035, 709);
            this.Controls.Add(this.lblpay);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.cbpay);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnenter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblorder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ckbgreen);
            this.Controls.Add(this.ckbmoca);
            this.Controls.Add(this.ckblatte);
            this.Controls.Add(this.ckbame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnevent);
            this.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "주문 버튼";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnevent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbame;
        private System.Windows.Forms.CheckBox ckblatte;
        private System.Windows.Forms.CheckBox ckbmoca;
        private System.Windows.Forms.CheckBox ckbgreen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblorder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioagree1;
        private System.Windows.Forms.RadioButton radiodisagree;
        private System.Windows.Forms.Button btnenter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbpay;
        private System.Windows.Forms.ListBox lbInfo;
        private System.Windows.Forms.Label lblpay;
    }
}

