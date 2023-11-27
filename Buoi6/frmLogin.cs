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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text=="admin")
            {
                if (txtPassword.Text=="1234")
                {
                    frmNhanVien fnv = new frmNhanVien();
                    fnv.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai password!!!");
                }
            }
            else
            {
                MessageBox.Show("Sai username!!!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }
    }
}
