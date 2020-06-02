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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlCommand sqlcmd = new SqlCommand();
        public static String connstr;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = @"Data Source=CANHPROXX\SERVER3;Initial Catalog=CHUNGKHOAN;Integrated Security=True";
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int kn = KetNoi();
            if (KetNoi() == 0)
            {
                MessageBox.Show("Kết nối dữ liệu thất bại");
                return;
            }
            // TODO: This line of code loads data into the 'cHUNGKHOANDataSet.LENHDAT' table. You can move, or remove it, as needed.
            this.lENHDATTableAdapter.Fill(this.cHUNGKHOANDataSet.LENHDAT);
            txtLoailenh.Text = "LO";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDatlenh_Click(object sender, EventArgs e)
        {
            Console.WriteLine("1111111 : " + txtMaCP.Text.Trim().Length);
            if (txtMaCP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống mã CP", "Thông báo");
                return;
            }
            if (txtSl.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống số lượng", "Thông báo");
                return;
            }
            if (txtGia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống giá", "Thông báo");
                return;
            }
           
            try
            {

                if (Program.conn.State == ConnectionState.Closed)
                    Program.conn.Open();
                DateTime datetime = datePick.Value;
                String datetimeFormmat = datetime + "";
                String[] date = datetimeFormmat.Split(' ');
                String str = date[0];

                String[] tempsplit = str.Split('/');
                String joinstring = "-";
                String newdate = tempsplit[2] + joinstring + tempsplit[1] + joinstring + tempsplit[0];

                String strLenh = "SP_KHOPLENH_LO";
                Program.sqlcmd = Program.conn.CreateCommand();
                Program.sqlcmd.CommandType = CommandType.StoredProcedure;
                Program.sqlcmd.CommandText = strLenh;
                Program.sqlcmd.Parameters.Add("@macp", SqlDbType.NVarChar).Value = txtMaCP.Text;
                Program.sqlcmd.Parameters.Add("@Ngay", SqlDbType.NVarChar).Value = newdate;
                if (rbMua.Checked)
                {
                    Program.sqlcmd.Parameters.Add("@LoaiGD", SqlDbType.Char).Value = 'M';
                }
                if (rbBan.Checked)
                {
                    Program.sqlcmd.Parameters.Add("@LoaiGD", SqlDbType.Char).Value = 'B';
                }
                Program.sqlcmd.Parameters.Add("@soluongMB", SqlDbType.Int).Value = txtSl.Text;
                Program.sqlcmd.Parameters.Add("@giadatMB", SqlDbType.Float).Value = txtGia.Text;
                Program.sqlcmd.ExecuteNonQuery();
                Program.conn.Close();
                MessageBox.Show("Đặt lệnh mua thành công", "THÔNG BÁO", MessageBoxButtons.OK);
                this.lENHDATTableAdapter.Fill(this.cHUNGKHOANDataSet.LENHDAT);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lệnh mua.\n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }

            txtMaCP.Text = "";
            txtSl.Text = "";
            txtGia.Text = "";
        }

        private void Loailenh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtSl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
        }
    }
}
