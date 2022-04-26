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
    Hà Thị Thanh Xuân
 
 */

namespace WindowsFormsApplication1
{
    public partial class frmMuonsach : Form
    {
        public DateTime date1, date2;
        public TimeSpan time;
        public int day;
        public string dem;
        Themsuaxoa t = new Themsuaxoa();

        string Tendangnhap = "", Matkhau = "", Tendocgia = "", Gt = "", Email = "", Quyen = "", Madg = "";

        public frmMuonsach()
        {
            InitializeComponent();
            //AddButtonColumn();
        }
        public frmMuonsach(string Tendangnhap, string Tendocgia, string Matkhau, string Gt, string Email, string Quyen, string Madg)
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

        private void frmMuonsach_Load_1(object sender, EventArgs e)
        {

            if (Quyen == "False")
            {
                //grdg.Visible = false;
                //dgvdocgia.Enabled = false;
                DataTable dt1 = t.docdulieu("SELECT * from docgia WHERE madocgia ='" + Madg + "'");
                if (dt1 != null)
                {
                    dgvdocgia.DataSource = dt1;
                    loaddata();
                }
            }
            else
            {
                grdg.Visible = true;
                //load data độc giả
                DataTable dt = t.docdulieu("SELECT * from docgia ");
                if (dt != null)
                {
                    dgvdocgia.DataSource = dt;
                    gantxt();
                    loaddata();
                }
            }

            //load data sách
            loadsach();

        }

        private void loadsach()
        {
            DataTable dc = t.docdulieu("SELECT sach.masach, sach.tensach, sach.soluong, sach.namxb, theloai.tentheloai, tacgia.tentacgia FROM sach, theloai, tacgia WHERE sach.matheloai = theloai.matheloai AND sach.matacgia=tacgia.matacgia ");
            if (dc != null)
            {
                dgvsach.DataSource = dc;

            }
        }
        private void btmoi_Click(object sender, EventArgs e)
        {

        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                DataTable dt = t.docdulieu("SELECT * FROM login WHERE mod='"+Madg+"'");
                if (dt != null)
                {
                    this.Hide();
                    Formchinh f = new Formchinh(dt.Rows[0][0].ToString(), dt.Rows[0][1].ToString(), dt.Rows[0][2].ToString(), dt.Rows[0][3].ToString(), dt.Rows[0][4].ToString(), dt.Rows[0][5].ToString(), dt.Rows[0][6].ToString());
                    f.ShowDialog();
                }
            }
        }


