using System.Windows.Forms;

namespace QuanLySinhVien
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgv = new System.Windows.Forms.DataGridView();
            this.Add_button = new System.Windows.Forms.Button();
            this.cbb1 = new System.Windows.Forms.ComboBox();
            this.Change_button = new System.Windows.Forms.Button();
            this.Del_button = new System.Windows.Forms.Button();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.stextbox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.AdvancedSearch_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(12, 55);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(998, 280);
            this.dgv.TabIndex = 0;
            this.dgv.SelectionChanged += new System.EventHandler(this.dgv_SelectionChanged);
            // 
            // Add_button
            // 
            this.Add_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_button.Location = new System.Drawing.Point(713, 12);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(95, 37);
            this.Add_button.TabIndex = 3;
            this.Add_button.Text = "Thêm";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // cbb1
            // 
            this.cbb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb1.FormattingEnabled = true;
            this.cbb1.Items.AddRange(new object[] {
            "SinhVien",
            "GiangVien",
            "MonHoc",
            "KQHocTap"});
            this.cbb1.Location = new System.Drawing.Point(12, 12);
            this.cbb1.Name = "cbb1";
            this.cbb1.Size = new System.Drawing.Size(121, 24);
            this.cbb1.TabIndex = 1;
            this.cbb1.SelectedIndexChanged += new System.EventHandler(this.cbb1_SelectedIndexChanged);
            // 
            // Change_button
            // 
            this.Change_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Change_button.Enabled = false;
            this.Change_button.Location = new System.Drawing.Point(814, 12);
            this.Change_button.Name = "Change_button";
            this.Change_button.Size = new System.Drawing.Size(95, 37);
            this.Change_button.TabIndex = 4;
            this.Change_button.Text = "Sửa";
            this.Change_button.UseVisualStyleBackColor = true;
            this.Change_button.Click += new System.EventHandler(this.Change_button_Click);
            // 
            // Del_button
            // 
            this.Del_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Del_button.Enabled = false;
            this.Del_button.Location = new System.Drawing.Point(915, 12);
            this.Del_button.Name = "Del_button";
            this.Del_button.Size = new System.Drawing.Size(95, 37);
            this.Del_button.TabIndex = 5;
            this.Del_button.Text = "Xoá";
            this.Del_button.UseVisualStyleBackColor = true;
            this.Del_button.Click += new System.EventHandler(this.Del_button_Click);
            // 
            // Refresh_button
            // 
            this.Refresh_button.Location = new System.Drawing.Point(139, 12);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(95, 37);
            this.Refresh_button.TabIndex = 2;
            this.Refresh_button.Text = "Làm mới";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // stextbox
            // 
            this.stextbox.Location = new System.Drawing.Point(412, 19);
            this.stextbox.Name = "stextbox";
            this.stextbox.Size = new System.Drawing.Size(164, 22);
            this.stextbox.TabIndex = 6;
            this.stextbox.Visible = false;
            this.stextbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(stextbox, "Nhập mã sinh viên.");
            // 
            // Search_button
            // 
            this.Search_button.Enabled = false;
            this.Search_button.Location = new System.Drawing.Point(582, 12);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(125, 37);
            this.Search_button.TabIndex = 7;
            this.Search_button.Text = "Tìm kiếm";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // AdvancedSearch_button
            // 
            this.AdvancedSearch_button.Enabled = false;
            this.AdvancedSearch_button.Location = new System.Drawing.Point(241, 12);
            this.AdvancedSearch_button.Name = "AdvancedSearch_button";
            this.AdvancedSearch_button.Size = new System.Drawing.Size(155, 37);
            this.AdvancedSearch_button.TabIndex = 8;
            this.AdvancedSearch_button.Text = "Tìm kiếm chi tiết";
            this.AdvancedSearch_button.UseVisualStyleBackColor = true;
            this.AdvancedSearch_button.Click += new System.EventHandler(this.AdvancedSearch_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 347);
            this.Controls.Add(this.AdvancedSearch_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.stextbox);
            this.Controls.Add(this.cbb1);
            this.Controls.Add(this.Del_button);
            this.Controls.Add(this.Change_button);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.dgv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.ComboBox cbb1;
        private System.Windows.Forms.Button Change_button;
        private System.Windows.Forms.Button Del_button;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.TextBox stextbox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button AdvancedSearch_button;
    }
}

