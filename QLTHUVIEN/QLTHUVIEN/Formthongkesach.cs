using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Formthongkesach : Form
    {
        string Tendangnhap = "", Matkhau = "", Tendocgia = "", Gt = "", Email = "", Quyen = "", Madg = "";

        Themsuaxoa t = new Themsuaxoa();
        public Formthongkesach()
        {
            InitializeComponent();
        }
        public Formthongkesach(string Tendangnhap, string Tendocgia, string Matkhau, string Gt, string Email, string Quyen, string Madg)
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
            DataTable dt = t.docdulieu("select sach.masach, sach.tensach, nhaxb.tennxb,sach.namxb,theloai.tentheloai from sach, nhaxb, theloai where (sach.manxb=nhaxb.manxb and sach.matheloai=theloai.matheloai)");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
           luoi.Columns[4].HeaderText = "Thể loại";
          //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata1()
        {
            DataTable dt = t.docdulieu("select sach.masach,sach.tensach, nhaxb.tennxb,sach.namxb,theloai.tentheloai from sach, nhaxb,chitietmuon, theloai where (sach.manxb=nhaxb.manxb and sach.matheloai=theloai.matheloai and sach.masach=chitietmuon.masach)");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
            luoi.Columns[4].HeaderText = "Thể loại";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select sach.masach,sach.tensach, nhaxb.tennxb,sach.namxb,theloai.tentheloai from sach, nhaxb,chitietmuon, theloai where (sach.manxb=nhaxb.manxb and sach.matheloai=theloai.matheloai and sach.masach=chitietmuon.masach and chitietmuon.ngaytra<GETDATE())");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã sách";
            luoi.Columns[1].HeaderText = "Tên sách";
            luoi.Columns[2].HeaderText = "Nhà xuất bản";
            luoi.Columns[3].HeaderText = "Năm xuất bản";
            luoi.Columns[4].HeaderText = "Thể loại";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void Formthongkesach_Load(object sender, EventArgs e)
        {
            tuychon.Text = "Tất cả sách";

            loaddata();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tuychon.Text == "Tất cả sách")
                loaddata();
            else if (tuychon.Text == "Sách đang mượn")
                loaddata1();
            else loaddata2();


            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            
            DataTable dt = (DataTable)luoi.DataSource;
            excel.Export(dt, "Sách", "Thống kê sách");
        }

        private void button1_Click(object sender, EventArgs e)
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
