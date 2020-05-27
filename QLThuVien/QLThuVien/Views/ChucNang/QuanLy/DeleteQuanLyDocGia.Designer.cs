namespace QLThuVien.Views.ChucNang.QuanLy
{
    partial class DeleteQuanLyDocGia
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
            this.cbNhanVienTao = new System.Windows.Forms.ComboBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.tbSDT = new DevExpress.XtraEditors.TextEdit();
            this.tbDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.tbTenDocGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbSDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenDocGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbNhanVienTao
            // 
            this.cbNhanVienTao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNhanVienTao.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbNhanVienTao.FormattingEnabled = true;
            this.cbNhanVienTao.Location = new System.Drawing.Point(281, 12);
            this.cbNhanVienTao.Name = "cbNhanVienTao";
            this.cbNhanVienTao.Size = new System.Drawing.Size(200, 25);
            this.cbNhanVienTao.TabIndex = 49;
            this.cbNhanVienTao.SelectedIndexChanged += new System.EventHandler(this.cbNhanVienTao_SelectedIndexChanged);
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Enabled = false;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(281, 250);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(200, 21);
            this.dtpNgayHetHan.TabIndex = 48;
            // 
            // tbSDT
            // 
            this.tbSDT.Enabled = false;
            this.tbSDT.Location = new System.Drawing.Point(281, 182);
            this.tbSDT.Name = "tbSDT";
            this.tbSDT.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSDT.Properties.Appearance.Options.UseFont = true;
            this.tbSDT.Size = new System.Drawing.Size(200, 28);
            this.tbSDT.TabIndex = 41;
            // 
            // tbDiaChi
            // 
            this.tbDiaChi.Enabled = false;
            this.tbDiaChi.Location = new System.Drawing.Point(281, 124);
            this.tbDiaChi.Name = "tbDiaChi";
            this.tbDiaChi.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaChi.Properties.Appearance.Options.UseFont = true;
            this.tbDiaChi.Size = new System.Drawing.Size(200, 28);
            this.tbDiaChi.TabIndex = 40;
            // 
            // tbTenDocGia
            // 
            this.tbTenDocGia.Enabled = false;
            this.tbTenDocGia.Location = new System.Drawing.Point(281, 64);
            this.tbTenDocGia.Name = "tbTenDocGia";
            this.tbTenDocGia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenDocGia.Properties.Appearance.Options.UseFont = true;
            this.tbTenDocGia.Size = new System.Drawing.Size(200, 28);
            this.tbTenDocGia.TabIndex = 39;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(89, 250);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(115, 18);
            this.labelControl7.TabIndex = 42;
            this.labelControl7.Text = "Ngày hết hạn  : ";
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(228, 323);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(121, 40);
            this.btXoa.TabIndex = 47;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(90, 187);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(44, 18);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "SĐT : ";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(89, 129);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 18);
            this.labelControl3.TabIndex = 44;
            this.labelControl3.Text = "Địa chỉ : ";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(90, 69);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 18);
            this.labelControl2.TabIndex = 45;
            this.labelControl2.Text = "Tên độc giả : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(90, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 46;
            this.labelControl1.Text = "Số thẻ : ";
            // 
            // DeleteQuanLyDocGia
            // 
            this.Appearance.BackColor = System.Drawing.Color.Bisque;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 400);
            this.Controls.Add(this.cbNhanVienTao);
            this.Controls.Add(this.dtpNgayHetHan);
            this.Controls.Add(this.tbSDT);
            this.Controls.Add(this.tbDiaChi);
            this.Controls.Add(this.tbTenDocGia);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "DeleteQuanLyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa độc giả";
            this.Load += new System.EventHandler(this.DeleteQuanLyDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbSDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenDocGia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNhanVienTao;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private DevExpress.XtraEditors.TextEdit tbSDT;
        private DevExpress.XtraEditors.TextEdit tbDiaChi;
        private DevExpress.XtraEditors.TextEdit tbTenDocGia;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}