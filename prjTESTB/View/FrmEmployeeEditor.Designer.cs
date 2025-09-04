namespace prjTESTB.View
{
    partial class FrmEmployeeEditor
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
            this.but_confirm = new System.Windows.Forms.Button();
            this.butt_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fb_Pwd = new prjTESTB.View.FieldBox();
            this.fb_Email = new prjTESTB.View.FieldBox();
            this.fb_Title = new prjTESTB.View.FieldBox();
            this.fb_Name = new prjTESTB.View.FieldBox();
            this.fb_EmpId = new prjTESTB.View.FieldBox();
            this.fb_fId = new prjTESTB.View.FieldBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // but_confirm
            // 
            this.but_confirm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.but_confirm.Location = new System.Drawing.Point(620, 378);
            this.but_confirm.Margin = new System.Windows.Forms.Padding(4);
            this.but_confirm.Name = "but_confirm";
            this.but_confirm.Size = new System.Drawing.Size(116, 51);
            this.but_confirm.TabIndex = 6;
            this.but_confirm.Text = "確定";
            this.but_confirm.UseVisualStyleBackColor = true;
            this.but_confirm.Click += new System.EventHandler(this.but_confirm_Click);
            // 
            // butt_cancel
            // 
            this.butt_cancel.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.butt_cancel.Location = new System.Drawing.Point(509, 378);
            this.butt_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.butt_cancel.Name = "butt_cancel";
            this.butt_cancel.Size = new System.Drawing.Size(103, 51);
            this.butt_cancel.TabIndex = 5;
            this.butt_cancel.Text = "取消";
            this.butt_cancel.UseVisualStyleBackColor = true;
            this.butt_cancel.Click += new System.EventHandler(this.butt_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(509, 13);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 260);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FileDialog
            // 
            this.FileDialog.FileName = "openFileDialog1";
            // 
            // fb_Pwd
            // 
            this.fb_Pwd.fieldName = "密碼";
            this.fb_Pwd.fieldValue = "";
            this.fb_Pwd.Location = new System.Drawing.Point(28, 342);
            this.fb_Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.fb_Pwd.Name = "fb_Pwd";
            this.fb_Pwd.passwordChar = '\0';
            this.fb_Pwd.Size = new System.Drawing.Size(420, 76);
            this.fb_Pwd.TabIndex = 4;
            // 
            // fb_Email
            // 
            this.fb_Email.fieldName = "電子郵件";
            this.fb_Email.fieldValue = "";
            this.fb_Email.Location = new System.Drawing.Point(28, 174);
            this.fb_Email.Margin = new System.Windows.Forms.Padding(4);
            this.fb_Email.Name = "fb_Email";
            this.fb_Email.passwordChar = '\0';
            this.fb_Email.Size = new System.Drawing.Size(420, 76);
            this.fb_Email.TabIndex = 2;
            // 
            // fb_Title
            // 
            this.fb_Title.fieldName = "職稱";
            this.fb_Title.fieldValue = "";
            this.fb_Title.Location = new System.Drawing.Point(28, 258);
            this.fb_Title.Margin = new System.Windows.Forms.Padding(4);
            this.fb_Title.Name = "fb_Title";
            this.fb_Title.passwordChar = '\0';
            this.fb_Title.Size = new System.Drawing.Size(420, 76);
            this.fb_Title.TabIndex = 3;
            // 
            // fb_Name
            // 
            this.fb_Name.fieldName = "姓名";
            this.fb_Name.fieldValue = "";
            this.fb_Name.Location = new System.Drawing.Point(28, 97);
            this.fb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.fb_Name.Name = "fb_Name";
            this.fb_Name.passwordChar = '\0';
            this.fb_Name.Size = new System.Drawing.Size(420, 76);
            this.fb_Name.TabIndex = 1;
            // 
            // fb_EmpId
            // 
            this.fb_EmpId.fieldName = "員工編號";
            this.fb_EmpId.fieldValue = "";
            this.fb_EmpId.Location = new System.Drawing.Point(28, 13);
            this.fb_EmpId.Margin = new System.Windows.Forms.Padding(4);
            this.fb_EmpId.Name = "fb_EmpId";
            this.fb_EmpId.passwordChar = '\0';
            this.fb_EmpId.Size = new System.Drawing.Size(420, 76);
            this.fb_EmpId.TabIndex = 0;
            // 
            // fb_fId
            // 
            this.fb_fId.fieldName = "fid";
            this.fb_fId.fieldValue = "0";
            this.fb_fId.Location = new System.Drawing.Point(509, 282);
            this.fb_fId.Margin = new System.Windows.Forms.Padding(4);
            this.fb_fId.Name = "fb_fId";
            this.fb_fId.passwordChar = '\0';
            this.fb_fId.Size = new System.Drawing.Size(122, 76);
            this.fb_fId.TabIndex = 0;
            this.fb_fId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(455, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(455, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(455, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(455, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // FrmEmployeeEditor
            // 
            this.AcceptButton = this.but_confirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butt_cancel);
            this.Controls.Add(this.but_confirm);
            this.Controls.Add(this.fb_Pwd);
            this.Controls.Add(this.fb_Email);
            this.Controls.Add(this.fb_Title);
            this.Controls.Add(this.fb_Name);
            this.Controls.Add(this.fb_EmpId);
            this.Controls.Add(this.fb_fId);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEmployeeEditor";
            this.Text = "新增基本資料";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FieldBox fb_fId;
        private FieldBox fb_EmpId;
        private FieldBox fb_Name;
        private FieldBox fb_Title;
        private FieldBox fb_Email;
        private FieldBox fb_Pwd;
        private System.Windows.Forms.Button but_confirm;
        private System.Windows.Forms.Button butt_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog FileDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}