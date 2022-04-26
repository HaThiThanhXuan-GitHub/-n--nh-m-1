using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
        Đỗ Hữu Quân 

 */


namespace WindowsFormsApplication1
{
    public partial class Formdocgia : Form
    {
        string Tendangnhap = "", Matkhau = "", Tendocgia = "", Gt = "", Email = "", Quyen = "", Madg = "";
        public Formdocgia()
        {
            InitializeComponent();
        }
        public Formdocgia(string Tendangnhap, string Tendocgia, string Matkhau, string Gt, string Email, string Quyen, string Madg)
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
        Themsuaxoa t = new Themsuaxoa();




        private void Formdocgia_Load(object sender, EventArgs e)
        {
                txtmadocgia.Enabled = true;
                luoi.Enabled = true;
                loaddata();
            
            
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
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from docgia");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                luoi.DataSource = dt;
            }


            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmadocgia.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttendocgia.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            ngaysinh.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            txtlop.Text = luoi.CurrentRow.Cells[4].Value.ToString();

            
        }

        private void them_Click(object sender, EventArgs e)
        {
            txtmadocgia.Text = "";
            txtmadocgia.Enabled = true;
            txttendocgia.Text = "";
            ngaysinh.Text = "1/1/2001";
            comgioitinh.Text = "Nam";
            txtlop.Text = "";
            //luu.Enabled = true;
            //sua.Enabled = false;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;
            luu.Enabled = true;

            
        }

        private void luu_Click(object sender, EventArgs e)
        {

            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");

            if (txttendocgia.Text == "")
            {
                MessageBox.Show("Chưa nhập tên độc giả");
                txttendocgia.Focus();


            }
            else if (txtlop.Text == "")
            {
                MessageBox.Show("Chưa nhập lớp");
                txtlop.Focus();


            }


            else if (t.thucthidulieu("INSERT INTO docgia VALUES (N'" + txtmadocgia.Text + "',N'" + txttendocgia.Text + "',N'" + ngayhh + "',N'" + comgioitinh.Text + "',N'" + txtlop.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();

            }
            else 
            {
                MessageBox.Show("Lỗi trùng khhóa");
                txtmadocgia.Focus();
            }
        }

        private void sua_Click(object sender, EventArgs e)
        {
            string ngayhh = ngaysinh.Value.ToString("yyyy/MM/dd");

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

                        loaddata();
                    
                    


                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            if (xoa.Text == "hủy")
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa độc giả có mã số " + txtmadocgia.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {
                        if (t.thucthidulieu("delete from docgia where madocgia='" + txtmadocgia.Text + "'") == true)
                            MessageBox.Show("Xóa thành Công", "Thông báo");
                        else MessageBox.Show("Lỗi không thể xóa dữ liệu", "Thông báo");

                        loaddata();


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Không thể xóa", "Thông báo");
                        throw;
                    }

                }
                else loaddata();





            }
        }

        private void txtmadocgia_TextChanged(object sender, EventArgs e)
        {

        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
