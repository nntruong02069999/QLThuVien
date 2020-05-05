namespace QLThuVien.Views.HeThong
{
    partial class DeleteQuanLyNhanVien
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
            this.tbTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNhanVien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.Location = new System.Drawing.Point(107, 187);
            this.tbTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.tbTenNhanVien.Properties.ReadOnly = true;
            this.tbTenNhanVien.Size = new System.Drawing.Size(208, 34);
            this.tbTenNhanVien.TabIndex = 24;
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.ItemHeight = 26;
            this.cbMaNhanVien.Location = new System.Drawing.Point(107, 108);
            this.cbMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(207, 34);
            this.cbMaNhanVien.TabIndex = 23;
            this.cbMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbMaNhanVien_SelectedIndexChanged);
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(150, 270);
            this.btXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(132, 50);
            this.btXoa.TabIndex = 22;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(131, 42);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(166, 31);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "Nhân viên :  ";
            // 
            // DeleteQuanLyNhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 362);
            this.Controls.Add(this.tbTenNhanVien);
            this.Controls.Add(this.cbMaNhanVien);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeleteQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa nhân viên";
            this.Load += new System.EventHandler(this.DeleteQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNhanVien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbTenNhanVien;
        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}