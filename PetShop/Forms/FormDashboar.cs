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
    public partial class FormDashboar : Form
    {
        private String connection = @"Data Source=DESKTOP-F5QFG7D\SQLEXPRESS;Initial Catalog=NEWPETSHOP;User ID=sa; password=0369";
        SqlConnection con;
        SqlCommand comand;
        SqlDataAdapter adp;
        DataTable dt;
        String query = "";
        public FormDashboar()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormDashboar_Load(object sender, EventArgs e)
        {
            //Chart Pie
            con = new SqlConnection(connection);
            con.Open();
            query = "select MADV, SUM(T_TIEN) as 'tt' from CHITIETHD where MAHD in " +
                "(select MAHD from HOADON where YEAR(NGAYLAP) in (select YEAR(GETDATE())) and MONTH(NGAYLAP) in " +
                "(select MONTH(GETDATE()))) and MADV != 'NULL' group by MADV";
            comand = new SqlCommand(query, con);
            adp = new SqlDataAdapter(comand);
            dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            chartPie.DataSource = dt;
            chartPie.Series["DV"].XValueMember = "MADV";
            chartPie.Series["DV"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartPie.Series["DV"].YValueMembers = "tt";
            chartPie.Series["DV"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            //Chart Bar
            con = new SqlConnection(connection);
            con.Open();
            query = "select MATA, SUM(T_TIEN) as 'tt' from CHITIETHD where MAHD in " +
                "(select MAHD from HOADON where YEAR(NGAYLAP) in (select YEAR(GETDATE())) and MONTH(NGAYLAP) in " +
                "(select MONTH(GETDATE()))) and MATA != 'NULL' group by MATA order by tt DESC";
            comand = new SqlCommand(query, con);
            adp = new SqlDataAdapter(comand);
            dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            chartBar.DataSource = dt;
            chartBar.Series["TA"].XValueMember = "MATA";
            chartBar.Series["TA"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartBar.Series["TA"].YValueMembers = "tt";
            chartBar.Series["TA"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            //Chart Line

            con = new SqlConnection(connection);
            con.Open();
            query = "select A.THANG, SUM(A.TONGTIEN) as'tt' from (select MONTH(NGAYLAP) as 'THANG', TONGTIEN " +
                "from HOADON where YEAR(NGAYLAP) in (select YEAR(GETDATE()))) A " +
                "group by A.THANG order by A.THANG";
            comand = new SqlCommand(query, con);
            adp = new SqlDataAdapter(comand);
            dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            chartLine.DataSource = dt;
            chartLine.Series["TT"].XValueMember = "THANG";
            chartLine.Series["TT"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            chartLine.Series["TT"].YValueMembers = "tt";
            chartLine.Series["TT"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            //total
            con = new SqlConnection(connection);
            con.Open();
            query = "select Sum(TONGTIEN)as 'tt' from HOADON where MONTH(NGAYLAP) in (select MONTH(GETDATE()))";
            comand = new SqlCommand(query, con);
            adp = new SqlDataAdapter(comand);
            dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            String tt = dt.Rows[0]["tt"].ToString();
            txtTT.Text = tt;

            //order
            con = new SqlConnection(connection);
            con.Open();
            query = "select COUNT(*) as 'tt' from HOADON where MONTH(NGAYLAP) in (select MONTH(GETDATE()))";
            comand = new SqlCommand(query, con);
            adp = new SqlDataAdapter(comand);
            dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            String order = dt.Rows[0]["tt"].ToString();
            txtOrder.Text = order;

            //food
            con = new SqlConnection(connection);
            con.Open();
            query = "select COUNT(MATA) as 'tt' from CHITIETHD where MAHD in (select MAHD from HOADON where YEAR(NGAYLAP) in (select YEAR(GETDATE())) and MONTH(NGAYLAP) in (select MONTH(GETDATE()))) and MATA != 'NULL'";
            comand = new SqlCommand(query, con);
            adp = new SqlDataAdapter(comand);
            dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            String ta = dt.Rows[0]["tt"].ToString();
            txtfood.Text = ta;

            //service
            con = new SqlConnection(connection);
            con.Open();
            query = "select COUNT(MADV) as 'tt' from CHITIETHD where MAHD in (select MAHD from HOADON where YEAR(NGAYLAP) in (select YEAR(GETDATE())) and MONTH(NGAYLAP) in (select MONTH(GETDATE()))) and MADV != 'NULL'";
            comand = new SqlCommand(query, con);
            adp = new SqlDataAdapter(comand);
            dt = new DataTable();
            adp.Fill(dt);
            con.Close();
            String dv = dt.Rows[0]["tt"].ToString();
            txtservice.Text = dv;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chartBar_Click(object sender, EventArgs e)
        {

        }

        private void chartPie_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
