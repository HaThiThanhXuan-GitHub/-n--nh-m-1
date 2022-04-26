using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
    Lê Viết Tú
 */


namespace WindowsFormsApplication1
{
    public partial class theloaisach : Form
    {
        
        Themsuaxoa t = new Themsuaxoa();
        string Tendangnhap = "", Matkhau = "", Tendocgia = "", Gt = "", Email = "", Quyen = "", Madg = "";

        public theloaisach()
        {
            InitializeComponent();
        }
        public theloaisach(string Tendangnhap, string Tendocgia, string Matkhau, string Gt, string Email, string Quyen, string Madg)
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
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from theloai");
           
            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã thể loại";
            luoi.Columns[1].HeaderText = "Tên thể loại";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells); 
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void nhaxuatban_Load(object sender, EventArgs e)
        {
            loaddata();
            if (Quyen == "False")
            {
                them.Visible = false;
                sua.Visible = false;
                xoa.Visible = false;
                luu.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmatheloai.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttentheloai.Text = luoi.CurrentRow.Cells[1].Value.ToString();

        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmatheloai.Text = "";
            txttentheloai.Text = "";
            luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;

        }

        private void sua_Click(object sender, EventArgs e)
        {
            if (sua.Text == "hủy")
            {
                luu.Enabled = false;
                sua.Enabled = true;
                xoa.Enabled = true;
                xoa.Text = "Xóa";
                sua.Text = "Sửa";
                them.Enabled = true;
               loaddata();
               luoi.Enabled = true;


            }
            else
            {
                ///them.Enabled = false;
               /// sua.Text = "Cập nhật";
                ///xoa.Text = "hủy";

                if (txtmatheloai.Text == "")
                {
                    MessageBox.Show("Chưa nhập mã thể loại");
                    txtmatheloai.Focus();

                }
                else if (txttentheloai.Text == "")
                {
                    MessageBox.Show("Chưa nhập tên thể loại");
                    txttentheloai.Focus();


                }
                else if (t.thucthidulieu("update  theloai set tentheloai=N'" + txttentheloai.Text + "'where matheloai=N'" + txtmatheloai.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");
            
            
            }

        }

        private void luu_Click(object sender, EventArgs e)
        {
            if (txtmatheloai.Text=="")
            {
                MessageBox.Show("Chưa nhập mã thể loại");
                txtmatheloai.Focus();

            }else if (txttentheloai.Text=="")
            {
                MessageBox.Show("Chưa nhập tên thể loại");
                txttentheloai.Focus();


            }
            else if (t.thucthidulieu("INSERT INTO theloai VALUES (N'" + txtmatheloai.Text + "', '" + txttentheloai.Text+ "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        


        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (xoa.Text == "hủy") {

                luu.Enabled = false;
                sua.Enabled = true;
                xoa.Enabled = true;
                xoa.Text = "Xóa";
                sua.Text = "Sửa";
                them.Enabled = true;
                loaddata();
                luoi.Enabled = true;




            }
            else {
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa " + txtmatheloai.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes) {
                    try
                    {

                        t.thucthidulieu("delete from theloai where matheloai='" + txtmatheloai.Text+"'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else  loaddata(); 
            
            
            
            
            
            }
            
            
            
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

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

