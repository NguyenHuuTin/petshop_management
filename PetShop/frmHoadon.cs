using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PetShop
{
    public partial class frmHoadon : Form
    {
        public frmHoadon()
        {
            InitializeComponent();
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }
        int dong = 0;
        
        private void frmHoadon_Load(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            List<NHANVIEN> nhanvien = context.NHANVIENs.ToList();
            cbbMANV.DataSource = nhanvien;
            cbbMANV.DisplayMember = "HO_TENNV";
            cbbMANV.ValueMember = "MANV";
            List<KHACHHANG> khachhang = context.KHACHHANGs.ToList();
            cbbMAKH.DataSource = khachhang;
            cbbMAKH.DisplayMember = "HO_TENKH";
            cbbMAKH.ValueMember = "MAKH";
            List<DICHVU> dichvu = context.DICHVUs.ToList();
            List<THUCAN> thucan = context.THUCANs.ToList();
            List<DichVuThucAn> dvta = new List<DichVuThucAn>();
            
            for (int i = 0; i < dichvu.Count; i++)
            {
                DichVuThucAn newdvta = new DichVuThucAn();
                newdvta.MADVTA = dichvu[i].MADV;
                newdvta.TENDVTA = dichvu[i].TEN;
                newdvta.GIADVTA = dichvu[i].GIA;
                dvta.Add(newdvta);
            }
            for (int j = 0; j < thucan.Count; j++)
            {
                DichVuThucAn newdvta = new DichVuThucAn();
                newdvta.MADVTA = thucan[j].MATA;
                newdvta.TENDVTA = thucan[j].TEN;
                newdvta.GIADVTA = thucan[j].GIA;
                dvta.Add(newdvta);
            }
            colDVandTA.DataSource = dvta;
            colDVandTA.DisplayMember = "TENDVTA";
            colDVandTA.ValueMember = "MADVTA";

            txtTongTien.Text = "0";

        }

        private void dgvChiTietDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            int tong = 0;
            for (int i = 0; i < dgvChiTietDonHang.Rows.Count - 1; i++)
            {

                tong += Convert.ToInt32(dgvChiTietDonHang.Rows[i].Cells[3].Value);


            }
            txtTongTien.Text = Convert.ToString(tong);
            
        }

        private void dgvChiTietDonHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();

            if (dgvChiTietDonHang.Rows[dong].Cells[1].Value != null && dgvChiTietDonHang.Rows[dong].Cells[2].Value != null)
            {
                dgvChiTietDonHang.Rows[dong].Cells[3].Value = Convert.ToInt32(dgvChiTietDonHang.Rows[dong].Cells[1].Value) * Convert.ToInt32(dgvChiTietDonHang.Rows[dong].Cells[2].Value);
            }

            try
            {
                String d = Convert.ToString(dgvChiTietDonHang.Rows[dong].Cells[0].Value);

                DICHVU dv = context.DICHVUs.FirstOrDefault(p => p.MADV == d);
                THUCAN ta = context.THUCANs.FirstOrDefault(p => p.MATA == d);


                if (dv != null)
                {
                    dgvChiTietDonHang.Rows[dong].Cells[2].Value = Convert.ToString(dv.GIA);
                }
                if (ta != null)
                {
                    dgvChiTietDonHang.Rows[dong].Cells[2].Value = Convert.ToString(ta.GIA);
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void txtTongTien_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void btnThemHD_Click_1(object sender, EventArgs e)
        {
            String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            String query = "select Top 1 * from HOADON order by MAHD DESC";
            SqlCommand comand = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            if (dt.Rows.Count > 0)
            {
                String sohd = dt.Rows[0]["MAHD"].ToString();

                String strhd = sohd.Substring(1, sohd.Length - 1);
                int d = Convert.ToInt32(strhd);
                if (d < 9)
                {
                    txtSOHD.Text = "H00" + (d + 1);
                }
                else txtSOHD.Text = "H0" + (d + 1);


            }
            else txtSOHD.Text = "H001";
        }

        private void btnInHD_Click_1(object sender, EventArgs e)
        {
            if (txtSOHD.Text != "")
            {
                if (txtTongTien.Text != "0")
                {
                    try
                    {
                        PetShopContextDB context = new PetShopContextDB();
                        String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                        SqlConnection con1 = new SqlConnection(connection);
                        con1.Open();
                        String mhd = txtSOHD.Text;
                        String makh = cbbMAKH.SelectedValue.ToString();
                        String manv = cbbMANV.SelectedValue.ToString();
                        DateTime ngaylap = Convert.ToDateTime(dtpngaylap.Value);
                        int tongtien = Convert.ToInt32(txtTongTien.Text);
                        String addHD = "insert into HOADON values ('" + mhd + "', '" + makh + "', '" + manv + "', '" + ngaylap + "', " + tongtien + ") ";
                        SqlCommand com1 = new SqlCommand(addHD, con1);
                        SqlDataAdapter adp1 = new SqlDataAdapter(com1);
                        com1.ExecuteNonQuery();
                        con1.Close();


                        for (int i = 0; i < dgvChiTietDonHang.Rows.Count - 1; i++)
                        {
                            String d = Convert.ToString(dgvChiTietDonHang.Rows[i].Cells[0].Value);
                            //String madvta = dgvChiTietDonHang.Rows[i].Cells[0].Value.ToString();
                            String query = "";
                            int sl = Convert.ToInt32(dgvChiTietDonHang.Rows[i].Cells[1].Value);
                            int dongia = Convert.ToInt32(dgvChiTietDonHang.Rows[i].Cells[2].Value);
                            int tt = Convert.ToInt32(dgvChiTietDonHang.Rows[i].Cells[3].Value);

                            /*SqlConnection con0 = new SqlConnection(connection);
                            con0.Open();//order by MACT DESC
                            String query0 = "select  * from CHITIETHD ";
                            SqlCommand comand0 = new SqlCommand(query0, con0);
                            SqlDataAdapter adp0 = new SqlDataAdapter(comand0);
                            DataTable dt0 = new DataTable();
                            adp0.Fill(dt0);
                            con0.Close();
                            int max = Convert.ToInt32(dt0.Rows[0]["MACT"].ToString());
                            for (int j = 1; j < dt0.Rows.Count; j++)
                            {
                                if (Convert.ToInt32(dt0.Rows[j]["MACT"].ToString()) > max)
                                    max = Convert.ToInt32(dt0.Rows[j]["MACT"].ToString());
                            }
                            //int temp = Convert.ToInt32(dt0.Rows[0]["MACT"].ToString());
                            int temp = max;
                            String mact = Convert.ToString(temp + 1);*/
                            DICHVU dv = context.DICHVUs.FirstOrDefault(p => p.MADV == d);
                            THUCAN ta = context.THUCANs.FirstOrDefault(p => p.MATA == d);
                            String mahd = txtSOHD.Text;
                            if (dv != null)
                            {
                                query = " INSERT INTO CHITIETHD (MAHD,MADV,SOLUONG,DONGIA,T_TIEN) VALUES ('" + mahd + "','" + d + "', " + sl + ", " + dongia + " , " + tt + ") ";
                            }
                            if (ta != null)
                            {
                                query = " INSERT INTO CHITIETHD (MAHD,MATA,SOLUONG,DONGIA,T_TIEN) VALUES ('" + mahd + "','" + d + "', " + sl + ", " + dongia + " , " + tt + ") ";
                            }

                            SqlConnection con = new SqlConnection(connection);
                            con.Open();
                            SqlCommand comand = new SqlCommand(query, con);
                            SqlDataAdapter adp = new SqlDataAdapter();
                            comand.ExecuteNonQuery();
                            con.Close();
                        }
                        ReportHoaDon.Sohd = mhd;
                        ReportHoaDon report = new ReportHoaDon();
                        report.ShowDialog();

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lỗi hệ thống!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else MessageBox.Show("Bạn chưa có mặt hàng nào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bạn chưa thêm số hóa đơn mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvChiTietDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmHoadon_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
    public class DichVuThucAn
    {
        public String MADVTA { get; set; }
        public String TENDVTA { get; set; }
        public int GIADVTA { get; set; }
    }
}
