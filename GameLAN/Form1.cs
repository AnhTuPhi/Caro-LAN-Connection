using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLAN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Cây hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                this.Close();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string con_str = @"Data Source=ADMIN-PC;
                                Initial Catalog=game;
                                Integrated Security=SSPI;";
                SqlConnection conn = new SqlConnection(con_str);
                conn.Open();
                string taikhoan = txt_User.Text;
                string matkhau = txt_Password.Text;

                string query = $@" 
                            Select count(*)
                            from Users
                             Where userAccount = '{taikhoan}'
                            And password = '{matkhau}'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int soluong = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                conn.Close();
                if (soluong == 0)
                {
                    MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công");

                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
            }
            catch
            {
                MessageBox.Show("Đăng Nhập không thành công");
            }
        }
    }
}
