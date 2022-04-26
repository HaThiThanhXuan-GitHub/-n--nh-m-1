using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{

    public partial class frmthongtindg : Form
    {
        string Tendangnhap = "", Matkhau = "", Tendocgia = "", Gt = "", Email = "", Quyen = "", Madg = "";
        Themsuaxoa t = new Themsuaxoa();

        
        public frmthongtindg()
        {
            InitializeComponent();
        }
        public frmthongtindg(string Tendangnhap, string Tendocgia, string Matkhau, string Gt, string Email, string Quyen, string Madg)
        {
            InitializeComponent();
            this.Tendangnhap = Tendangnhap;
            this.Tendocgia = Tendocgia;
            this.Matkhau = Matkhau;
            this.Quyen = Quyen;
            this.Gt = Gt;
            this.Email = Email;
            this.Madg = Madg;
        }
        

        private void frmthongtindg_Load(object sender, EventArgs e)
        {
            loaduser();
            load();
        }
        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void load()
        {
            txtmadocgia.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttendocgia.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            txtlop.Text = luoi.CurrentRow.Cells[4].Value.ToString();

        }
        private void loaduser()
        {
            DataTable dt = t.docdulieu("SELECT * FROM docgia WHERE madocgia='" + Madg + "'");
            if (dt != null)
            {
                luoi.DataSource = dt;
            }

        }

        private void sua_Click(object sender, EventArgs e)
        {
            txtmadocgia.Enabled = false;
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");

            if (txttendocgia.Text == "")
                {
                    txttendocgia.Focus();

                }
                else if (txtlop.Text == "")
                {
                    MessageBox.Show("Chưa nhập địa chỉ");
                    txtlop.Focus();


                }
                else if (t.thucthidulieu("update  docgia set hoten=N'" + txttendocgia.Text + "', ngaysinh=N'" + ngayhh + "', gioitinh=N'" + comgioitinh.Text + "', lop='" + txtlop.Text + "'where madocgia=N'" + txtmadocgia.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");

                    loaduser();




                }
            else MessageBox.Show("Không thể cập nhật dữ liệu");


            
        
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            DataTable dt = t.docdulieu("SELECT * FROM login WHERE mod='" + Madg + "'");
            if (dt != null)
            {
                this.Hide();
                Form f = new Formchinh(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString());
                f.Show();
            }
        }
    }
}
