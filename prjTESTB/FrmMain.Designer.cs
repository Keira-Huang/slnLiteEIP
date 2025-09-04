namespace prjTESTB
{
    partial class FrmMain
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.but_empsystem = new System.Windows.Forms.Button();
            this.but_clock = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.timerMarquee = new System.Windows.Forms.Timer(this.components);
            this.lblLogout = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // but_empsystem
            // 
            this.but_empsystem.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_empsystem.Location = new System.Drawing.Point(175, 177);
            this.but_empsystem.Name = "but_empsystem";
            this.but_empsystem.Size = new System.Drawing.Size(106, 68);
            this.but_empsystem.TabIndex = 0;
            this.but_empsystem.Text = "員工管理";
            this.but_empsystem.UseVisualStyleBackColor = true;
            this.but_empsystem.Click += new System.EventHandler(this.but_empsystem_Click);
            // 
            // but_clock
            // 
            this.but_clock.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_clock.Location = new System.Drawing.Point(397, 177);
            this.but_clock.Name = "but_clock";
            this.but_clock.Size = new System.Drawing.Size(108, 68);
            this.but_clock.TabIndex = 1;
            this.but_clock.Text = "打卡鐘";
            this.but_clock.UseVisualStyleBackColor = true;
            this.but_clock.Click += new System.EventHandler(this.but_clock_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblWelcome.Location = new System.Drawing.Point(12, 108);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(660, 55);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "label1";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timerMarquee
            // 
            this.timerMarquee.Enabled = true;
            this.timerMarquee.Interval = 500;
            this.timerMarquee.Tick += new System.EventHandler(this.timerMarquee_Tick);
            // 
            // lblLogout
            // 
            this.lblLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogout.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblLogout.ForeColor = System.Drawing.Color.Maroon;
            this.lblLogout.Location = new System.Drawing.Point(294, 320);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(97, 31);
            this.lblLogout.TabIndex = 3;
            this.lblLogout.Text = "Log out";
            this.lblLogout.Click += new System.EventHandler(this.lblLogout_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 379);
            this.Controls.Add(this.lblLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.but_clock);
            this.Controls.Add(this.but_empsystem);
            this.Name = "FrmMain";
            this.Text = "首頁";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_empsystem;
        private System.Windows.Forms.Button but_clock;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Timer timerMarquee;
        private System.Windows.Forms.Label lblLogout;
    }
}

