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
    public partial class FormPet : Form
    {
        public FormPet()
        {
            InitializeComponent();
        }

        private void FormPet_Load(object sender, EventArgs e)
        {
            PetShopContextDB context = new PetShopContextDB();
            List<THUCUNG> tc = context.THUCUNGs.ToList();
            DataTable dttc = new DataTable();
            dttc.Columns.Add("Mã Thú Cưng", System.Type.GetType("System.String"));
            dttc.Columns.Add("Mã Chủ Nhân", System.Type.GetType("System.String"));
            dttc.Columns.Add("Tên Thú Cưng", System.Type.GetType("System.String"));
            dttc.Columns.Add("Tuổi Thú Cưng ", System.Type.GetType("System.Int32"));
            dttc.Columns.Add("Giống Loài", System.Type.GetType("System.String"));
            int i = 0;
            while (i != tc.Count)
            {
                dttc.Rows.Add(new object[] { tc[i].MATC, tc[i].MACN, tc[i].TEN, tc[i].TUOI, tc[i].GIONG });
                i++;
            }
            dgvTC.DataSource = dttc;

            // combobox
            List<KHACHHANG> kh = context.KHACHHANGs.ToList();
            cbbIDCN.DataSource = kh;
            cbbIDCN.DisplayMember = "HO_TENKH";
            cbbIDCN.ValueMember = "MAKH";
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

        private void btnAddTC_Click(object sender, EventArgs e)
        {
            if (cbbIDCN.Text != "" && txtNameTC.Text != "" && txtAgeTC.Text != "" && txtGiongLoai.Text != "")
            {
                String idtc = addID();
                String idcn = cbbIDCN.SelectedValue.ToString();
                String name = txtNameTC.Text;
                int age = Convert.ToInt32(txtAgeTC.Text);
                String giong = txtGiongLoai.Text;

                String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
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
                        txtIDTC.Text = idtc;
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không Thành Công");
                    }
                }

            }
            else MessageBox.Show("Bạn Hãy Nhập Đủ Thông Tin!");
            FormPet_Load(sender, e);
            
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

                String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
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
            FormPet_Load(sender, e);
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
            emptyString();
            FormPet_Load(sender, e);
        }
        private String addID()
        {
            String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            String query = "select Top 1 * from THUCUNG order by MATC DESC";
            SqlCommand comand = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            String id = dt.Rows[0]["MATC"].ToString();
            String strhd = id.Substring(1, id.Length - 1);
            int d = Convert.ToInt32(strhd);
            String str = "T0" + (d + 1);
            return str;

        }
        private void emptyString()
        {
            txtIDTC.Text = String.Empty;
            txtNameTC.Text = String.Empty;
            txtGiongLoai.Text = String.Empty;
            txtAgeTC.Text = String.Empty;
            cbbIDCN.Text = String.Empty;
        }
    }
}
