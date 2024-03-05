
namespace QuanLySinhVien
{
    partial class KQForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mMH = new System.Windows.Forms.TextBox();
            this.mSV = new System.Windows.Forms.TextBox();
            this.diem = new System.Windows.Forms.TextBox();
            this.mGV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(176, 143);
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
            this.button1.Location = new System.Drawing.Point(12, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Huỷ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_button
            // 
            this.Add_button.Location = new System.Drawing.Point(366, 143);
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
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Mã môn học";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Mã sinh viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "Điểm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã giảng viên";
            // 
            // mMH
            // 
            this.mMH.Location = new System.Drawing.Point(157, 40);
            this.mMH.Name = "mMH";
            this.mMH.Size = new System.Drawing.Size(304, 22);
            this.mMH.TabIndex = 2;
            // 
            // mSV
            // 
            this.mSV.Location = new System.Drawing.Point(157, 12);
            this.mSV.Name = "mSV";
            this.mSV.Size = new System.Drawing.Size(304, 22);
            this.mSV.TabIndex = 1;
            // 
            // diem
            // 
            this.diem.Location = new System.Drawing.Point(157, 96);
            this.diem.Name = "diem";
            this.diem.Size = new System.Drawing.Size(304, 22);
            this.diem.TabIndex = 4;
            // 
            // mGV
            // 
            this.mGV.Location = new System.Drawing.Point(157, 68);
            this.mGV.Name = "mGV";
            this.mGV.Size = new System.Drawing.Size(304, 22);
            this.mGV.TabIndex = 3;
            // 
            // KQForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 190);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mMH);
            this.Controls.Add(this.mSV);
            this.Controls.Add(this.diem);
            this.Controls.Add(this.mGV);
            this.Name = "KQForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "KQForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Add_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mMH;
        private System.Windows.Forms.TextBox mSV;
        private System.Windows.Forms.TextBox diem;
        private System.Windows.Forms.TextBox mGV;
    }
}