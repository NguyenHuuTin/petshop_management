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

namespace PetShop
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //load dư lieu len datagridview
            PetShopContextDB context = new PetShopContextDB();
            List<THUCAN> newListTA = context.THUCANs.ToList();
            DataTable dtTA = new DataTable();
            dtTA.Columns.Add("Mã Thức Ăn", System.Type.GetType("System.String"));
            dtTA.Columns.Add("Tên Thức Ăn", System.Type.GetType("System.String"));
            dtTA.Columns.Add("Giá", System.Type.GetType("System.Int32"));
            int i = 0;
            while (i != newListTA.Count)
            {
                dtTA.Rows.Add(new object[] { newListTA[i].MATA, newListTA[i].TEN, newListTA[i].GIA });
                i++;
            }
            dgvTA.DataSource = dtTA;
            List<DICHVU> newlistDV = context.DICHVUs.ToList();
            DataTable dtDV = new DataTable();
            dtDV.Columns.Add("Mã Dịch Vụ", System.Type.GetType("System.String"));
            dtDV.Columns.Add("Tên Dịch Vụ", System.Type.GetType("System.String"));
            dtDV.Columns.Add("Giá Dịch Vụ", System.Type.GetType("System.Int32"));
            i = 0;
            while (i != newlistDV.Count)
            {
                dtDV.Rows.Add(new object[] { newlistDV[i].MADV, newlistDV[i].TEN, newlistDV[i].GIA });
                i++;
            }
            dgvDV.DataSource = dtDV;
            List<HOADON> newlistHD = context.HOADONs.ToList();
            DataTable dtHD = new DataTable();
            dtHD.Columns.Add("Mã Hóa Đơn", System.Type.GetType("System.String"));
            dtHD.Columns.Add("Mã Khách Hàng", System.Type.GetType("System.String"));
            dtHD.Columns.Add("Mã Nhân Viên", System.Type.GetType("System.String"));
            dtHD.Columns.Add("Ngày Lập", System.Type.GetType("System.DateTime"));
            dtHD.Columns.Add("Tổng Tiền", System.Type.GetType("System.Int32"));
            i = 0;
            while (i != newlistHD.Count)
            {
                dtHD.Rows.Add(new object[] { newlistHD[i].MAHD, newlistHD[i].MAKH, newlistHD[i].MANV, newlistHD[i].NGAYLAP, newlistHD[i].TONGTIEN });
                i++;
            }
            dgvHD.DataSource = dtHD;
            List<CHITIETHD> newlistCTHD = context.CHITIETHDs.ToList();
            DataTable dtCT = new DataTable();
            dtCT.Columns.Add("Mã CTHD", System.Type.GetType("System.String"));
            dtCT.Columns.Add("Mã Hóa Đơn", System.Type.GetType("System.String"));
            dtCT.Columns.Add("Mã Dịch Vụ", System.Type.GetType("System.String"));
            dtCT.Columns.Add("Mã Thức Ăn", System.Type.GetType("System.String"));
            dtCT.Columns.Add("Số Lượng", System.Type.GetType("System.Int32"));
            dtCT.Columns.Add("Giá", System.Type.GetType("System.Int32"));
            dtCT.Columns.Add("Tổng Tiền", System.Type.GetType("System.Int32"));
            i = 0;
            while (i != newlistCTHD.Count)
            {
                dtCT.Rows.Add(new object[] {newlistCTHD[i].MACT,newlistCTHD[i].MAHD,newlistCTHD[i].MADV,
                    newlistCTHD[i].MATA, newlistCTHD[i].SOLUONG, newlistCTHD[i].DONGIA, newlistCTHD[i].T_TIEN });
                i++;
            }
            dgvCTHD.DataSource = dtCT;
            List<NHANVIEN> newListNV = context.NHANVIENs.ToList();
            DataTable dtNV = new DataTable();
            dtNV.Columns.Add("Mã Nhân Viên", System.Type.GetType("System.String"));
            dtNV.Columns.Add("Tên Nhân Viên", System.Type.GetType("System.String"));
            dtNV.Columns.Add("Lương", System.Type.GetType("System.Int32"));
            dtNV.Columns.Add("Số Diện Thoại", System.Type.GetType("System.String"));
            i = 0;
            while (i != newListNV.Count)
            {
                dtNV.Rows.Add(new object[] { newListNV[i].MANV, newListNV[i].HO_TENNV, newListNV[i].LUONG, newListNV[i].SDT});
                i++;
            }
            dgvNV.DataSource = dtNV;
            List<KHACHHANG> kh = context.KHACHHANGs.ToList();
            DataTable dtkh = new DataTable();
            dtkh.Columns.Add("Mã Khách Hàng", System.Type.GetType("System.String"));
            dtkh.Columns.Add("Tên Khách Hàng", System.Type.GetType("System.String"));
            dtkh.Columns.Add("Địa Chỉ", System.Type.GetType("System.String"));
            dtkh.Columns.Add("Số Diện Thoại", System.Type.GetType("System.String"));
            i = 0;
            while (i != kh.Count)
            {
                dtkh.Rows.Add(new object[] { kh[i].MAKH, kh[i].HO_TENKH, kh[i].DCKH, kh[i].SDTKH });
                i++;
            }
            dgvKH.DataSource = dtkh;
            List<THUCUNG> tc = context.THUCUNGs.ToList();
            DataTable dttc = new DataTable();
            dttc.Columns.Add("Mã Thú Cưng", System.Type.GetType("System.String"));
            dttc.Columns.Add("Mã Chủ Nhân", System.Type.GetType("System.String"));
            dttc.Columns.Add("Tên Thú Cưng", System.Type.GetType("System.String"));
            dttc.Columns.Add("Tuổi Thú Cưng ", System.Type.GetType("System.Int32"));
            dttc.Columns.Add("Giống Loài", System.Type.GetType("System.String"));
            i = 0;
            while (i != tc.Count)
            {
                dttc.Rows.Add(new object[] { tc[i].MATC, tc[i].MACN, tc[i].TEN, tc[i].TUOI, tc[i].GIONG });
                i++;
            }
            dgvTC.DataSource = dttc;
            List<CALAMVIEC> clv = context.CALAMVIECs.ToList();
            DataTable dtclv = new DataTable();
            dtclv.Columns.Add("Buổi Làm Việc", System.Type.GetType("System.String"));
            dtclv.Columns.Add("Ngày Làm Việc", System.Type.GetType("System.DateTime"));
            dtclv.Columns.Add("Mã Nhân Viên", System.Type.GetType("System.String"));
            i = 0;
            while (i != clv.Count)
            {
                dtclv.Rows.Add(new object[] { clv[i].BUOI, clv[i].NGAY, clv[i].MANV });
                i++;
            }
            dgvCLV.DataSource = dtclv;

            String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
            DataTable data = new DataTable();
            String query = " Select * from PHUCVU ";
            using (SqlConnection cnn = new SqlConnection(connectionstring))
            {
                cnn.Open();
                SqlCommand command = new SqlCommand(query, cnn);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);
                cnn.Close();
            }
            dgvPV.DataSource = data;

            // combobox...

            cbbIDTCPV.DataSource = tc;
            cbbIDTCPV.DisplayMember = "TEN";
            cbbIDTCPV.ValueMember = "MATC";

            cbbIDNVPV.DataSource = newListNV;
            cbbIDNVPV.DisplayMember = "HO_TENNV";
            cbbIDNVPV.ValueMember = "MANV";

            
            cbbIDCN.DataSource = kh;
            cbbIDCN.DisplayMember = "HO_TENKH";
            cbbIDCN.ValueMember = "MAKH";

            cbbIDNVCLV.DataSource = newListNV;
            cbbIDNVCLV.DisplayMember = "HO_TENNV";
            cbbIDNVCLV.ValueMember = "MANV";

            this.label37.Parent = this.pictureBox2;
            
        }
        //hien thi du lieu len các textbox
        private void dgvCTHD_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRowCT = dgvCTHD.Rows[e.RowIndex];
                txtMACTHD.Text = dgvRowCT.Cells[0].Value.ToString();
                txtMAHDCT.Text = dgvRowCT.Cells[1].Value.ToString();
                txtMADVCT.Text = dgvRowCT.Cells[2].Value.ToString();
                txtMATACT.Text = dgvRowCT.Cells[3].Value.ToString();
                txtSL.Text = dgvRowCT.Cells[4].Value.ToString();
                txtGIACT.Text = dgvRowCT.Cells[5].Value.ToString();
                txtTTCT.Text = dgvRowCT.Cells[6].Value.ToString();
            }
        }

        private void btnXoaCT_Click_1(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtMACTHD.Text != "")
            {
                try
                {
                    CHITIETHD item = context.CHITIETHDs.FirstOrDefault(p => p.MACT == txtMACTHD.Text);
                    if (item != null)
                    {
                        context.CHITIETHDs.Remove(item);
                        context.SaveChanges();
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
            FormMain_Load(sender, e);
        }

        private void dgvHD_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRowHD = dgvHD.Rows[e.RowIndex];
                txtMAHD.Text = dgvRowHD.Cells[0].Value.ToString();
                txtMAKHHD.Text = dgvRowHD.Cells[1].Value.ToString();
                txtMANVHD.Text = dgvRowHD.Cells[2].Value.ToString();
                dtpNGAYLAPHD.Text = dgvRowHD.Cells[3].Value.ToString();
                txtTTHD.Text = dgvRowHD.Cells[4].Value.ToString();
            }
            FormMain_Load(sender, e);
        }

        private void btnThemHD_Click_1(object sender, EventArgs e)
        {
            frmHoadon frmhd = new frmHoadon();
            frmhd.ShowDialog();
            
        }

        private void XoaCTHD(String mahd)
        {
            PetShopContextDB context = new PetShopContextDB();
                try
                {
                    CHITIETHD item = context.CHITIETHDs.FirstOrDefault(p => p.MACT == txtMACTHD.Text);
                    List<CHITIETHD> listct = context.CHITIETHDs.Where(p => p.MAHD == mahd).ToList();
                    for(int i = 0; i < listct.Count; i++)
                    {
                        context.CHITIETHDs.Remove(listct[i]);
                        context.SaveChanges();
                    }

                }
                catch (Exception)
                {
                   
                }
            }
        private void btnXoaHD_Click_1(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtMAHD.Text != "" || txtMAKHHD.Text != "" || txtMANVHD.Text != "" || txtTTHD.Text != "")
            {
                try
                {
                    HOADON hd = new HOADON() { MAHD = txtMAHD.Text, MAKH = txtMAKHHD.Text, MANV = txtMANVHD.Text, NGAYLAP = Convert.ToDateTime(dtpNGAYLAPHD.Value), TONGTIEN = Convert.ToInt32(txtTTHD.Text) };
                    HOADON item = context.HOADONs.FirstOrDefault(p => p.MAHD == hd.MAHD && p.MAKH == hd.MAKH && p.MANV == hd.MANV && p.NGAYLAP == hd.NGAYLAP && p.TONGTIEN == hd.TONGTIEN);
                    if (item != null)
                    {
                        XoaCTHD(item.MAHD);
                        context.HOADONs.Remove(item);
                        context.SaveChanges();
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
            FormMain_Load(sender, e);
        }

        private void dgvDV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRowDV = dgvDV.Rows[e.RowIndex];
                txtMaDV.Text = dgvRowDV.Cells[0].Value.ToString();
                txtTenDV.Text = dgvRowDV.Cells[1].Value.ToString();
                txtGiaDV.Text = dgvRowDV.Cells[2].Value.ToString();
            }
        }

        private void btnThemDV_Click_1(object sender, EventArgs e)
        {
     
            if (txtMaDV.Text != "" || txtTenDV.Text != "" || txtGiaDV.Text != "")
            {
                String madv = txtMaDV.Text;
                String tendv = txtTenDV.Text;
                int giadv = Convert.ToInt32(txtGiaDV.Text);
                String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " INSERT INTO DICHVU (MADV,TEN,GIA) VALUES ('" + madv + "', N'" + tendv + "'," + giadv + " ) ";
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không thành công");
                    }

                }

            }
            else MessageBox.Show("Bạn hãy nhập đủ thông tin!");
            FormMain_Load(sender, e);
        }

        private void btnSuaDV_Click_1(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtMaDV.Text != "" || txtTenDV.Text != "" || txtGiaDV.Text != "")
            {
                try
                {
                    DICHVU newDV = new DICHVU() { MADV = txtMaDV.Text, TEN = txtTenDV.Text, GIA = Convert.ToInt32(txtGiaDV.Text) };
                    DICHVU item = context.DICHVUs.FirstOrDefault(p => p.MADV == newDV.MADV);
                    if (item != null)
                    {
                        item.TEN = newDV.TEN;
                        item.GIA = newDV.GIA;
                        context.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                    }
                    else MessageBox.Show("Không tìm thấy đối tượng trong CSDL");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
            else MessageBox.Show("Bạn hãy nhập đầy đủ thông tin!");
            FormMain_Load(sender, e);
        }

        private void btnXoaDV_Click_1(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtMaDV.Text != "" || txtTenDV.Text != "" || txtGiaDV.Text != "")
            {
                try
                {
                    DICHVU newDV = new DICHVU() { MADV = txtMaDV.Text, TEN = txtTenDV.Text, GIA = Convert.ToInt32(txtGiaDV.Text) };
                    DICHVU item = context.DICHVUs.FirstOrDefault(p => p.MADV == newDV.MADV && p.TEN == newDV.TEN && p.GIA == newDV.GIA);
                    if (item != null)
                    {
                        context.DICHVUs.Remove(item);
                        context.SaveChanges();
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
            FormMain_Load(sender, e);
        }

        private void dgvTA_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRowTA = dgvTA.Rows[e.RowIndex];
                txtMaTA.Text = dgvRowTA.Cells[0].Value.ToString();
                txtTenTA.Text = dgvRowTA.Cells[1].Value.ToString();
                txtGiaTA.Text = dgvRowTA.Cells[2].Value.ToString();
            }
        }

        private void btnThemTA_Click_1(object sender, EventArgs e)
        {
            if (txtMaTA.Text != "" || txtTenTA.Text != "" || txtGiaTA.Text != "")
            {
                String mata = txtMaTA.Text;
                String tenta = txtTenTA.Text;
                int giata = Convert.ToInt32(txtGiaTA.Text);
                String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " INSERT INTO THUCAN(MATA,TEN,GIA) VALUES ('" + mata + "', N'" + tenta + "'," + giata + " ) ";
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
            }
            else MessageBox.Show("Bạn hãy nhập đủ thông tin!");
            FormMain_Load(sender, e);
        }

        private void btnSuaTA_Click_1(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtMaTA.Text != "" || txtTenTA.Text != "" || txtGiaTA.Text != "")
            {
                try
                {
                    THUCAN newTA = new THUCAN() { MATA = txtMaTA.Text, TEN = txtTenTA.Text, GIA = Convert.ToInt32(txtGiaTA.Text) };
                    THUCAN item = context.THUCANs.FirstOrDefault(p => p.MATA == newTA.MATA);
                    if (item != null)
                    {
                        item.TEN = newTA.TEN;
                        item.GIA = newTA.GIA;
                        context.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                    }
                    else MessageBox.Show("Không tìm thấy đối tượng trong CSDL");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
            FormMain_Load(sender, e);
        }

        private void btnXoaTA_Click_1(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtMaTA.Text != "" || txtTenTA.Text != "" || txtGiaTA.Text != "")
            {
                try
                {
                    THUCAN newTA = new THUCAN() { MATA = txtMaTA.Text, TEN = txtTenTA.Text, GIA = Convert.ToInt32(txtGiaTA.Text) };
                    THUCAN item = context.THUCANs.FirstOrDefault(p => p.MATA == newTA.MATA && p.TEN == newTA.TEN && p.GIA == newTA.GIA);
                    if (item != null)
                    {
                        context.THUCANs.Remove(item);
                        context.SaveChanges();
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
            FormMain_Load(sender, e);
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvNV.Rows[e.RowIndex];
                txtIDNV.Text = row.Cells[0].Value.ToString();
                txtNameNV.Text = row.Cells[1].Value.ToString();
                txtSalaryNV.Text = row.Cells[3].Value.ToString();
                txtPhoneNV.Text = row.Cells[2].Value.ToString();
            }
        }

        private void dgvKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvKH.Rows[e.RowIndex];
                txtIDKH.Text = row.Cells[0].Value.ToString();
                txtNameKH.Text = row.Cells[1].Value.ToString();
                txtAddressKH.Text = row.Cells[2].Value.ToString();
                txtPhoneKH.Text = row.Cells[3].Value.ToString();
            }
        }

        private void dgvTC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvTC.Rows[e.RowIndex];
                txtIDTC.Text = row.Cells[0].Value.ToString();
                cbbIDCN.SelectedValue = row.Cells[1].Value.ToString();
                txtNameTC.Text = row.Cells[2].Value.ToString();
                txtAgeTC.Text = row.Cells[3].Value.ToString();
                txtGiongLoai.Text = row.Cells[4].Value.ToString();
            }
        }

        private void dgvCLV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCLV.Rows[e.RowIndex];
                txtBuoi.Text = row.Cells[0].Value.ToString();
                dtpNgayLamViec.Text = row.Cells[1].Value.ToString();
                cbbIDNVCLV.SelectedValue= row.Cells[2].Value.ToString();
            }
        }

        private void dgvPV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvPV.Rows[e.RowIndex];
                cbbIDNVPV.SelectedValue = row.Cells[0].Value.ToString();
                cbbIDTCPV.SelectedValue = row.Cells[1].Value.ToString();
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if(txtIDNV.Text!="" && txtNameNV.Text!="" && txtSalaryNV.Text!="" && txtPhoneNV.Text != "")
            {
                string id = txtIDNV.Text;
                string name = txtNameNV.Text;
                int salary = Convert.ToInt32(txtPhoneNV.Text);
                string phone = txtSalaryNV.Text;

                String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " INSERT INTO NHANVIEN (MANV,HO_TENNV,SDT,LUONG) VALUES ('" + id + "', N'" + name + "'," + salary + ", '" + phone + "' ) ";
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }

            }
            else MessageBox.Show("Bạn hãy nhập đủ thông tin!");
            FormMain_Load(sender, e);
        }

        private void btnUpdateNV_Click(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtIDNV.Text != "" && txtNameNV.Text != "" && txtSalaryNV.Text != "" && txtPhoneNV.Text != "")
            {
                try
                {
                    string id = txtIDNV.Text;
                    string name = txtNameNV.Text;
                    int salary = Convert.ToInt32(txtPhoneNV.Text);
                    string phone = txtSalaryNV.Text;

                    NHANVIEN newNV = new NHANVIEN() { MANV = id, HO_TENNV = name, LUONG = salary, SDT = phone };
                    NHANVIEN item = context.NHANVIENs.FirstOrDefault(p => p.MANV == newNV.MANV);
                    if (item != null)
                    {
                        item.HO_TENNV = newNV.HO_TENNV;
                        item.LUONG = newNV.LUONG;
                        item.SDT = newNV.SDT;
                        context.SaveChanges();
                        MessageBox.Show("Sửa thành công");
                    }
                    else MessageBox.Show("Không tìm thấy đối tượng trong CSDL");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không thành công!");
                }
            }
            else MessageBox.Show("Bạn hãy nhập đủ thông tin!");
            FormMain_Load(sender, e);
        }

        private void btnDeleteNV_Click(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtIDNV.Text != "")
            {
                
                    string id = txtIDNV.Text;
                    /*string name = txtNameNV.Text;
                    int salary = Convert.ToInt32(txtPhoneNV.Text);
                    string phone = txtSalaryNV.Text;

                    NHANVIEN newNV = new NHANVIEN() { MANV = id, HO_TENNV = name, LUONG = salary, SDT = phone };*/
                    NHANVIEN item = context.NHANVIENs.FirstOrDefault(p => p.MANV == id);
                    if (item != null)
                    {
                        context.NHANVIENs.Remove(item);
                        context.SaveChanges();
                        MessageBox.Show("Xóa Thành Công");
                    }
                    else MessageBox.Show("Không tìm thấy đối tượng cần xóa trong CSDL");

                /*}
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }*/
            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
           
            if (txtIDKH.Text != "" && txtNameKH.Text != "" && txtAddressKH.Text != "" && txtPhoneKH.Text != "")
            {
                string id = txtIDKH.Text;
                string name = txtNameKH.Text;
                String address = txtAddressKH.Text;
                string phone = txtPhoneKH.Text;

                String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " INSERT INTO KHACHHANG (MAKH,HO_TENKH,DCKH,SDTKH) VALUES  ('" + id + "', N'" + name + "',N'" + address + "', '" + phone + "' ) ";
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không Thành Công");
                    }
                }

            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnUpdateKH_Click(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtIDKH.Text != "" && txtNameKH.Text != "" && txtAddressKH.Text != "" && txtPhoneKH.Text != "")
            {
                try
                {
                    string id = txtIDKH.Text;
                    string name = txtNameKH.Text;
                    String address = txtAddressKH.Text;
                    string phone = txtPhoneKH.Text;

                    KHACHHANG newitem = new KHACHHANG() { MAKH = id, HO_TENKH = name, DCKH = address, SDTKH = phone };
                    KHACHHANG item = context.KHACHHANGs.FirstOrDefault(p => p.MAKH == newitem.MAKH);
                    if (item != null)
                    {
                        item.HO_TENKH= newitem.HO_TENKH;
                        item.DCKH = newitem.DCKH;
                        item.SDTKH = newitem.SDTKH;
                        context.SaveChanges();
                        MessageBox.Show("Sửa Thành Công");
                    }
                    else MessageBox.Show("Không tìn thấy đối tượng trong CSDL");
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa Không Thành Công!");
                }
            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnDeleteKH_Click(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtIDKH.Text != "" && txtNameKH.Text != "" && txtAddressKH.Text != "" && txtPhoneKH.Text != "")
            {
                try
                {
                    string id = txtIDKH.Text;
                    string name = txtNameKH.Text;
                    String address = txtAddressKH.Text;
                    string phone = txtPhoneKH.Text;

                    KHACHHANG newitem = new KHACHHANG() { MAKH = id, HO_TENKH = name, DCKH = address, SDTKH = phone };
                    KHACHHANG item = context.KHACHHANGs.FirstOrDefault(p => p.MAKH == newitem.MAKH);
                    if (item != null)
                    {
                        context.KHACHHANGs.Remove(item);
                        context.SaveChanges();
                        MessageBox.Show("Xóa Thành Công");
                    }
                    else MessageBox.Show("Không tìm thấy đối tượng cần xóa trong CSDL");

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnAddTC_Click(object sender, EventArgs e)
        {
            if (txtIDTC.Text != "" && cbbIDCN.Text != "" && txtNameTC.Text != "" && txtAgeTC.Text != "" && txtGiongLoai.Text!="")
            {
                String idtc = txtIDTC.Text;
                String idcn = cbbIDCN.SelectedValue.ToString();
                String name = txtNameTC.Text;
                int age = Convert.ToInt32(txtAgeTC.Text);
                String giong = txtGiongLoai.Text;

                String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " INSERT INTO THUCUNG (MATC,MACN,TEN,TUOI,GIONG) VALUES  ('" + idtc + "', '" + idcn + "',N'" + name + "', " + age + " , '" + giong + "') ";
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không Thành Công");
                    }
                }

            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnUpdateTC_Click(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtIDTC.Text != "" && cbbIDCN.Text != "" && txtNameTC.Text != "" && txtAgeTC.Text != "" && txtGiongLoai.Text != "")
            {
                String idtc = txtIDTC.Text;
                String idcn = cbbIDCN.SelectedValue.ToString();
                String name = txtNameTC.Text;
                int age = Convert.ToInt32(txtAgeTC.Text);
                String giong = txtGiongLoai.Text;

                String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " update THUCUNG set  MACN = '" + idcn + "' , TEN = '" + name + "', TUOI = " + age + " , GIONG = '" + giong + "' where MATC = '" + idtc + "' ";
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Sửa thành công");
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Sửa không Thành Công");
                    }
                }

            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnDeleteTC_Click(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtIDTC.Text != "" && cbbIDCN.Text != "" && txtNameTC.Text != "" && txtAgeTC.Text != "" && txtGiongLoai.Text != "")
            {
                try
                {
                    String idtc = txtIDTC.Text;
                    String idcn = cbbIDCN.SelectedValue.ToString();
                    String name = txtNameTC.Text;
                    int age = Convert.ToInt32(txtAgeTC.Text);
                    String giong = txtGiongLoai.Text;

                    THUCUNG newitem = new THUCUNG() { MATC = idtc, MACN = idcn, TEN = name, TUOI = age, GIONG = giong };
                    THUCUNG item = context.THUCUNGs.FirstOrDefault(p => p.MATC == newitem.MATC);
                    if (item != null)
                    {
                        context.THUCUNGs.Remove(item);
                        context.SaveChanges();
                        MessageBox.Show("Xóa Thành Công");
                    }
                    else MessageBox.Show("Không tìm thấy đối tượng cần xóa trong CSDL");

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnAddCLV_Click(object sender, EventArgs e)
        {
            if (txtBuoi.Text != "" && cbbIDNVCLV.Text!="")
            {
                String buoi = txtBuoi.Text;
                DateTime ngaylamviec = Convert.ToDateTime(dtpNgayLamViec.Value);
                String nv = cbbIDNVCLV.SelectedValue.ToString();

                String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " INSERT INTO CALAMVIEC (BUOI,NGAY,MANV) VALUES (N'" + buoi + "', '" + ngaylamviec + "','" + nv + "') ";
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không Thành Công");
                    }
                }

            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnDeleteCLV_Click(object sender, EventArgs e)
        {

            PetShopContextDB context = new PetShopContextDB();
            if (txtBuoi.Text != "" && cbbIDNVCLV.Text != "")
            {
                try
                {
                    String buoi = txtBuoi.Text;
                    DateTime ngaylamviec = Convert.ToDateTime(dtpNgayLamViec.Value);
                    String nvlv = cbbIDNVCLV.SelectedValue.ToString();

                    CALAMVIEC newitem = new CALAMVIEC() { BUOI = buoi , NGAY = ngaylamviec , MANV = nvlv };
                    CALAMVIEC item = context.CALAMVIECs.FirstOrDefault(p => p.BUOI == newitem.BUOI && p.MANV == newitem.MANV && DateTime.Compare(p.NGAY, newitem.NGAY) == 0);
                    if (item != null)
                    {
                        context.CALAMVIECs.Remove(item);
                        context.SaveChanges();
                        MessageBox.Show("Xóa Thành Công");
                    }
                    else MessageBox.Show("Không tìm thấy đối tượng cần xóa trong CSDL");

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnAddPV_Click(object sender, EventArgs e)
        {
            if (cbbIDNVPV.Text != "" && cbbIDTCPV.Text != "")
            {
                String idnv = cbbIDNVPV.SelectedValue.ToString();
                String idtc = cbbIDTCPV.SelectedValue.ToString();


                String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " INSERT INTO PHUCVU (MANV,MATC) VALUES ('" + idnv + "', '" + idtc + "') ";
                
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                   try
                   {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        cnn.Close();
                   }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không Thành Công");
                    }
                }

            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void btnDeletePV_Click(object sender, EventArgs e)
        {
            if (cbbIDNVPV.Text != "" && cbbIDTCPV.Text != "")
            {
                String idnv = cbbIDNVPV.SelectedValue.ToString();
                String idtc = cbbIDTCPV.SelectedValue.ToString();

                String connectionstring = "Data Source=DESKTOP-F5QFG7D\\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " DELETE FROM PHUCVU WHERE MANV = '" + idnv + "' AND MATC = '" + idtc + "' ";
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Xóa Thành Công");
                        cm.Dispose();
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa không Thành Công");
                    }
                }

            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormMain_Load(sender, e);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
        {

        }
    }
}
