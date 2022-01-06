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
    public partial class FormCTHD : Form
    {
        public static String d = String.Empty;
        public FormCTHD()
        {
            InitializeComponent();
            //Form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FormCTHD_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(d))
            {
                PetShopContextDB context = new PetShopContextDB();
                String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                
                HOADON hd = context.HOADONs.FirstOrDefault(p => p.MAHD == d);
                List<CHITIETHD> listCTHD = context.CHITIETHDs.Where(p => p.MAHD == d).ToList();
                List<CTHD> cthd = new List<CTHD>();
                for (int j = 0; j < listCTHD.Count; j++)
                {
                    if (listCTHD[j].MADV != null)
                    {
                        SqlConnection con3 = new SqlConnection(connection);
                        con3.Open();
                        String searchTenta = "select * from DICHVU where MADV = '" + listCTHD[j].MADV + "'";
                        SqlCommand com3 = new SqlCommand(searchTenta, con3);
                        SqlDataAdapter adap3 = new SqlDataAdapter(com3);
                        DataTable dt3 = new DataTable();
                        adap3.Fill(dt3);
                        String tendv = Convert.ToString(dt3.Rows[0]["TEN"].ToString());
                        CTHD newitem = new CTHD(tendv, Convert.ToString(listCTHD[j].SOLUONG), Convert.ToString(listCTHD[j].DONGIA), Convert.ToString(listCTHD[j].T_TIEN));
                        cthd.Add(newitem);
                    }
                    if (listCTHD[j].MATA != null)
                    {
                        SqlConnection con2 = new SqlConnection(connection);
                        con2.Open();
                        String searchTenta = "select * from THUCAN where MATA = '" + listCTHD[j].MATA + "'";
                        SqlCommand com2 = new SqlCommand(searchTenta, con2);
                        SqlDataAdapter adap2 = new SqlDataAdapter(com2);
                        DataTable dt2 = new DataTable();
                        adap2.Fill(dt2);
                        String tenta = Convert.ToString(dt2.Rows[0]["TEN"].ToString());
                        CTHD newitem = new CTHD(tenta, Convert.ToString(listCTHD[j].SOLUONG), Convert.ToString(listCTHD[j].DONGIA), Convert.ToString(listCTHD[j].T_TIEN));
                        cthd.Add(newitem);
                    }

                }
                DataTable tb = new DataTable();
                tb.Columns.Add("Tên", System.Type.GetType("System.String"));
                tb.Columns.Add("Số lượng", System.Type.GetType("System.String"));
                tb.Columns.Add("Đơn giá", System.Type.GetType("System.String"));
                tb.Columns.Add("Tổng tiền", System.Type.GetType("System.String"));
                int i = 0;
                while (i != cthd.Count)
                {
                    tb.Rows.Add(new object[] { cthd[i].Tendv, cthd[i].Soluong, cthd[i].DonGia, cthd[i].TongTien });
                    i++;
                }
                dgvCTHD.DataSource = tb;
               
            }

        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCTHD_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
