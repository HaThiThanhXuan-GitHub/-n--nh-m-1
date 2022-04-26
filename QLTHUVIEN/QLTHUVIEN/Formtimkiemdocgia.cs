using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
    Hà Thị Thanh Xuân
 
 */

namespace WindowsFormsApplication1
{
    public partial class Formtimkiemdocgia : Form
    {
        string Tendangnhap = "", Matkhau = "", Tendocgia = "", Gt = "", Email = "", Quyen = "", Madg = "";
        Themsuaxoa t = new Themsuaxoa();
        public Formtimkiemdocgia()
        {
            InitializeComponent();
        }

        public Formtimkiemdocgia(string Tendangnhap, string Tendocgia, string Matkhau, string Gt, string Email, string Quyen, string Madg)
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
            DataTable dt = t.docdulieu("select * from docgia");
            l.Text = dt.Rows.Count.ToString();

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã độc giả";
            luoi.Columns[1].HeaderText = "Họ và tên";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới tính";
            luoi.Columns[4].HeaderText = "Lớp";



            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            
            luoi.Enabled = true;

        }
        private void Formtimkiemdocgia_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt5 = t.docdulieu("select * from docgia where madocgia like '%" + txttimkiem.Text + "%'");
            DataTable dt6 = t.docdulieu("select * from docgia where hoten like '%" + txttimkiem.Text + "%'");
            if (ramasach.Checked == true)
            {
                luoi.DataSource = dt5;
            }
            else luoi.DataSource = dt6;

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
