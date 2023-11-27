using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buoi6
{
    public partial class frmNhanVien : Form
    {
        List<CNhanVien> dsnv = new List<CNhanVien>();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            CNhanVien nv = new CNhanVien();
            nv.code = txtCode.Text;
            nv.name = txtTen.Text;
            nv.luong = double.Parse(txtLuong.Text);
            if (rdbChinhThuc.Checked==true)
            {
                nv.LoaiNV = "Chính Thức";
            }
            else
            {
                nv.LoaiNV = "Thời Vụ";
            }
            dsnv.Add(nv);
            dgvNhanVien.DataSource = dsnv.ToList();
            txtCode.Clear();
            txtTen.Clear();
            txtLuong.Clear();
            if (rdbChinhThuc.Checked == true)
            {
                rdbChinhThuc.Checked=false;
            }
            else
            {
                rdbThoiVu.Checked=false;
            }
            txtCode.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin fmlogin = new frmLogin();
            fmlogin.Show();
            this.Close();
        }
    }
}
