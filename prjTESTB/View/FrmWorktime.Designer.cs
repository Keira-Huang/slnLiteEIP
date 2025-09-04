namespace prjTESTB.View
{
    partial class FrmWorktime
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWorktime));
            this.lab_EmpName = new System.Windows.Forms.Label();
            this.lab_timenow = new System.Windows.Forms.Label();
            this.lab_datetime = new System.Windows.Forms.Label();
            this.but_btnPunch = new System.Windows.Forms.Button();
            this.lab_NAME1 = new System.Windows.Forms.Label();
            this.comboPunchType = new System.Windows.Forms.ComboBox();
            this.lab_punchtime = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.but_RecordList = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_EmpName
            // 
            this.lab_EmpName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_EmpName.Location = new System.Drawing.Point(238, 36);
            this.lab_EmpName.Name = "lab_EmpName";
            this.lab_EmpName.Size = new System.Drawing.Size(102, 37);
            this.lab_EmpName.TabIndex = 0;
            this.lab_EmpName.Text = "label1";
            // 
            // lab_timenow
            // 
            this.lab_timenow.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_timenow.Location = new System.Drawing.Point(98, 143);
            this.lab_timenow.Name = "lab_timenow";
            this.lab_timenow.Size = new System.Drawing.Size(109, 37);
            this.lab_timenow.TabIndex = 0;
            this.lab_timenow.Text = "現在時間 : ";
            // 
            // lab_datetime
            // 
            this.lab_datetime.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_datetime.Location = new System.Drawing.Point(238, 143);
            this.lab_datetime.Name = "lab_datetime";
            this.lab_datetime.Size = new System.Drawing.Size(315, 37);
            this.lab_datetime.TabIndex = 0;
            this.lab_datetime.Text = "label1";
            // 
            // but_btnPunch
            // 
            this.but_btnPunch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_btnPunch.Location = new System.Drawing.Point(559, 36);
            this.but_btnPunch.Name = "but_btnPunch";
            this.but_btnPunch.Size = new System.Drawing.Size(136, 90);
            this.but_btnPunch.TabIndex = 1;
            this.but_btnPunch.Text = "確認送出";
            this.but_btnPunch.UseVisualStyleBackColor = true;
            this.but_btnPunch.Click += new System.EventHandler(this.but_btnPunch_Click);
            // 
            // lab_NAME1
            // 
            this.lab_NAME1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_NAME1.Location = new System.Drawing.Point(98, 36);
            this.lab_NAME1.Name = "lab_NAME1";
            this.lab_NAME1.Size = new System.Drawing.Size(118, 37);
            this.lab_NAME1.TabIndex = 0;
            this.lab_NAME1.Text = "員工姓名 : ";
            // 
            // comboPunchType
            // 
            this.comboPunchType.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboPunchType.FormattingEnabled = true;
            this.comboPunchType.Items.AddRange(new object[] {
            "上班",
            "下班"});
            this.comboPunchType.Location = new System.Drawing.Point(378, 36);
            this.comboPunchType.Name = "comboPunchType";
            this.comboPunchType.Size = new System.Drawing.Size(121, 39);
            this.comboPunchType.TabIndex = 2;
            // 
            // lab_punchtime
            // 
            this.lab_punchtime.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_punchtime.Location = new System.Drawing.Point(238, 89);
            this.lab_punchtime.Name = "lab_punchtime";
            this.lab_punchtime.Size = new System.Drawing.Size(315, 37);
            this.lab_punchtime.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(98, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "簽到時間 : ";
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // but_RecordList
            // 
            this.but_RecordList.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_RecordList.Location = new System.Drawing.Point(560, 132);
            this.but_RecordList.Name = "but_RecordList";
            this.but_RecordList.Size = new System.Drawing.Size(135, 48);
            this.but_RecordList.TabIndex = 5;
            this.but_RecordList.Text = "打卡紀錄";
            this.but_RecordList.UseVisualStyleBackColor = true;
            this.but_RecordList.Click += new System.EventHandler(this.but_RecordList_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 211);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // FrmWorktime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.but_RecordList);
            this.Controls.Add(this.lab_punchtime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPunchType);
            this.Controls.Add(this.but_btnPunch);
            this.Controls.Add(this.lab_NAME1);
            this.Controls.Add(this.lab_EmpName);
            this.Controls.Add(this.lab_datetime);
            this.Controls.Add(this.lab_timenow);
            this.Name = "FrmWorktime";
            this.Text = "FrmWorktime";
            this.Load += new System.EventHandler(this.FrmWorktime_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_EmpName;
        private System.Windows.Forms.Label lab_timenow;
        private System.Windows.Forms.Label lab_datetime;
        private System.Windows.Forms.Button but_btnPunch;
        private System.Windows.Forms.Label lab_NAME1;
        private System.Windows.Forms.ComboBox comboPunchType;
        private System.Windows.Forms.Label lab_punchtime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Button but_RecordList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}