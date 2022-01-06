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
    public partial class FormFood : Form
    {
        public FormFood()
        {
            InitializeComponent();
        }

        private void FormFood_Load(object sender, EventArgs e)
        {
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
        }

        private void dgvTA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dgvRowTA = dgvTA.Rows[e.RowIndex];
                txtMaTA.Text = dgvRowTA.Cells[0].Value.ToString();
                txtTenTA.Text = dgvRowTA.Cells[1].Value.ToString();
                txtGiaTA.Text = dgvRowTA.Cells[2].Value.ToString();
            }
        }

        private void btnThemTA_Click(object sender, EventArgs e)
        {
            if (txtMaTA.Text != "" || txtTenTA.Text != "" || txtGiaTA.Text != "")
            {
                String mata = addID();
                String tenta = txtTenTA.Text;
                int giata = Convert.ToInt32(txtGiaTA.Text);
                String connectionstring = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
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
                        txtMaTA.Text = mata;
                        cnn.Close();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
            }
            else MessageBox.Show("Bạn hãy nhập đủ thông tin!");
            FormFood_Load(sender, e);
        }

        private void btnSuaTA_Click(object sender, EventArgs e)
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
            FormFood_Load(sender, e);
        }

        private void btnXoaTA_Click(object sender, EventArgs e)
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
            emptyString();
            FormFood_Load(sender, e);
        }
        private String addID()
        {
            String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            String query = "select Top 1 * from THUCAN order by MATA DESC";
            SqlCommand comand = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(comand);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            String id = dt.Rows[0]["MATA"].ToString();
            String strhd = id.Substring(1, id.Length - 1);
            int d = Convert.ToInt32(strhd);
            String str = "F0" + (d + 1);
            return str;

        }
        private void emptyString()
        {
            txtMaTA.Text = String.Empty;
            txtTenTA.Text = String.Empty;
            txtGiaTA.Text = String.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
