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
    public partial class FormStaff : Form
    {
        public FormStaff()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteNV_MouseHover(object sender, EventArgs e)
        {
            
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
            emptyString();
            FormStaff_Load(sender, e);
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            List<NHANVIEN> newListNV = context.NHANVIENs.ToList();
            DataTable dtNV = new DataTable();
            dtNV.Columns.Add("Mã Nhân Viên", System.Type.GetType("System.String"));
            dtNV.Columns.Add("Tên Nhân Viên", System.Type.GetType("System.String"));
            dtNV.Columns.Add("Lương", System.Type.GetType("System.Int32"));
            dtNV.Columns.Add("Số Diện Thoại", System.Type.GetType("System.String"));
            int i = 0;
            while (i != newListNV.Count)
            {
                dtNV.Rows.Add(new object[] { newListNV[i].MANV, newListNV[i].HO_TENNV, newListNV[i].LUONG, newListNV[i].SDT });
                i++;
            }
            dgvNV.DataSource = dtNV;
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dgvNV.Rows[e.RowIndex];
                txtIDNV.Text = row.Cells[0].Value.ToString();
                txtNameNV.Text = row.Cells[1].Value.ToString();
                txtPhoneNV.Text = row.Cells[3].Value.ToString();
                txtSalaryNV.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnAddNV_Click(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            if (txtNameNV.Text != "" && txtSalaryNV.Text != "" && txtPhoneNV.Text != "")
            {
                string id = addID();
                string name = txtNameNV.Text;
                int salary = Convert.ToInt32(txtSalaryNV.Text);
                string phone = txtPhoneNV.Text;

                String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                String qeurycount = " INSERT INTO NHANVIEN (MANV,HO_TENNV,SDT,LUONG) VALUES ('" + id + "', N'" + name + "', '" + phone + "'," + salary + ") ";
                using (SqlConnection cnn = new SqlConnection(connectionstring))
                {
                    cnn.Open();
                    try
                    {
                        SqlCommand cm = new SqlCommand(qeurycount, cnn);
                        SqlDataAdapter adapter = new SqlDataAdapter(cm);
                        cm.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        txtIDNV.Text = id;
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }

            }
            else MessageBox.Show("Bạn hãy nhập đủ thông tin!");
            FormStaff_Load(sender, e);
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
                    int salary = Convert.ToInt32(txtSalaryNV.Text);
                    string phone = txtPhoneNV.Text;

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
            FormStaff_Load(sender, e);
        }
        private String addID()
        {
            String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            String query = "select Top 1 * from NHANVIEN order by MANV DESC";
            SqlCommand comand = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            String id = dt.Rows[0]["MANV"].ToString();
            String strhd = id.Substring(1, id.Length - 1);
            int d = Convert.ToInt32(strhd);
            String str = "N0" + (d + 1);
            return str;

        }
        private void emptyString()
        {
            txtIDNV.Text = String.Empty;
            txtNameNV.Text = String.Empty;
            txtSalaryNV.Text = String.Empty;
            txtPhoneNV.Text = String.Empty;
        }

        private void txtIDNV_Click(object sender, EventArgs e)
        {

        }
    }
}
