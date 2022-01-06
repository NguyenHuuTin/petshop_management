namespace PetShop.Forms
{
    partial class FormPet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvTC = new System.Windows.Forms.DataGridView();
            this.btnAddTC = new FontAwesome.Sharp.IconButton();
            this.btnUpdateTC = new FontAwesome.Sharp.IconButton();
            this.btnDeleteTC = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtIDTC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameTC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbbIDCN = new System.Windows.Forms.ComboBox();
            this.txtAgeTC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtGiongLoai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTC
            // 
            this.dgvTC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTC.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.dgvTC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTC.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTC.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTC.ColumnHeadersHeight = 30;
            this.dgvTC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTC.EnableHeadersVisualStyles = false;
            this.dgvTC.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvTC.Location = new System.Drawing.Point(0, 0);
            this.dgvTC.Name = "dgvTC";
            this.dgvTC.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTC.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTC.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTC.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTC.RowTemplate.Height = 24;
            this.dgvTC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTC.Size = new System.Drawing.Size(762, 585);
            this.dgvTC.TabIndex = 0;
            this.dgvTC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTC_CellContentClick);
            // 
            // btnAddTC
            // 
            this.btnAddTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnAddTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAddTC.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddTC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnAddTC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddTC.IconSize = 30;
            this.btnAddTC.Location = new System.Drawing.Point(510, 28);
            this.btnAddTC.Name = "btnAddTC";
            this.btnAddTC.Size = new System.Drawing.Size(90, 30);
            this.btnAddTC.TabIndex = 2;
            this.btnAddTC.UseVisualStyleBackColor = false;
            this.btnAddTC.Click += new System.EventHandler(this.btnAddTC_Click);
            // 
            // btnUpdateTC
            // 
            this.btnUpdateTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnUpdateTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnUpdateTC.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnUpdateTC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnUpdateTC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateTC.IconSize = 30;
            this.btnUpdateTC.Location = new System.Drawing.Point(345, 28);
            this.btnUpdateTC.Name = "btnUpdateTC";
            this.btnUpdateTC.Size = new System.Drawing.Size(90, 30);
            this.btnUpdateTC.TabIndex = 1;
            this.btnUpdateTC.UseVisualStyleBackColor = false;
            this.btnUpdateTC.Click += new System.EventHandler(this.btnUpdateTC_Click);
            // 
            // btnDeleteTC
            // 
            this.btnDeleteTC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnDeleteTC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnDeleteTC.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeleteTC.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(77)))), ((int)(((byte)(221)))));
            this.btnDeleteTC.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeleteTC.IconSize = 30;
            this.btnDeleteTC.Location = new System.Drawing.Point(174, 28);
            this.btnDeleteTC.Name = "btnDeleteTC";
            this.btnDeleteTC.Size = new System.Drawing.Size(93, 30);
            this.btnDeleteTC.TabIndex = 0;
            this.btnDeleteTC.UseVisualStyleBackColor = false;
            this.btnDeleteTC.Click += new System.EventHandler(this.btnDeleteTC_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel7.Controls.Add(this.btnAddTC);
            this.panel7.Controls.Add(this.btnUpdateTC);
            this.panel7.Controls.Add(this.btnDeleteTC);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(500, 485);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(762, 100);
            this.panel7.TabIndex = 4;
            // 
            // txtIDTC
            // 
            this.txtIDTC.AutoSize = true;
            this.txtIDTC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDTC.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtIDTC.Location = new System.Drawing.Point(148, 3);
            this.txtIDTC.Name = "txtIDTC";
            this.txtIDTC.Size = new System.Drawing.Size(0, 23);
            this.txtIDTC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(52, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtIDTC);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 50);
            this.panel4.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvTC);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(500, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(762, 585);
            this.panel8.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(68, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên";
            // 
            // txtNameTC
            // 
            this.txtNameTC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameTC.Location = new System.Drawing.Point(152, 0);
            this.txtNameTC.Name = "txtNameTC";
            this.txtNameTC.Size = new System.Drawing.Size(300, 30);
            this.txtNameTC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(116, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chủ nhân";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbIDCN);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 150);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 50);
            this.panel5.TabIndex = 11;
            // 
            // cbbIDCN
            // 
            this.cbbIDCN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbIDCN.FormattingEnabled = true;
            this.cbbIDCN.Location = new System.Drawing.Point(152, 0);
            this.cbbIDCN.Name = "cbbIDCN";
            this.cbbIDCN.Size = new System.Drawing.Size(300, 31);
            this.cbbIDCN.TabIndex = 4;
            // 
            // txtAgeTC
            // 
            this.txtAgeTC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgeTC.Location = new System.Drawing.Point(152, -3);
            this.txtAgeTC.Name = "txtAgeTC";
            this.txtAgeTC.Size = new System.Drawing.Size(300, 30);
            this.txtAgeTC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tuổi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAgeTC);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 50);
            this.panel2.TabIndex = 8;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel9);
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Controls.Add(this.panel4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panel6.Size = new System.Drawing.Size(500, 350);
            this.panel6.TabIndex = 12;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtGiongLoai);
            this.panel9.Controls.Add(this.label5);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 250);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(500, 50);
            this.panel9.TabIndex = 12;
            // 
            // txtGiongLoai
            // 
            this.txtGiongLoai.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiongLoai.Location = new System.Drawing.Point(152, -3);
            this.txtGiongLoai.Name = "txtGiongLoai";
            this.txtGiongLoai.Size = new System.Drawing.Size(300, 30);
            this.txtGiongLoai.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label5.Size = new System.Drawing.Size(123, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giống loài";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtNameTC);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 50);
            this.panel3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 585);
            this.panel1.TabIndex = 3;
            // 
            // FormPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 585);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Name = "FormPet";
            this.Text = "Thú cưng";
            this.Load += new System.EventHandler(this.FormPet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTC)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTC;
        private FontAwesome.Sharp.IconButton btnAddTC;
        private FontAwesome.Sharp.IconButton btnUpdateTC;
        private FontAwesome.Sharp.IconButton btnDeleteTC;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label txtIDTC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtAgeTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtGiongLoai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbIDCN;
    }
}