namespace QLThuVien.Views.ChucNang.ThongKe
{
    partial class ThongKeDocGiaDangMuon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbDocGia = new DevExpress.XtraEditors.GroupControl();
            this.rpLapPhieuMuon = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.gbDocGia)).BeginInit();
            this.gbDocGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDocGia
            // 
            this.gbDocGia.Controls.Add(this.rpLapPhieuMuon);
            this.gbDocGia.Location = new System.Drawing.Point(253, 27);
            this.gbDocGia.Name = "gbDocGia";
            this.gbDocGia.Size = new System.Drawing.Size(768, 497);
            this.gbDocGia.TabIndex = 4;
            this.gbDocGia.Text = "Thống kê độc giả đang mượn";
            // 
            // rpLapPhieuMuon
            // 
            this.rpLapPhieuMuon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpLapPhieuMuon.LocalReport.ReportEmbeddedResource = "QLThuVien.Views.ChucNang.ThongKe.fmtThongKeDocGiaDangMuon.rdlc";
            this.rpLapPhieuMuon.Location = new System.Drawing.Point(2, 23);
            this.rpLapPhieuMuon.Name = "rpLapPhieuMuon";
            this.rpLapPhieuMuon.ServerReport.BearerToken = null;
            this.rpLapPhieuMuon.Size = new System.Drawing.Size(764, 472);
            this.rpLapPhieuMuon.TabIndex = 1;
            // 
            // ThongKeDocGiaDangMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDocGia);
            this.Name = "ThongKeDocGiaDangMuon";
            this.Size = new System.Drawing.Size(1274, 551);
            this.Load += new System.EventHandler(this.ThongKeDocGiaDangMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbDocGia)).EndInit();
            this.gbDocGia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbDocGia;
        private Microsoft.Reporting.WinForms.ReportViewer rpLapPhieuMuon;
    }
}
