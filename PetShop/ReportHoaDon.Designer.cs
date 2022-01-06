namespace PetShop
{
    partial class ReportHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.rpvHoaDon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.CTHDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvHoaDon
            // 
            this.rpvHoaDon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvHoaDon.LocalReport.ReportEmbeddedResource = "PetShop.demo.rdlc";
            this.rpvHoaDon.Location = new System.Drawing.Point(0, 0);
            this.rpvHoaDon.Name = "rpvHoaDon";
            this.rpvHoaDon.ServerReport.BearerToken = null;
            this.rpvHoaDon.Size = new System.Drawing.Size(797, 886);
            this.rpvHoaDon.TabIndex = 0;
            this.rpvHoaDon.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // CTHDBindingSource
            // 
            this.CTHDBindingSource.DataSource = typeof(PetShop.CTHD);
            // 
            // HDBindingSource
            // 
            this.HDBindingSource.DataSource = typeof(PetShop.HD);
            // 
            // ReportHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 886);
            this.Controls.Add(this.rpvHoaDon);
            this.Name = "ReportHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn";
            this.Load += new System.EventHandler(this.ReportHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CTHDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HDBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource HDBindingSource;
        private System.Windows.Forms.BindingSource CTHDBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer rpvHoaDon;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}