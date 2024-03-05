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
    public partial class TimKiemForm : Form
    {
        public TimKiemForm()
        {
            InitializeComponent();
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            try
            {
                SqlConnection connection = new SqlConnection(Form1.str);
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "select SinhVien.mSV, tenSV, KQHocTap.mMH, tenMH, diem " +
                    "from KQHocTap " +
                    "join SinhVien on SinhVien.mSV = KQHocTap.mSV " +
                    "join MonHoc on MonHoc.mMH = KQHocTap.mMH " +
                    "where SinhVien.mSV = '" + Form1.SearchMSV + "'";
                Console.WriteLine(command.CommandText);
                adapter.SelectCommand = command;
                table = new DataTable();
                adapter.Fill(table);
                dgv.DataSource = table;
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.ClearSelection();
            }
            catch (Exception)
            {
                MessageBox.Show("Không tìm thấy.");
            }
        }
    }
}
