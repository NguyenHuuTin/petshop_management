namespace PetShop
{
    partial class FormPetShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPetShop));
            this.lblTitleChildrenForm = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelTitlebar = new System.Windows.Forms.Panel();
            this.btnMinSize = new FontAwesome.Sharp.IconButton();
            this.btnMaxSize = new FontAwesome.Sharp.IconButton();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.iconCurentchildrenForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnServe = new FontAwesome.Sharp.IconButton();
            this.btnCLV = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnService = new FontAwesome.Sharp.IconButton();
            this.btnFood = new FontAwesome.Sharp.IconButton();
            this.btnPets = new FontAwesome.Sharp.IconButton();
            this.btnCustomers = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitlebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurentchildrenForm)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleChildrenForm
            // 
            this.lblTitleChildrenForm.AutoSize = true;
            this.lblTitleChildrenForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildrenForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildrenForm.Location = new System.Drawing.Point(42, 24);
            this.lblTitleChildrenForm.Name = "lblTitleChildrenForm";
            this.lblTitleChildrenForm.Size = new System.Drawing.Size(121, 29);
            this.lblTitleChildrenForm.TabIndex = 1;
            this.lblTitleChildrenForm.Text = "Trang chủ";
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.pictureBox2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 85);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1255, 645);
            this.panelDesktop.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1255, 645);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1255, 10);
            this.panelShadow.TabIndex = 6;
            // 
            // panelTitlebar
            // 
            this.panelTitlebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitlebar.Controls.Add(this.btnMinSize);
            this.panelTitlebar.Controls.Add(this.btnMaxSize);
            this.panelTitlebar.Controls.Add(this.btnClose);
            this.panelTitlebar.Controls.Add(this.lblTitleChildrenForm);
            this.panelTitlebar.Controls.Add(this.iconCurentchildrenForm);
            this.panelTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitlebar.Location = new System.Drawing.Point(220, 0);
            this.panelTitlebar.Name = "panelTitlebar";
            this.panelTitlebar.Size = new System.Drawing.Size(1255, 75);
            this.panelTitlebar.TabIndex = 5;
            this.panelTitlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitlebar_MouseDown);
            // 
            // btnMinSize
            // 
            this.btnMinSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMinSize.FlatAppearance.BorderSize = 0;
            this.btnMinSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinSize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinSize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinSize.IconSize = 25;
            this.btnMinSize.Location = new System.Drawing.Point(1137, -2);
            this.btnMinSize.Name = "btnMinSize";
            this.btnMinSize.Size = new System.Drawing.Size(30, 30);
            this.btnMinSize.TabIndex = 4;
            this.btnMinSize.UseVisualStyleBackColor = false;
            this.btnMinSize.Click += new System.EventHandler(this.btnMinSize_Click);
            // 
            // btnMaxSize
            // 
            this.btnMaxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaxSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnMaxSize.FlatAppearance.BorderSize = 0;
            this.btnMaxSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaxSize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaxSize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaxSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaxSize.IconSize = 25;
            this.btnMaxSize.Location = new System.Drawing.Point(1181, 0);
            this.btnMaxSize.Name = "btnMaxSize";
            this.btnMaxSize.Size = new System.Drawing.Size(30, 30);
            this.btnMaxSize.TabIndex = 3;
            this.btnMaxSize.UseVisualStyleBackColor = false;
            this.btnMaxSize.Click += new System.EventHandler(this.btnMaxSize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.Gainsboro;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 25;
            this.btnClose.Location = new System.Drawing.Point(1225, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // iconCurentchildrenForm
            // 
            this.iconCurentchildrenForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurentchildrenForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurentchildrenForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurentchildrenForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurentchildrenForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurentchildrenForm.Location = new System.Drawing.Point(6, 22);
            this.iconCurentchildrenForm.Name = "iconCurentchildrenForm";
            this.iconCurentchildrenForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurentchildrenForm.TabIndex = 0;
            this.iconCurentchildrenForm.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 140);
            this.panel1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(31, 24);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 85);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnServe);
            this.panelMenu.Controls.Add(this.btnCLV);
            this.panelMenu.Controls.Add(this.btnOrder);
            this.panelMenu.Controls.Add(this.btnService);
            this.panelMenu.Controls.Add(this.btnFood);
            this.panelMenu.Controls.Add(this.btnPets);
            this.panelMenu.Controls.Add(this.btnCustomers);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 730);
            this.panelMenu.TabIndex = 4;
            // 
            // btnServe
            // 
            this.btnServe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnServe.FlatAppearance.BorderSize = 0;
            this.btnServe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServe.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnServe.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.btnServe.IconColor = System.Drawing.Color.Gainsboro;
            this.btnServe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnServe.IconSize = 32;
            this.btnServe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServe.Location = new System.Drawing.Point(0, 500);
            this.btnServe.Name = "btnServe";
            this.btnServe.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnServe.Size = new System.Drawing.Size(220, 60);
            this.btnServe.TabIndex = 9;
            this.btnServe.Text = "Phục vụ";
            this.btnServe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnServe.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnServe.UseVisualStyleBackColor = true;
            this.btnServe.Click += new System.EventHandler(this.btnServe_Click);
            // 
            // btnCLV
            // 
            this.btnCLV.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCLV.FlatAppearance.BorderSize = 0;
            this.btnCLV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCLV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCLV.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.btnCLV.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCLV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCLV.IconSize = 32;
            this.btnCLV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCLV.Location = new System.Drawing.Point(0, 440);
            this.btnCLV.Name = "btnCLV";
            this.btnCLV.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCLV.Size = new System.Drawing.Size(220, 60);
            this.btnCLV.TabIndex = 8;
            this.btnCLV.Text = "Ca làm việc";
            this.btnCLV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCLV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCLV.UseVisualStyleBackColor = true;
            this.btnCLV.Click += new System.EventHandler(this.btnCLV_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnOrder.IconColor = System.Drawing.Color.Gainsboro;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 32;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 380);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnOrder.Size = new System.Drawing.Size(220, 60);
            this.btnOrder.TabIndex = 7;
            this.btnOrder.Text = "Hóa đơn";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnService
            // 
            this.btnService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnService.IconChar = FontAwesome.Sharp.IconChar.Servicestack;
            this.btnService.IconColor = System.Drawing.Color.Gainsboro;
            this.btnService.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnService.IconSize = 32;
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(0, 320);
            this.btnService.Name = "btnService";
            this.btnService.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnService.Size = new System.Drawing.Size(220, 60);
            this.btnService.TabIndex = 6;
            this.btnService.Text = "Dịch vụ";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.btnService_Click);
            // 
            // btnFood
            // 
            this.btnFood.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFood.FlatAppearance.BorderSize = 0;
            this.btnFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFood.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFood.IconChar = FontAwesome.Sharp.IconChar.Bone;
            this.btnFood.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFood.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFood.IconSize = 32;
            this.btnFood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.Location = new System.Drawing.Point(0, 260);
            this.btnFood.Name = "btnFood";
            this.btnFood.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFood.Size = new System.Drawing.Size(220, 60);
            this.btnFood.TabIndex = 5;
            this.btnFood.Text = "Thức ăn";
            this.btnFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFood.UseVisualStyleBackColor = true;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // btnPets
            // 
            this.btnPets.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPets.FlatAppearance.BorderSize = 0;
            this.btnPets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPets.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPets.IconChar = FontAwesome.Sharp.IconChar.Dog;
            this.btnPets.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPets.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPets.IconSize = 32;
            this.btnPets.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPets.Location = new System.Drawing.Point(0, 200);
            this.btnPets.Name = "btnPets";
            this.btnPets.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPets.Size = new System.Drawing.Size(220, 60);
            this.btnPets.TabIndex = 4;
            this.btnPets.Text = "Thú cưng";
            this.btnPets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPets.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPets.UseVisualStyleBackColor = true;
            this.btnPets.Click += new System.EventHandler(this.btnPets_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCustomers.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            this.btnCustomers.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCustomers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCustomers.IconSize = 32;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(0, 140);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCustomers.Size = new System.Drawing.Size(220, 60);
            this.btnCustomers.TabIndex = 3;
            this.btnCustomers.Text = "Khách hàng";
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = true;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // FormPetShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1475, 730);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitlebar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(1493, 777);
            this.Name = "FormPetShop";
            this.Text = "FormPetShop";
            this.Load += new System.EventHandler(this.FormPetShop_Load);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitlebar.ResumeLayout(false);
            this.panelTitlebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurentchildrenForm)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton btnCustomers;
        private System.Windows.Forms.Label lblTitleChildrenForm;
        private FontAwesome.Sharp.IconButton btnService;
        private FontAwesome.Sharp.IconButton btnFood;
        private FontAwesome.Sharp.IconButton btnPets;
        private FontAwesome.Sharp.IconButton btnMinSize;
        private FontAwesome.Sharp.IconButton btnMaxSize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnCLV;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconPictureBox iconCurentchildrenForm;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelTitlebar;
        private FontAwesome.Sharp.IconButton btnServe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
    }
}