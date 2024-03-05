
namespace QuanLySinhVien
{
    partial class MonHoc_Form
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
            this.Save_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Add_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mMH = new System.Windows.Forms.TextBox();
            this.thongtin = new System.Windows.Forms.TextBox();
            this.tenMH = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(176, 113);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(122, 37);
            this.Save_button.TabIndex = 6;
            this.Save_button.Text = "Lưu thay đổi";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Visible = false;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Huỷ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(366, 113);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(95, 37);
            this.Add_button.TabIndex = 5;
            this.Add_button.Text = "Thêm";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Visible = false;
            this.Add_button.Click += new System.EventHandler(this.Add_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã môn học";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Thông tin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Tên môn học";
            // 
            // mMH
            // 
            this.mMH.Location = new System.Drawing.Point(157, 9);
            this.mMH.Name = "mMH";
            this.mMH.Size = new System.Drawing.Size(304, 22);
            this.mMH.TabIndex = 2;
            // 
            // thongtin
            // 
            this.thongtin.Location = new System.Drawing.Point(157, 65);
            this.thongtin.Name = "thongtin";
            this.thongtin.Size = new System.Drawing.Size(304, 22);
            this.thongtin.TabIndex = 4;
            // 
            // tenMH
            // 
            this.tenMH.Location = new System.Drawing.Point(157, 37);
            this.tenMH.Name = "tenMH";
            this.tenMH.Size = new System.Drawing.Size(304, 22);
            this.tenMH.TabIndex = 3;
            // 
            // MonHoc_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 161);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mMH);
            this.Controls.Add(this.thongtin);
            this.Controls.Add(this.tenMH);
            this.Name = "MonHoc_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MonHoc_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mMH;
        private System.Windows.Forms.TextBox thongtin;
        private System.Windows.Forms.TextBox tenMH;
    }
}