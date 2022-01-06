using Microsoft.Reporting.WinForms;
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
    public partial class ReportHoaDon : Form
    {
        public static String Sohd = String.Empty;
        public ReportHoaDon()
        {
            InitializeComponent();
        }


        private void ReportHoaDon_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Sohd))
            {
                PetShopContextDB context = new PetShopContextDB();
                String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
                SqlConnection con = new SqlConnection(connection);
                con.Open();
                String query = "select * from HOADON where MAHD = '"+ Sohd + "'";
                SqlCommand comand = new SqlCommand(query, con);
                SqlDataAdapter adp = new SqlDataAdapter(comand);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                //dataGridView1.DataSource = dt; 
                con.Close();
                String d = Convert.ToString(dt.Rows[0]["MAHD"].ToString());
                HOADON hd = context.HOADONs.FirstOrDefault(p => p.MAHD == d);
                List<CHITIETHD> listCTHD = context.CHITIETHDs.Where(p => p.MAHD == d).ToList();
                List<CTHD> cthd = new List<CTHD>();
                for (int i = 0; i < listCTHD.Count; i++)
                {
                    if (listCTHD[i].MADV != null)
                    {
                        SqlConnection con3 = new SqlConnection(connection);
                        con3.Open();
                        String searchTenta = "select * from DICHVU where MADV = '" + listCTHD[i].MADV + "'";
                        SqlCommand com3 = new SqlCommand(searchTenta, con3);
                        SqlDataAdapter adap3 = new SqlDataAdapter(com3);
                        DataTable dt3 = new DataTable();
                        adap3.Fill(dt3);
                        String tendv = Convert.ToString(dt3.Rows[0]["TEN"].ToString());
                        CTHD newitem = new CTHD(tendv, Convert.ToString(listCTHD[i].SOLUONG), Convert.ToString(listCTHD[i].DONGIA), Convert.ToString(listCTHD[i].T_TIEN));
                        cthd.Add(newitem);
                    }
                    if (listCTHD[i].MATA != null)
                    {
                        SqlConnection con2 = new SqlConnection(connection);
                        con2.Open();
                        String searchTenta = "select * from THUCAN where MATA = '" + listCTHD[i].MATA + "'";
                        SqlCommand com2 = new SqlCommand(searchTenta, con2);
                        SqlDataAdapter adap2 = new SqlDataAdapter(com2);
                        DataTable dt2 = new DataTable();
                        adap2.Fill(dt2);
                        String tenta = Convert.ToString(dt2.Rows[0]["TEN"].ToString());
                        CTHD newitem = new CTHD(tenta, Convert.ToString(listCTHD[i].SOLUONG), Convert.ToString(listCTHD[i].DONGIA), Convert.ToString(listCTHD[i].T_TIEN));
                        cthd.Add(newitem);
                    }

                }
                String kh = Convert.ToString(dt.Rows[0]["MAKH"].ToString());
                String nv = Convert.ToString(dt.Rows[0]["MANV"].ToString());
                String ngaylap = Convert.ToString(dt.Rows[0]["NGAYLAP"].ToString());
                String tongtien = Convert.ToString(dt.Rows[0]["TONGTIEN"].ToString());
                ReportParameter[] param = new ReportParameter[5];
                param[0] = new ReportParameter("SOHD", d);
                param[1] = new ReportParameter("MAKH", kh);
                param[2] = new ReportParameter("MANV", nv);
                param[3] = new ReportParameter("NGAYLAP", ngaylap);
                param[4] = new ReportParameter("TONGTIEN", tongtien);

                this.rpvHoaDon.LocalReport.ReportPath = "demo.rdlc";
                this.rpvHoaDon.LocalReport.SetParameters(param);

                ReportDataSource rds = new ReportDataSource("DataSetCTHD", cthd);
                this.rpvHoaDon.LocalReport.DataSources.Clear();
                this.rpvHoaDon.LocalReport.DataSources.Add(rds);
                this.rpvHoaDon.RefreshReport();
            }


            
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
