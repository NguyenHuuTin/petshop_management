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
    public partial class FormServe : Form
    {
        public FormServe()
        {
            InitializeComponent();
        }

        private void FormServe_Load(object sender, EventArgs e)
        {
            String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
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

            PetShopContextDB context = new PetShopContextDB();
            List<THUCUNG> tc = context.THUCUNGs.ToList();
            List<NHANVIEN> newListNV = context.NHANVIENs.ToList();
            cbbIDTCPV.DataSource = tc;
            cbbIDTCPV.DisplayMember = "TEN";
            cbbIDTCPV.ValueMember = "MATC";

            cbbIDNVPV.DataSource = newListNV;
            cbbIDNVPV.DisplayMember = "HO_TENNV";
            cbbIDNVPV.ValueMember = "MANV";
        }

        private void btnAddPV_Click(object sender, EventArgs e)
        {
            if (cbbIDNVPV.Text != "" && cbbIDTCPV.Text != "")
            {
                String idnv = cbbIDNVPV.SelectedValue.ToString();
                String idtc = cbbIDTCPV.SelectedValue.ToString();


                String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
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
            FormServe_Load(sender, e);
        }

        private void btnDeletePV_Click(object sender, EventArgs e)
        {
            if (cbbIDNVPV.Text != "" && cbbIDTCPV.Text != "")
            {
                String idnv = cbbIDNVPV.SelectedValue.ToString();
                String idtc = cbbIDTCPV.SelectedValue.ToString();

                String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
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
            FormServe_Load(sender, e);
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
    }
}
