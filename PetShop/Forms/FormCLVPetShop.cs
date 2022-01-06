using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetShop.Forms
{
    public partial class FormCLVPetShop : Form
    {
        public FormCLVPetShop()
        {
            InitializeComponent();
        }

        private void FormCLVPetShop_Load(object sender, EventArgs e)
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
    }
}
