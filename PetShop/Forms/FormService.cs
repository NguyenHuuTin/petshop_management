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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
        }

        private void FormService_Load(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            List<DICHVU> newlistDV = context.DICHVUs.ToList();
            DataTable dtDV = new DataTable();
            dtDV.Columns.Add("Mã Dịch Vụ", System.Type.GetType("System.String"));
            dtDV.Columns.Add("Tên Dịch Vụ", System.Type.GetType("System.String"));
            dtDV.Columns.Add("Giá Dịch Vụ", System.Type.GetType("System.Int32"));
            int i = 0;
            while (i != newlistDV.Count)
            {
                dtDV.Rows.Add(new object[] { newlistDV[i].MADV, newlistDV[i].TEN, newlistDV[i].GIA });
                i++;
            }
            dgvDV.DataSource = dtDV;
        }

        private void dgvDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRowDV = dgvDV.Rows[e.RowIndex];
                txtMaDV.Text = dgvRowDV.Cells[0].Value.ToString();
                txtTenDV.Text = dgvRowDV.Cells[1].Value.ToString();
                txtGiaDV.Text = dgvRowDV.Cells[2].Value.ToString();
            }
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            if (txtMaDV.Text != "" || txtTenDV.Text != "" || txtGiaDV.Text != "")
            {
                String madv = addID();
                String tendv = txtTenDV.Text;
                int giadv = Convert.ToInt32(txtGiaDV.Text);
                String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
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
                        txtMaDV.Text = madv;
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không thành công");
                    }

                }

            }
            else MessageBox.Show("Bạn hãy nhập đủ thông tin!");
            FormService_Load(sender, e);
        }

        private void btnSuaDV_Click(object sender, EventArgs e)
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
            FormService_Load(sender, e);
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
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
            emptyString();
            FormService_Load(sender, e);
        }
        private String addID()
        {
            String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            String query = "select Top 1 * from DICHVU order by MADV DESC";
            SqlCommand comand = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            String id = dt.Rows[0]["MADV"].ToString();
            String strhd = id.Substring(1, id.Length - 1);
            int d = Convert.ToInt32(strhd);
            String str = "D0" + (d + 1);
            return str;

        }
        private void emptyString()
        {
            txtMaDV.Text = String.Empty;
            txtTenDV.Text = String.Empty;
            txtGiaDV.Text = String.Empty;
        }
    }
}
