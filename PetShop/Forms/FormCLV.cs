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
    public partial class FormCLV : Form
    {
        public FormCLV()
        {
            InitializeComponent();
        }

        private void FormCLV_Load(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            List<CALAMVIEC> clv = context.CALAMVIECs.ToList();
            DataTable dtclv = new DataTable();
            dtclv.Columns.Add("Buổi Làm Việc", System.Type.GetType("System.String"));
            dtclv.Columns.Add("Ngày Làm Việc", System.Type.GetType("System.DateTime"));
            dtclv.Columns.Add("Mã Nhân Viên", System.Type.GetType("System.String"));
            int i = 0;
            while (i != clv.Count)
            {
                dtclv.Rows.Add(new object[] { clv[i].BUOI, clv[i].NGAY, clv[i].MANV });
                i++;
            }
            dgvCLV.DataSource = dtclv;

            List<NHANVIEN> newListNV = context.NHANVIENs.ToList();
            cbbIDNVCLV.DataSource = newListNV;
            cbbIDNVCLV.DisplayMember = "HO_TENNV";
            cbbIDNVCLV.ValueMember = "MANV";
        }

        private void dgvCLV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvCLV.Rows[e.RowIndex];
                txtBuoi.Text = row.Cells[0].Value.ToString();
                dtpNgayLamViec.Text = row.Cells[1].Value.ToString();
                cbbIDNVCLV.SelectedValue = row.Cells[2].Value.ToString();
            }
        }

        private void btnAddCLV_Click(object sender, EventArgs e)
        {
            if (txtBuoi.Text != "" && cbbIDNVCLV.Text != "")
            {
                String buoi = txtBuoi.Text;
                DateTime ngaylamviec = Convert.ToDateTime(dtpNgayLamViec.Value);
                String nv = cbbIDNVCLV.SelectedValue.ToString();

                String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
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
            FormCLV_Load(sender, e);
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

                    String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                    String qeurycount = " DELETE FROM CALAMVIEC WHERE BUOI = '" + buoi + "' and MANV = '" + nvlv +"' and NGAY = '" + ngaylamviec + "'";
                    using (SqlConnection cnn = new SqlConnection(connectionstring))
                    {
                        cnn.Open();
                        try
                        {
                            SqlCommand cm = new SqlCommand(qeurycount, cnn);
                            SqlDataAdapter adapter = new SqlDataAdapter(cm);
                            cm.ExecuteNonQuery();
                            MessageBox.Show("Xóa Thành Công");
                            cnn.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Xóa Không Thành Công!");
                        }
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa Không Thành Công!");
                }
            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            txtBuoi.Text = String.Empty;
            FormCLV_Load(sender, e);
        }
        
    }
}
