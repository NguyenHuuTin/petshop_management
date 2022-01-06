using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop
{
    public partial class FormLoginPetShop : Form
    {
        public FormLoginPetShop()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void guna2PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                String query = "select * from TAIKHOAN where SDT = @username and MATKHAU = @pass";
                SqlCommand comand = new SqlCommand(query, con);
                comand.Parameters.Add("@username", txtUser.Text);
                comand.Parameters.Add("@pass", txtPass.Text);
                SqlDataAdapter adp = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                con.Close();
                int quyen = Convert.ToInt32(dt.Rows[0]["QUYEN"].ToString());
                if (quyen == 1)
                {
                    FormManage newFrm = new FormManage();
                    this.Hide();
                    newFrm.ShowDialog();
                    
                }
                else if (quyen == 2)
                {
                    FormPetShop newFrm = new FormPetShop();
                    this.Hide();
                    newFrm.ShowDialog();
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                txtUser.Text = String.Empty;
                txtPass.Text = String.Empty;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = String.Empty;
            txtPass.Text = String.Empty;
        }
    }
}
