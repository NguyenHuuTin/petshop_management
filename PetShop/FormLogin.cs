using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.label1.Parent = this.pictureBox1;
            this.label2.Parent = this.pictureBox1;
            this.label3.Parent = this.pictureBox1;
           
            this.label4.Parent = this.pictureBox1;
            this.label5.Parent = this.pictureBox1;
            this.label8.Parent = this.pictureBox1;
            this.txtUser.Parent = this.pictureBox1;
            this.txtPass.Parent = this.pictureBox1;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (txtUser.Text == "admin" && txtPass.Text == "admin")
            {
                FormMain newFrm = new FormMain();
                newFrm.ShowDialog();
                this.Close();
                this.Hide();
            }
            else MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }
    }
}
