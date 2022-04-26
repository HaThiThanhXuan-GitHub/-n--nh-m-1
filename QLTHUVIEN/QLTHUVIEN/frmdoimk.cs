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

/*
    Hoàng Trọng Tỉnh
 */

namespace WindowsFormsApplication1
{
    public partial class frmdoimk : Form
    {

        Themsuaxoa t = new Themsuaxoa();
        public frmdoimk()
        {
            InitializeComponent();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã hủy","Thông báo");
            this.Hide();
            Form f = new frmLogin();
            f.Show();
        }

        private void btlai_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            txtmk.Text = "";
            txtlmk.Text = "";
            txtpasscu.Text = "";
        }

        private void btok_Click(object sender, EventArgs e)
        {
            string user = txttk.Text;
            string pass = txtpasscu.Text;
            string newpass = txtmk.Text;

            if (txttk.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tài khoản");
                txttk.Focus();

            }
            else if (txtpasscu.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                txtmk.Focus();
            }
            else if (txtmk.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới");
                txtmk.Focus();
            }
            else if (txtlmk.Text == "")
            {
                MessageBox.Show("Chưa nhập lại mật khẩu");
                txtlmk.Focus();
            }

            
            else if (t.thucthidulieu("UPDATE  login set pass=N'" + newpass + "' WHERE username = '" + user + "' AND pass ='"+pass+"' ") == true)
            {

                MessageBox.Show("Cập nhật dữ liệu thành công");
            }
            else MessageBox.Show("Không thể cập nhật dữ liệu");
        }

        private void cbhienan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienan.Checked == true)
            {
                txtmk.UseSystemPasswordChar = false;
                txtlmk.UseSystemPasswordChar = false;
                txtpasscu.UseSystemPasswordChar = false;
            }
            else
            {
                txtmk.UseSystemPasswordChar = true;
                txtlmk.UseSystemPasswordChar = true;
                txtpasscu.UseSystemPasswordChar = true;
            }
        }

        private void txtlmk_TextChanged(object sender, EventArgs e)
        {
            if (txtlmk.Text != txtmk.Text)
            {
                label7.Visible = true;
            }
            else
                label7.Visible = false;
        }

        private void frmdoimk_Load(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmLogin();
            f.Show();
        }
    }
}
