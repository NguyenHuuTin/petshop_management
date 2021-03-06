using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms
{
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            List<HOADON> newlistHD = context.HOADONs.ToList();
            DataTable dtHD = new DataTable();
            dtHD.Columns.Add("Số Hóa Đơn", System.Type.GetType("System.String"));
            dtHD.Columns.Add("Khách Hàng", System.Type.GetType("System.String"));
            dtHD.Columns.Add("Nhân Viên", System.Type.GetType("System.String"));
            dtHD.Columns.Add("Ngày Lập", System.Type.GetType("System.DateTime"));
            dtHD.Columns.Add("Tổng Tiền", System.Type.GetType("System.Int32"));
            int i = 0;
            while (i != newlistHD.Count)
            {
                dtHD.Rows.Add(new object[] { newlistHD[i].MAHD, newlistHD[i].MAKH, newlistHD[i].MANV, newlistHD[i].NGAYLAP, newlistHD[i].TONGTIEN });
                i++;
            }
            dgvHD.DataSource = dtHD;
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRowHD = dgvHD.Rows[e.RowIndex];
                String id = dgvRowHD.Cells[0].Value.ToString();
                String kh = dgvRowHD.Cells[1].Value.ToString();
                String nv = dgvRowHD.Cells[2].Value.ToString();
                String ngl = dgvRowHD.Cells[3].Value.ToString();
                String tt = dgvRowHD.Cells[4].Value.ToString();

                String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                String query = "select HOADON.MAHD, KHACHHANG.HO_TENKH, NHANVIEN.HO_TENNV from HOADON, KHACHHANG, NHANVIEN where HOADON.MAKH = KHACHHANG.MAKH and HOADON.MANV = NHANVIEN.MANV and MAHD = '" + id + "' ";
                SqlCommand comand = new SqlCommand(query, con);
                SqlDataAdapter adp = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                con.Close();
                txtMAHD.Text = dt.Rows[0]["MAHD"].ToString();
                txtMAKHHD.Text = dt.Rows[0]["HO_TENKH"].ToString();
                txtMANVHD.Text = dt.Rows[0]["HO_TENNV"].ToString();
                dtpNGAYLAPHD.Text = ngl;
                txtTTHD.Text = tt;
            }
            FormOrders_Load(sender, e);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtMAHD.Text != "" || txtMAKHHD.Text != "" || txtMANVHD.Text != "" || txtTTHD.Text != "")
            {
                try
                { 
                    HOADON item = context.HOADONs.FirstOrDefault(p => p.MAHD == txtMAHD.Text);
                    if (item != null)
                    {
                        XoaCTHD(item.MAHD);
                        context.HOADONs.Remove(item);
                        context.SaveChanges();
                        txtMAHD.Text = "";
                        txtMAKHHD.Text = "";
                        txtMANVHD.Text = "";
                        dtpNGAYLAPHD.Text = "";
                        txtTTHD.Text = "";
                        MessageBox.Show("Xóa thành công");
                    }
                    else MessageBox.Show("Không tìm thấy đối tượng cần xóa trong CSDL");

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
            else MessageBox.Show("Bạn hãy nhập đủ thông tin!");
            FormOrders_Load(sender, e);
        }
        private void XoaCTHD(String mahd)
        {
            PetShopContextDB context = new PetShopContextDB();
            try
            {
                List<CHITIETHD> listct = context.CHITIETHDs.Where(p => p.MAHD == mahd).ToList();
                for (int i = 0; i < listct.Count; i++)
                {
                    context.CHITIETHDs.Remove(listct[i]);
                    context.SaveChanges();
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            frmHoadon frmhd = new frmHoadon();
            frmhd.ShowDialog();
        }

        private void btnCTHD_Click(object sender, EventArgs e)
        {
            if (txtMAHD.Text != String.Empty)
            {
                FormCTHD.d = txtMAHD.Text;
                FormCTHD newfrm = new FormCTHD();
                newfrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa tìm thấy đơn hàng");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (txtMAHD.Text != String.Empty)
            {
                ReportHoaDon.Sohd = txtMAHD.Text;
                ReportHoaDon newfrm = new ReportHoaDon();
                newfrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa tìm thấy đơn hàng");
            }
        }
    }
}
