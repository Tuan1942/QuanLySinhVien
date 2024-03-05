using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        public static string str = @"Data Source=LAPTOP-JFV3PC7D\MSSQLSERVER01;Initial Catalog=SinhVien;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        public static string Table_name;
        public static DataTable table = new DataTable();
        public static string SearchMSV;
        public void LoadData(string Table_name)
        {
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "select * from " + Table_name;
                    adapter.SelectCommand = command;
                    table = new DataTable();
                    adapter.Fill(table);
                    dgv.DataSource = table;
                    dgv.Columns[0].ReadOnly = true;
                    dgv.Columns[0].Visible = false;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.ClearSelection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tải dữ liệu không thành công");
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu,");
            }
        }

        public void LoadSV(string msv)
        {
            try
            {
                connection = new SqlConnection(str);
                connection.Open();
                try
                {
                    command = connection.CreateCommand();
                    command.CommandText = "select * from " + Table_name + " where msv = '" + msv + "'";
                    adapter.SelectCommand = command;
                    table = new DataTable();
                    adapter.Fill(table);
                    dgv.DataSource = table;
                    dgv.Columns[0].ReadOnly = true;
                    dgv.Columns[0].Visible = false;
                    dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgv.ClearSelection();
                }
                catch (Exception)
                {
                    MessageBox.Show("Tải dữ liệu không thành công");
                }
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể kết nối tới cơ sở dữ liệu,");
            }
        }

        void Delete_record()
        {
            try
            {
                {
                    connection = new SqlConnection(str);
                    connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "delete from " + Table_name + " where ID = '" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value + "'";
                    command.ExecuteNonQuery();
                    dgv.Rows.RemoveAt(dgv.CurrentCell.RowIndex);
                    connection.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xoá không thành công.");
                if (Table_name == "SinhVien")
                {
                    DialogResult result = MessageBox.Show("Thao tác tiếp theo sẽ xoá toàn bộ các bản ghi liên quan của sinh viên này. \nBạn có muốn tiếp tục không?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        connection = new SqlConnection(str);
                        connection.Open();
                        command = connection.CreateCommand();
                        command.CommandText = "delete from " + "KQHocTap" + " where mSV = '" + dgv.Rows[dgv.CurrentCell.RowIndex].Cells[1].Value + "'";
                        command.ExecuteNonQuery();
                        connection.Close();
                        Delete_record();
                        MessageBox.Show("Đã xoá toàn bộ các bản ghi liên quan.");
                    }
                    else if (result == DialogResult.No)
                    {
                        // Thực hiện hành động khi người dùng chọn No
                    }
                }
                connection.Close();
            }
        }

        String[] Get_value()
        {
            string[] tab_val = new string[dgv.Columns.Count];
            for (int i = 1; i < dgv.Columns.Count; i++)
            {
                tab_val[i] = dgv.Rows[dgv.CurrentCell.RowIndex].Cells[i].Value.ToString();
            }
            return tab_val;
        }

        int Get_ID()
        {
            return (int)dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData(Table_name);
        }

        private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {
            stextbox.Text = "";
            Table_name = cbb1.Text;
            LoadData(Table_name);
            if (cbb1.SelectedIndex == 0 || cbb1.SelectedIndex == 3)
            {
                stextbox.Visible = true;
            }
            else stextbox.Visible = false;
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 1)
            {
                Del_button.Enabled = true;
                Change_button.Enabled = true;
            }
            else
            {
                Del_button.Enabled = false;
                Change_button.Enabled = false;
            }
        }

        private void Del_button_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xoá bản ghi này?", "Xoá", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Delete_record();
            }
        }

        public static int ID;
        private void Change_button_Click(object sender, EventArgs e)
        {
            ID = Get_ID();
            switch (cbb1.SelectedIndex)
            {
                case 0:
                    SinhVien_Form SinhVien_Form = new SinhVien_Form();
                    SinhVien_Form.Get_ID(ID);
                    SinhVien_Form.Show();
                    SinhVien_Form.Changing_Value();
                    SinhVien_Form.Get_value(Get_value());
                    break;
                case 1:
                    GiangVien_Form GiangVien_Form = new GiangVien_Form();
                    GiangVien_Form.Get_ID(ID);
                    GiangVien_Form.Show();
                    GiangVien_Form.Changing_Value();
                    GiangVien_Form.Get_value(Get_value());
                    break;
                case 2:
                    MonHoc_Form MonHoc_Form = new MonHoc_Form();
                    MonHoc_Form.Get_ID(ID);
                    MonHoc_Form.Show();
                    MonHoc_Form.Changing_Value();
                    MonHoc_Form.Get_value(Get_value());
                    break;
                case 3:
                    KQForm KQForm = new KQForm();
                    KQForm.Get_ID(ID);
                    KQForm.Show();
                    KQForm.Changing_Value();
                    KQForm.Get_value(Get_value());
                    break;
            }
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            switch (cbb1.SelectedIndex)
            {
                case 0:
                    SinhVien_Form SinhVien_Form = new SinhVien_Form();
                    SinhVien_Form.Show();
                    SinhVien_Form.Adding_Value();
                    break;
                case 1:
                    GiangVien_Form GiangVien_Form = new GiangVien_Form();
                    GiangVien_Form.Show();
                    GiangVien_Form.Adding_Value();
                    break;
                case 2:
                    MonHoc_Form MonHoc_Form = new MonHoc_Form();
                    MonHoc_Form.Show();
                    MonHoc_Form.Adding_Value();
                    break;
                case 3:
                    KQForm KQForm = new KQForm();
                    KQForm.Show();
                    KQForm.Adding_Value();
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (stextbox.Text != "")
            {
                Search_button.Enabled = true;
                AdvancedSearch_button.Enabled = true;
            }
            else
            {
                Search_button.Enabled = false;
                AdvancedSearch_button.Enabled = false;
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            LoadSV(stextbox.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AdvancedSearch_button_Click(object sender, EventArgs e)
        {
            SearchMSV = stextbox.Text;
            TimKiemForm timKiemForm = new TimKiemForm();
            timKiemForm.Show();
        }
    }
}