        private void dgvdocgia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gantxt();
            loaddata();
        }

        private void gantxt()
        {
            txtmadocgia.Text = dgvdocgia.CurrentRow.Cells[0].Value.ToString();
            txttendocgia.Text = dgvdocgia.CurrentRow.Cells[1].Value.ToString();
            dtngaysinh.Text = dgvdocgia.CurrentRow.Cells[2].Value.ToString();
            comgioitinh.Text = dgvdocgia.CurrentRow.Cells[3].Value.ToString();
            txtlop.Text = dgvdocgia.CurrentRow.Cells[4].Value.ToString();
        }

        
        

        private void loaddata()
        {
            string a = dgvdocgia.CurrentRow.Cells[0].Value.ToString();
            int madg = Int16.Parse( a);
            //string TEN = dgvdocgia.CurrentRow.Cells[1].Value.ToString();
            //MessageBox.Show("hi " + TEN);
            DataTable dg = t.docdulieu("select sachmuon.maphieu , sachmuon.masach, tacgia.tentacgia, sach.tensach, sachmuon.ngaym, sachmuon.ngaytr, sach.ghichu   FROM sachmuon, tacgia, sach WHERE sach.matacgia=tacgia.matacgia AND sachmuon.masach=sach.masach  AND maphieu= '" + madg + "'");

            if (dg != null)
            {
                dgvgiosach.DataSource = dg;
            }
        }




        private void dgvsach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show(dgvsach.CurrentCell.Value.ToString(), "Chi tiết");

            //if (dgvgiosach.Columns[e.ColumnIndex].Name == "")
            //{
            //    if (MessageBox.Show("Bạn muốn xóa chứ ?", "Thông báo!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        // this.RemoveCurrent();
            //    }
            //}


        }
        private void dgvgiohang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex <= 6)
            {
                MessageBox.Show(dgvgiosach.CurrentCell.Value.ToString(),"Chi tiết");
            }
            //else if (e.ColumnIndex == 6)
            //{
            //    //MessageBox.Show("his");
            //    MessageBox.Show("his" + dgvsach.CurrentRow.Cells[5].Value.ToString());
            //}
        }
        

        
            private void timkiemdocgia()
        {
            DataTable dt5 = t.docdulieu("select * from docgia where madocgia like '%" + txttimDG.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from docgia where hoten like '%" + txttimDG.Text + "%'");
            if (ramadocgia.Checked == true)
            {
                dgvdocgia.DataSource = dt5;
            }
            else if (ratendocgia.Checked == true)
                dgvdocgia.DataSource = dt6;
            else
            {
                dgvdocgia.DataSource = dt6;
            }
        }
        private void txttimDG_TextChanged(object sender, EventArgs e)
        {
            timkiemdocgia();
        }

        private void ramadocgia_CheckedChanged(object sender, EventArgs e)
        {
            timkiemdocgia();
        }

        private void ratendocgia_CheckedChanged(object sender, EventArgs e)
        {
            timkiemdocgia();
        }

        private void timkiemsach(){
            DataTable dt = t.docdulieu("SELECT sach.masach, sach.tensach, sach.namxb, theloai.tentheloai, tacgia.tentacgia FROM sach, theloai, tacgia WHERE sach.matheloai = theloai.matheloai AND sach.matacgia=tacgia.matacgia AND masach like '%" + txttimSach.Text + "%' ");
            DataTable dt2 = t.docdulieu("SELECT sach.masach, sach.tensach, sach.namxb, theloai.tentheloai, tacgia.tentacgia FROM sach, theloai, tacgia WHERE sach.matheloai = theloai.matheloai AND sach.matacgia=tacgia.matacgia AND tensach like '%" + txttimSach.Text + "%' ");
            if (ramasach.Checked == true)
            {
                dgvsach.DataSource = dt;
            }
            else if (ratensach.Checked == true)
                dgvsach.DataSource = dt2;
            else
            {
                dgvsach.DataSource = dt2;
            }
        }

        private void txttimSach_TextChanged(object sender, EventArgs e)
        {
            timkiemsach();
        }



        private void btchon_Click(object sender, EventArgs e)
        {
            if (txtmadocgia.Text == "")
            {
                MessageBox.Show("Chưa chọn độc giả");
            }
            else 
            { 
                string a = txtmadocgia.Text;
                int maphieu = Int16.Parse(a);
                dem = dgvsach.CurrentRow.Cells[2].Value.ToString();
                int soluong = Int32.Parse(dem);

                string masach = dgvsach.CurrentRow.Cells[0].Value.ToString();
                DataTable dt = t.docdulieu("SELECT * FROM sachmuon WHERE maphieu='" + maphieu + "' AND masach= N'" + masach + "'");

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Sách đã được mượn, vui lòng chọn cuốn khác", "Thông báo");
                }
                else if (soluong == 0)
                {
                    MessageBox.Show("Sách đã hết, vui lòng chọn cuốn khác", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Bạn vừa Chọn sách mã : " + dgvsach.CurrentRow.Cells[0].Value.ToString());
                    gbngay.Visible = true;
                }
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            gbghichu.Visible = false;

            string a = txtmadocgia.Text;
            int maphieu = Int16.Parse(a);
            string masach = dgvsach.CurrentRow.Cells[0].Value.ToString();

            string ngaym = dtngaymuon.Value.ToString("yyyy/MM/dd");//dịnh dạng ngày để insert vào sql
            string ngaytr = dtngaytra.Value.ToString("yyyy/MM/dd");

            if (t.thucthidulieu("INSERT INTO sachmuon VALUES (N'" + masach + "','" + ngaym + "','" + ngaytr + "','" + maphieu + "')") == true)
            {
                t.thucthidulieu("UPDATE sach set ghichu=N'" + ghichu.Text + "'where masach=N'" + masach + "'");
                MessageBox.Show("Thêm thành công");

                
                dem = dgvsach.CurrentRow.Cells[2].Value.ToString();
                int soluong = Int32.Parse(dem);
                soluong = soluong - 1;
                t.docdulieu("UPDATE sach set soluong='" + soluong + "'where masach=N'" + masach + "'");
                loadsach();
                loaddata();
                
            }


            else 
            {
                MessageBox.Show("Lỗi không thể thực hiện được");


            }
        }



        private void btxoa_Click(object sender, EventArgs e)
        {
            string masach = dgvgiosach.CurrentRow.Cells[1].Value.ToString();
            DialogResult chon = MessageBox.Show("Bạn có muốn trả sách có mã " + masach + "", "Thông báo", MessageBoxButtons.YesNo);
            if (chon == DialogResult.Yes)
            {
                try
                {
                    gbghichu.Visible = true;
                    gbghichu.Text = "Tình trạng sách";
                    btexit2.Visible = false;
                    button4.Visible = false;
                    btupdate.Visible = true;

                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể xóa", "Thông báo");
                    throw;
                }

            }
            else loaddata();
        }
        private void btupdate_Click(object sender, EventArgs e)
        {
            btupdate.Visible = false;
            gbghichu.Visible = false;
            string masach = dgvgiosach.CurrentRow.Cells[1].Value.ToString();

            t.thucthidulieu("DELETE FROM sachmuon WHERE masach='" + masach + "'");
            MessageBox.Show("Đã trả sách" + masach + "", "Thông báo");
            dem = dgvsach.CurrentRow.Cells[2].Value.ToString();
            int soluong = Int32.Parse(dem);
            soluong = soluong + 1;
            t.docdulieu("UPDATE sach set soluong='"+soluong+"', ghichu=N'" + ghichu.Text + "'where masach=N'" + masach + "'");
            loaddata();
            loadsach();
        }


       

        private void btexit_Click(object sender, EventArgs e)
        {
            gbngay.Visible=false;
        }

        private void btexit2_Click(object sender, EventArgs e)
        {
            gbghichu.Visible = false;
        }

        
        private void button3_Click(object sender, EventArgs e)
        {
            date1 = Convert.ToDateTime(dtngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            date2 = Convert.ToDateTime(dtngaytra.Text);
            time = date2.Subtract(date1);
            day = time.Days;
            if (day < 0)
            {
                MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
                dtngaytra.Focus();
            }
            else
            {
                gbngay.Visible = false;
                gbghichu.Visible = true;
                btexit2.Visible = true;
                button4.Visible = true;
            }
           
        }
    }
}
