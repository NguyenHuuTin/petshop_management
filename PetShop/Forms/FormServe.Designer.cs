namespace PetShop.Forms
{
    partial class FormServe
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
            this.btnAddPV = new FontAwesome.Sharp.IconButton();
            this.btnDeletePV = new FontAwesome.Sharp.IconButton();
            this.dgvPV = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbIDNVPV = new System.Windows.Forms.ComboBox();
            this.cbbIDTCPV = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPV)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPV
            // 
            this.btnAddPV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnAddPV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAddPV.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnAddPV.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnAddPV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddPV.IconSize = 30;
            this.btnAddPV.Location = new System.Drawing.Point(478, 28);
            this.btnAddPV.Name = "btnAddPV";
            this.btnAddPV.Size = new System.Drawing.Size(90, 30);
            this.btnAddPV.TabIndex = 2;
            this.btnAddPV.UseVisualStyleBackColor = false;
            this.btnAddPV.Click += new System.EventHandler(this.btnAddPV_Click);
            // 
            // btnDeletePV
            // 
            this.btnDeletePV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.btnDeletePV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDeletePV.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeletePV.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnDeletePV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeletePV.IconSize = 30;
            this.btnDeletePV.Location = new System.Drawing.Point(250, 28);
            this.btnDeletePV.Name = "btnDeletePV";
            this.btnDeletePV.Size = new System.Drawing.Size(93, 30);
            this.btnDeletePV.TabIndex = 0;
            this.btnDeletePV.UseVisualStyleBackColor = false;
            this.btnDeletePV.Click += new System.EventHandler(this.btnDeletePV_Click);
            // 
            // dgvPV
            // 
            this.dgvPV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.dgvPV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPV.ColumnHeadersHeight = 30;
            this.dgvPV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPV.EnableHeadersVisualStyles = false;
            this.dgvPV.GridColor = System.Drawing.Color.SteelBlue;
            this.dgvPV.Location = new System.Drawing.Point(0, 0);
            this.dgvPV.Name = "dgvPV";
            this.dgvPV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPV.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPV.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPV.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPV.RowTemplate.Height = 24;
            this.dgvPV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvPV.Size = new System.Drawing.Size(762, 485);
            this.dgvPV.TabIndex = 0;
            this.dgvPV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPV_CellContentClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dgvPV);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(500, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(762, 485);
            this.panel8.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel7.Controls.Add(this.btnAddPV);
            this.panel7.Controls.Add(this.btnDeletePV);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(500, 485);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(762, 100);
            this.panel7.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(2, 3);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thú cưng";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbbIDTCPV);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 100);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(500, 50);
            this.panel5.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel5);
            this.panel6.Controls.Add(this.panel3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(0, 50, 0, 0);
            this.panel6.Size = new System.Drawing.Size(500, 200);
            this.panel6.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbbIDNVPV);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 50);
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
            // cbbIDNVPV
            // 
            this.cbbIDNVPV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbIDNVPV.FormattingEnabled = true;
            this.cbbIDNVPV.Location = new System.Drawing.Point(152, 0);
            this.cbbIDNVPV.Name = "cbbIDNVPV";
            this.cbbIDNVPV.Size = new System.Drawing.Size(300, 31);
            this.cbbIDNVPV.TabIndex = 2;
            // 
            // cbbIDTCPV
            // 
            this.cbbIDTCPV.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbIDTCPV.FormattingEnabled = true;
            this.cbbIDTCPV.Location = new System.Drawing.Point(152, 0);
            this.cbbIDTCPV.Name = "cbbIDTCPV";
            this.cbbIDTCPV.Size = new System.Drawing.Size(300, 31);
            this.cbbIDTCPV.TabIndex = 4;
            // 
            // FormServe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 585);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Name = "FormServe";
            this.Text = "Phục vụ";
            this.Load += new System.EventHandler(this.FormServe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPV)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAddPV;
        private FontAwesome.Sharp.IconButton btnDeletePV;
        private System.Windows.Forms.DataGridView dgvPV;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbIDTCPV;
        private System.Windows.Forms.ComboBox cbbIDNVPV;
    }
}