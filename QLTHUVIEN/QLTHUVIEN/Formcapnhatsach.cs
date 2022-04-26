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
    public partial class Formcapnhatsach : Form
    {
        Themsuaxoa t = new Themsuaxoa();
        string Tendangnhap = "", Matkhau = "", Tendocgia = "", Gt = "", Email = "", Quyen = "", Madg = "";

        public Formcapnhatsach()
        {
            InitializeComponent();
        }
        public Formcapnhatsach(string Tendangnhap, string Tendocgia, string Matkhau, string Gt, string Email, string Quyen, string Madg)
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



        private void Formcapnhatsach_Load(object sender, EventArgs e)
        {
            loaddata();
            if (Quyen == "False")
            {
                grcapnhat.Visible = false;
            }
            else
            {
                grcapnhat.Visible = true;
            }
        }

        private void loaddata()
        {
            loadcombo();
            //DataTable dc = t.docdulieu("SELECT masach, tensach,namxb, ghichu FROM sach");

            DataTable dc = t.docdulieu("SELECT sach.masach, sach.tensach, sach.namxb, sach.soluong, nhaxb.tennxb, theloai.tentheloai, tacgia.tentacgia, sach.ghichu FROM sach, theloai, tacgia, nhaxb WHERE sach.manxb=nhaxb.manxb AND sach.matheloai=theloai.matheloai AND sach.matacgia=tacgia.matacgia ");
            if (dc != null)
            {
                luoi.DataSource = dc;

            }
            
            //luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            xoa.Enabled = true;
            sua.Text = "Sửa";
            them.Enabled = true;
            sua.Enabled = true;
            xoa.Enabled = true;
            luu.Enabled = false;
            luoi.Enabled = true;

        }
        private void loadcombo() {
            DataTable dt = t.docdulieu("select * from nhaxb");
            DataTable dt1 = t.docdulieu("select * from theloai");
            DataTable dt2 = t.docdulieu("select * from tacgia");

           
                comnhaxb.DataSource = dt;
                comnhaxb.DisplayMember = "manxb";
                comnhaxb.ValueMember = "manxb";
                comtheloai.DataSource = dt1;
                comtheloai.DisplayMember = "matheloai";
                comtheloai.ValueMember = "matheloai";
                commatacgia.DataSource = dt2;
                commatacgia.DisplayMember = "matacgia";
                commatacgia.ValueMember = "matacgia";
        
        }

        private void timkiemsach()
        {
            DataTable dt = t.docdulieu("SELECT * from sach where masach like '%" + txttimkiem.Text + "%'");
            DataTable dt2 = t.docdulieu("SELECT * from sach where tensach like '%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                luoi.DataSource = dt;
            }
            else if (ratensach.Checked == true)
                luoi.DataSource = dt2;
            else
            {
                luoi.DataSource = dt2;
            }
        }
        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            timkiemsach();

        }

        

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luoi_SelectionChanged(object sender, EventArgs e)
        {
            txtmasach.Text = luoi.CurrentRow.Cells[0].Value.ToString();
            txttensach.Text = luoi.CurrentRow.Cells[1].Value.ToString();
            txtnamxb.Text = luoi.CurrentRow.Cells[2].Value.ToString();
            txtsoluong.Text = luoi.CurrentRow.Cells[3].Value.ToString();
            txtghichu.Text = luoi.CurrentRow.Cells[7].Value.ToString();
            loadcombb();
            //string tnxb = luoi.CurrentRow.Cells[3].Value.ToString();
            //if (tnxb == dgvnxb.CurrentRow.Cells[1].Value.ToString())
            //{
            //    comnhaxb.Text = dgvnxb.CurrentRow.Cells[0].Value.ToString();
            //}
            
            //comtheloai.Text = luoi.CurrentRow.Cells[4].Value.ToString();
            //commatacgia.Text = luoi.CurrentRow.Cells[5].Value.ToString();
        }

        private void loadcombb()
        {
            DataTable dt = t.docdulieu("select * from nhaxb");
            if (dt != null)
            {
                dgvnxb.DataSource = dt;
            }
            DataTable dt1 = t.docdulieu("select * from theloai");
            if (dt1 != null)
            {
                dgvtl.DataSource = dt1;
            }
            DataTable dt2 = t.docdulieu("select * from tacgia");
            if (dt2 != null)
            {
                dgvtg.DataSource = dt2;
            }

        }

            private void them_Click(object sender, EventArgs e)
        {
            txtmasach.Enabled=true;
            txttensach.Text = "";
            txtmasach.Text = "";
            txtnamxb.Text = "";
            commatacgia.Text = "";
            comnhaxb.Text = "";
            comnhaxb.Text = "";
            txtghichu.Text = "";
            luu.Enabled = true;
            xoa.Enabled = false;
            sua.Text = "hủy";
            them.Enabled = false;
            luoi.Enabled = false;
            loadcombo();

        }

        private void luu_Click(object sender, EventArgs e)
        {
            string namxb = txtnamxb.Value.ToString("yyyy/MM/dd");//dịnh dạng ngày để insert vào sql

            if (txtmasach.Text == "")
            {
                MessageBox.Show("Chưa nhập mã sách");
                txtmasach.Focus();

            }
            else if (txttensach.Text == "")
            {
                MessageBox.Show("Chưa nhập tên sách");
                txttensach.Focus();


            }
            //else if (t.thucthidulieu("INSERT INTO sach VALUES (N'" + txtmasach.Text + "',N '" + txttensach.Text + "',N'" + namxb + "',N'" + commatacgia.SelectedIndex.ToString() + "',N'" + comtheloai.SelectedIndex.ToString() + "',N'" + commatacgia.SelectedIndex.ToString() +"',N'"+txtghichu.Text+"')") == true)

            else if (t.thucthidulieu("INSERT INTO sach VALUES (N'" + txtmasach.Text + "',N'" + txttensach.Text + "',N'" + namxb + "',N'" + comnhaxb.SelectedValue.ToString() + "',N'" + comtheloai.SelectedValue.ToString() + "',N'" + commatacgia.SelectedValue.ToString() + "','"+txtsoluong.Text+"',N'" + txtghichu.Text + "')") == true)
            {

                MessageBox.Show("Thêm thành công");
                loaddata();


            }
            else MessageBox.Show("Lỗi");
        }

        private void txtnamxb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnamxb_Enter(object sender, EventArgs e)
        {
            int n;
            try
            {
                n = int.Parse(txtnamxb.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");

            }
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            DataTable dt = t.docdulieu("SELECT * FROM login WHERE mod='" + Madg + "'");
            if (dt != null)
            {
                this.Hide();
                Formchinh f = new Formchinh(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString());
                f.ShowDialog();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void grcapnhat_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtghichu_TextChanged(object sender, EventArgs e)
        {

        }

        private void sua_Click(object sender, EventArgs e)
        {
            txtmasach.Enabled = false;
            string namxb = txtnamxb.Value.ToString("yyyy/MM/dd");//dịnh dạng ngày để insert vào sql

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
                txtmasach.Enabled = false;


                if (txttensach.Text == "")
                {
                    txttensach.Focus();
                    MessageBox.Show("Chưa nhập tên sách!");
                }
                else if (txtnamxb.Text == "")
                {
                    MessageBox.Show("Chưa nhập năm xuất bản!");
                    txtnamxb.Focus();

                    // else if (t.thucthidulieu("update  SACH set tensach=N'" + txttensach.Text + "', namxb=N'" + txtnamxb.Text + "', manxb='" + comnhaxb.Text + "', matheloai='" + comtheloai.SelectedValue.ToString() + "', matacgia='" + commatacgia.SelectedValue.ToString() + "'where masach=N'" + txtmasach.Text + "'") == true)
                }
                else if (t.thucthidulieu("UPDATE  sach SET tensach=N'" + txttensach.Text + "', namxb=N'" + namxb + "', manxb='" + comnhaxb.SelectedValue.ToString() + "', matheloai='" + comtheloai.SelectedValue.ToString() + "', matacgia='" + commatacgia.SelectedValue.ToString() + "', soluong='" + txtsoluong.Text + "', ghichu=N'" + txtghichu.Text + "'where masach=N'" + txtmasach.Text + "'") == true)
                {

                    MessageBox.Show("Cập nhật dữ liệu thành công");
                    loaddata();
                    txtmasach.Enabled = false;

                }
                else MessageBox.Show("Không thể cập nhật dữ liệu");


            }
        }

        private void xoa_Click(object sender, EventArgs e)
        {
            txtmasach.Enabled = false;
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
                DialogResult chon = MessageBox.Show("Bạn có muốn xóa sách có mã số " + txtmasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
                if (chon == DialogResult.Yes)
                {
                    try
                    {

                        t.thucthidulieu("delete from sach where masach='" + txtmasach.Text + "'");
                        MessageBox.Show("Xóa thành Công", "Thông báo");
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

        private void thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                this.Hide();
                Formchinh f = new Formchinh();
                f.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dgvnxb_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
