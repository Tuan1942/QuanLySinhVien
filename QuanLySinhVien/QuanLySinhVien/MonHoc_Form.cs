using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class MonHoc_Form : Form
    {
        public void Adding_Value()
        {
            Add_button.Visible = true;
            Save_button.Visible = false;
        }
        public void Changing_Value()
        {
            Add_button.Visible = false;
            Save_button.Visible = true;
        }

        void Sql_Add_Value()
        {
            try
            {
                SqlConnection connection = new SqlConnection(Form1.str);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "Insert into " + Form1.Table_name + 
                    " values (N'" + mMH.Text + "', N'" + tenMH.Text + "', N'" + thongtin.Text + "')";
                Console.WriteLine(command.CommandText);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Lưu thành công.");
                mMH.Text = "";
                tenMH.Text = "";
                thongtin.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu không thành công.");
            }
        }

        public void Get_value(string[] value)
        {
            mMH.Text = value[1];
            tenMH.Text = value[2];
            thongtin.Text = value[3];
        }

        public int Get_ID(int ID)
        {
            return ID;
        }

        static int ID;

        void Sql_Change_Value(string Table_name)
        {
            ID = Get_ID(Form1.ID);
            try
            {
                Form1 f1 = new Form1();
                SqlConnection connection = new SqlConnection(Form1.str);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "Update " + Table_name + " set " +
                    "mMH = N'" + mMH.Text + "', " +
                    "tenMH = N'" + tenMH.Text + "', " +
                    "thongtin = N'" + thongtin.Text + "' " +
                    "where ID = '" + ID + "'";
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Lưu không thành công.");
            }
        }
        public MonHoc_Form()
        {
            InitializeComponent();
        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            string message = "Lưu thay đổi?";
            string title = "Xác nhận";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Sql_Change_Value(Form1.Table_name);
            }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Sql_Add_Value();
        }
    }
}
