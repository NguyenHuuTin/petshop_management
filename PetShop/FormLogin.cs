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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
                    newFrm.ShowDialog();
                    this.Close();
                }
                else if (quyen == 2)
                {
                    FormPetShop newFrm = new FormPetShop();
                    newFrm.ShowDialog();
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
                btnCancel_Click_1(sender, e);
            }


        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
