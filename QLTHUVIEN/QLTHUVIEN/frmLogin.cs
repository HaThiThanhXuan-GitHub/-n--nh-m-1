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
using System.Text.RegularExpressions;


/*
        Hoàng Trọng Tỉnh
 
 */
namespace WindowsFormsApplication1
{
    public partial class frmLogin : Form
    {
        Themsuaxoa t = new Themsuaxoa();
        public int dem;
        private SqlConnection con;
        public void ketnoi()
        {
            // b1: khia bao chuoi kết nối
            string ketnoi;
            ketnoi = @"Data Source=DESKTOP-497ICV3\MSSQLSV;Initial Catalog=QLTHUVIEN;Integrated Security=True";
            //b2: khia báo và khởi tạo kết nối
            con = new SqlConnection(ketnoi);// có tham số kết nối
            con.ConnectionString = ketnoi;
            //b3: mở kết nối
            con.Open();
        }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            string user = txtuser.Text;
            string pass = txtpass.Text;
            if (txtuser.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Username vào!", "Đăng nhập");
                txtuser.Focus();
            }
            else
                if (txtpass.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Password vào!", "Đăng nhập");
                txtpass.Focus();
            }
            else
            {
                try
                {
                    //ketnoi();
                    //string sql = "select * from login where username = '" + user + "' and pass ='" + pass + "' ";
                    //sqlcommand sqlcom = new sqlcommand(sql, con);
                    //sqldatareader sqldr = sqlcom.executereader();

                    DataTable dt = t.docdulieu("SELECT * FROM login WHERE username = '" + user + "' and pass ='" + pass + "' ");
                    if (dt.Rows.Count > 0)
                    {
                        lbThongbao.Visible = false;
                        MessageBox.Show("Đăng nhập thành công!", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        Formchinh f = new Formchinh(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString());
                        f.ShowDialog();
                        //frmLogin frm = new frmLogin();
                        //frm.Close();

                    }
                    else
                    {
                       // MessageBox.Show("Tài khoản chưa có, hoặc nhập sai!", "Đăng nhập");
                        lbThongbao.Visible = true;
                        txtuser.Text = "";
                        txtpass.Text = "";
                        txtuser.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                this.Show();
            }
            else
                this.Close();
        }

        private void btnhaplai_Click(object sender, EventArgs e)
        {
            txtuser.Text = "";
            txtpass.Text = "";
        }

        private void cbhien_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhien.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
                txtpass.UseSystemPasswordChar = true;
        }

        private void btdangky_Click(object sender, EventArgs e)
        {
            btdangky.Enabled = false;
            panel2.Visible = true;

            DataTable dt = t.docdulieu("select * from login");

            dem = dt.Rows.Count;
            dem = dem + 1;
            txtma.Text = dem.ToString();
        }

        private void bthuy_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            btdangky.Enabled = true;
            
        }

        private void btlai_Click(object sender, EventArgs e)
        {
            txttk.Text = "";
            txtmk.Text = "";
            txtlmk.Text = "";
        }

        private void cbhienan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhienan.Checked == true)
            {
                txtmk.UseSystemPasswordChar = false;
                txtlmk.UseSystemPasswordChar = false;
            }
            else
            {
                txtmk.UseSystemPasswordChar = true;
                txtlmk.UseSystemPasswordChar = true;
            }    
                
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
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

        private void login_Load(object sender, EventArgs e)
        {

            ketnoi();
            string sql;
            sql = "select * from login";
            SqlDataAdapter sqlda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sqlda.Fill(dt);
        }

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        private void btok_Click(object sender, EventArgs e)
        {
            string sql;
            string gt;
            string state= "false", user=txtma.Text;
            if (rdnam.Checked == true)
            {
                gt = "nam";
            }
            else
            {
                gt = "nữ";
            }
            if (txttk.Text == "")
            {
                MessageBox.Show("Chưa nhập tên tài khoản");
                txttk.Focus();

            }
            else if (txtmk.Text == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu");
                txtmk.Focus();


            }
            else if (txtlmk.Text == "")
            {
                MessageBox.Show("Chưa nhập lại mật khẩu");
                txtlmk.Focus();
            }
            else if (txtname.Text == "")
            {
                MessageBox.Show("Chưa nhập Full name");
                txtname.Focus();
            }
            else if (!CheckEmail(txtemail.Text)){
                MessageBox.Show("Chưa nhập đúng định dạng Email");
                txtemail.Focus();
            }
            
            else
            {
                try
                {
                    ketnoi();
                    sql = "insert into login values(N'" + txttk.Text + "',N'" + txtmk.Text + "',N'" + txtname.Text + "',N'" + gt + "',N'" + txtemail.Text + "',N'" + state + "',N'" + user + "')";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();

                    MessageBox.Show("Đã thêm sinh viên thành công ", "Thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    login_Load(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show("Đã thêm sinh viên thất bại ", "Đã có mã tồn tại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }




        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btdoimk_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new frmdoimk();
            f.Show();
        }
    }
    
}
