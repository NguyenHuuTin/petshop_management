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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            List<KHACHHANG> kh = context.KHACHHANGs.ToList();
            DataTable dtkh = new DataTable();
            dtkh.Columns.Add("Mã Khách Hàng", System.Type.GetType("System.String"));
            dtkh.Columns.Add("Tên Khách Hàng", System.Type.GetType("System.String"));
            dtkh.Columns.Add("Địa Chỉ", System.Type.GetType("System.String"));
            dtkh.Columns.Add("Số Diện Thoại", System.Type.GetType("System.String"));
            int i = 0;
            while (i != kh.Count)
            {
                dtkh.Rows.Add(new object[] { kh[i].MAKH, kh[i].HO_TENKH, kh[i].DCKH, kh[i].SDTKH });
                i++;
            }
            dgvKH.DataSource = dtkh;
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            if (txtNameKH.Text != "" && txtAddressKH.Text != "" && txtPhoneKH.Text != "")
            {
                string id = addID();
                string name = txtNameKH.Text;
                String address = txtAddressKH.Text;
                string phone = txtPhoneKH.Text;

                String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
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
                        txtIDKH.Text = id;
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không Thành Công");
                    }
                }

            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormCustomer_Load(sender, e);
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
                        item.HO_TENKH = newitem.HO_TENKH;
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
            FormCustomer_Load(sender, e);
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
            emptyString();
            FormCustomer_Load(sender, e);
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
        private String addID()
        {
            String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            String query = "select Top 1 * from KHACHHANG order by MAKH DESC";
            SqlCommand comand = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            String id = dt.Rows[0]["MAKH"].ToString();
            String strhd = id.Substring(1, id.Length - 1);
            int d = Convert.ToInt32(strhd);
            String str = "M0" + (d + 1);
            return str;

        }
        private void emptyString()
        {
            txtIDKH.Text = String.Empty;
            txtNameKH.Text = String.Empty;
            txtPhoneKH.Text = String.Empty;
            txtAddressKH.Text = String.Empty;
        }
    }
}
