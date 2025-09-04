namespace prjTEST1
{
    partial class FrmEmployeeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEmployeeList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.But_Refresh = new System.Windows.Forms.ToolStripButton();
            this.But_Create = new System.Windows.Forms.ToolStripButton();
            this.But_Delete = new System.Windows.Forms.ToolStripButton();
            this.But_Update = new System.Windows.Forms.ToolStripButton();
            this.But_search = new System.Windows.Forms.ToolStripButton();
            this.txtKeyword = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.But_Refresh,
            this.But_Create,
            this.But_Delete,
            this.But_Update,
            this.But_search,
            this.txtKeyword});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // But_Refresh
            // 
            this.But_Refresh.Image = ((System.Drawing.Image)(resources.GetObject("But_Refresh.Image")));
            this.But_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.But_Refresh.Name = "But_Refresh";
            this.But_Refresh.Size = new System.Drawing.Size(68, 28);
            this.But_Refresh.Text = "重整";
            this.But_Refresh.Click += new System.EventHandler(this.But_Refresh_Click);
            // 
            // But_Create
            // 
            this.But_Create.Image = ((System.Drawing.Image)(resources.GetObject("But_Create.Image")));
            this.But_Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.But_Create.Name = "But_Create";
            this.But_Create.Size = new System.Drawing.Size(68, 28);
            this.But_Create.Text = "新增";
            this.But_Create.Click += new System.EventHandler(this.But_Create_Click);
            // 
            // But_Delete
            // 
            this.But_Delete.Image = ((System.Drawing.Image)(resources.GetObject("But_Delete.Image")));
            this.But_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.But_Delete.Name = "But_Delete";
            this.But_Delete.Size = new System.Drawing.Size(68, 28);
            this.But_Delete.Text = "刪除";
            this.But_Delete.Click += new System.EventHandler(this.But_Delete_Click);
            // 
            // But_Update
            // 
            this.But_Update.Image = ((System.Drawing.Image)(resources.GetObject("But_Update.Image")));
            this.But_Update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.But_Update.Name = "But_Update";
            this.But_Update.Size = new System.Drawing.Size(68, 28);
            this.But_Update.Text = "修改";
            this.But_Update.Click += new System.EventHandler(this.But_Update_Click);
            // 
            // But_search
            // 
            this.But_search.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.But_search.Image = ((System.Drawing.Image)(resources.GetObject("But_search.Image")));
            this.But_search.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.But_search.Name = "But_search";
            this.But_search.Size = new System.Drawing.Size(68, 28);
            this.But_search.Text = "查詢";
            this.But_search.Click += new System.EventHandler(this.But_search_Click);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.txtKeyword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtKeyword.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(100, 31);
            this.txtKeyword.Click += new System.EventHandler(this.txtKeyword_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 419);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // FrmEmployeeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmEmployeeList";
            this.Text = "FrmEmployeeList";
            this.Load += new System.EventHandler(this.FrmEmployeeList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton But_Refresh;
        private System.Windows.Forms.ToolStripButton But_Create;
        private System.Windows.Forms.ToolStripButton But_Delete;
        private System.Windows.Forms.ToolStripButton But_Update;
        private System.Windows.Forms.ToolStripTextBox txtKeyword;
        private System.Windows.Forms.ToolStripButton But_search;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}