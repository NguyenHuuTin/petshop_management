namespace PetShop
{
    partial class frmHoadon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvChiTietDonHang = new System.Windows.Forms.DataGridView();
            this.colDVandTA = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSOHD = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtpngaylap = new System.Windows.Forms.DateTimePicker();
            this.cbbMANV = new System.Windows.Forms.ComboBox();
            this.cbbMAKH = new System.Windows.Forms.ComboBox();
            this.btnInHD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvChiTietDonHang);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 373);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Đơn Hàng";
            // 
            // dgvChiTietDonHang
            // 
            this.dgvChiTietDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietDonHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDVandTA,
            this.colSoLuong,
            this.colDonGia,
            this.colThanhTien});
            this.dgvChiTietDonHang.Location = new System.Drawing.Point(17, 26);
            this.dgvChiTietDonHang.Name = "dgvChiTietDonHang";
            this.dgvChiTietDonHang.RowHeadersWidth = 51;
            this.dgvChiTietDonHang.RowTemplate.Height = 24;
            this.dgvChiTietDonHang.Size = new System.Drawing.Size(1045, 352);
            this.dgvChiTietDonHang.TabIndex = 0;
            this.dgvChiTietDonHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDonHang_CellClick);
            this.dgvChiTietDonHang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTietDonHang_CellValueChanged);
            // 
            // colDVandTA
            // 
            this.colDVandTA.HeaderText = "Dịch Vụ và Thức Ăn";
            this.colDVandTA.MinimumWidth = 6;
            this.colDVandTA.Name = "colDVandTA";
            this.colDVandTA.Width = 300;
            // 
            // colSoLuong
            // 
            this.colSoLuong.HeaderText = "Số Lượng";
            this.colSoLuong.MinimumWidth = 6;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colSoLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSoLuong.Width = 125;
            // 
            // colDonGia
            // 
            this.colDonGia.HeaderText = "Đơn Giá";
            this.colDonGia.MinimumWidth = 6;
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colDonGia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDonGia.Width = 150;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành Tiền";
            this.colThanhTien.MinimumWidth = 6;
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colThanhTien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colThanhTien.Width = 157;
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.Color.Aqua;
            this.btnThemHD.Location = new System.Drawing.Point(25, 12);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(78, 32);
            this.btnThemHD.TabIndex = 14;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SOHD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(567, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "NGÀY LẬP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(567, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "TỔNG TIỀN";
            // 
            // txtSOHD
            // 
            this.txtSOHD.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOHD.Location = new System.Drawing.Point(114, 32);
            this.txtSOHD.Name = "txtSOHD";
            this.txtSOHD.Size = new System.Drawing.Size(257, 27);
            this.txtSOHD.TabIndex = 6;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(676, 131);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(359, 30);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // dtpngaylap
            // 
            this.dtpngaylap.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpngaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngaylap.Location = new System.Drawing.Point(675, 29);
            this.dtpngaylap.Name = "dtpngaylap";
            this.dtpngaylap.Size = new System.Drawing.Size(360, 27);
            this.dtpngaylap.TabIndex = 9;
            // 
            // cbbMANV
            // 
            this.cbbMANV.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMANV.FormattingEnabled = true;
            this.cbbMANV.Location = new System.Drawing.Point(114, 79);
            this.cbbMANV.Name = "cbbMANV";
            this.cbbMANV.Size = new System.Drawing.Size(257, 30);
            this.cbbMANV.TabIndex = 10;
            // 
            // cbbMAKH
            // 
            this.cbbMAKH.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMAKH.FormattingEnabled = true;
            this.cbbMAKH.Location = new System.Drawing.Point(114, 133);
            this.cbbMAKH.Name = "cbbMAKH";
            this.cbbMAKH.Size = new System.Drawing.Size(257, 30);
            this.cbbMAKH.TabIndex = 11;
            // 
            // btnInHD
            // 
            this.btnInHD.BackColor = System.Drawing.Color.Aqua;
            this.btnInHD.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Location = new System.Drawing.Point(916, 195);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(119, 32);
            this.btnInHD.TabIndex = 12;
            this.btnInHD.Text = "Xuất Hóa Đơn";
            this.btnInHD.UseVisualStyleBackColor = false;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnInHD);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cbbMAKH);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbMANV);
            this.groupBox2.Controls.Add(this.txtSOHD);
            this.groupBox2.Controls.Add(this.dtpngaylap);
            this.groupBox2.Controls.Add(this.txtTongTien);
            this.groupBox2.Location = new System.Drawing.Point(25, 50);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1077, 236);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tinđơn Hàng";
            // 
            // frmHoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1123, 680);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoadon";
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoadon_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietDonHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvChiTietDonHang;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSOHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.DateTimePicker dtpngaylap;
        private System.Windows.Forms.ComboBox cbbMANV;
        private System.Windows.Forms.ComboBox cbbMAKH;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewComboBoxColumn colDVandTA;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}