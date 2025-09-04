namespace prjTESTB.View
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.but_lognok = new System.Windows.Forms.Button();
            this.but_logok = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fbPassword = new prjTESTB.View.FieldBox();
            this.fbAccount = new prjTESTB.View.FieldBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_lognok
            // 
            this.but_lognok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_lognok.Cursor = System.Windows.Forms.Cursors.Default;
            this.but_lognok.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_lognok.Location = new System.Drawing.Point(433, 294);
            this.but_lognok.Name = "but_lognok";
            this.but_lognok.Size = new System.Drawing.Size(105, 50);
            this.but_lognok.TabIndex = 2;
            this.but_lognok.Text = "取消";
            this.but_lognok.UseVisualStyleBackColor = true;
            this.but_lognok.Click += new System.EventHandler(this.but_lognok_Click);
            // 
            // but_logok
            // 
            this.but_logok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.but_logok.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_logok.Location = new System.Drawing.Point(544, 294);
            this.but_logok.Name = "but_logok";
            this.but_logok.Size = new System.Drawing.Size(105, 50);
            this.but_logok.TabIndex = 3;
            this.but_logok.Text = "確認";
            this.but_logok.UseVisualStyleBackColor = true;
            this.but_logok.Click += new System.EventHandler(this.but_logok_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMessage.Location = new System.Drawing.Point(63, 220);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(283, 48);
            this.lblMessage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(498, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "忘記密碼";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(42, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(615, 2);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 167);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // fbPassword
            // 
            this.fbPassword.fieldName = "密碼";
            this.fbPassword.fieldValue = "";
            this.fbPassword.Location = new System.Drawing.Point(63, 139);
            this.fbPassword.Name = "fbPassword";
            this.fbPassword.passwordChar = '●';
            this.fbPassword.Size = new System.Drawing.Size(401, 57);
            this.fbPassword.TabIndex = 1;
            // 
            // fbAccount
            // 
            this.fbAccount.fieldName = "帳號(員工ID)";
            this.fbAccount.fieldValue = "";
            this.fbAccount.Location = new System.Drawing.Point(63, 59);
            this.fbAccount.Name = "fbAccount";
            this.fbAccount.passwordChar = '\0';
            this.fbAccount.Size = new System.Drawing.Size(401, 57);
            this.fbAccount.TabIndex = 0;
            // 
            // FrmLogin
            // 
            this.AcceptButton = this.but_logok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 356);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.but_logok);
            this.Controls.Add(this.but_lognok);
            this.Controls.Add(this.fbPassword);
            this.Controls.Add(this.fbAccount);
            this.Name = "FrmLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.FrmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FieldBox fbAccount;
        private FieldBox fbPassword;
        private System.Windows.Forms.Button but_lognok;
        private System.Windows.Forms.Button but_logok;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}