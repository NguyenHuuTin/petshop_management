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
    public partial class FormServerPetShop : Form
    {
        public FormServerPetShop()
        {
            InitializeComponent();
        }

        private void FormServerPetShop_Load(object sender, EventArgs e)
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
