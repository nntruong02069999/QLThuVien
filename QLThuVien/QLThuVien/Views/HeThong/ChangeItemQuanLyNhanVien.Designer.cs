namespace QLThuVien.Views.HeThong
{
    partial class ChangeItemQuanLyNhanVien
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
            this.cbMaNhanVien = new System.Windows.Forms.ComboBox();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.tbTenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNhanVien.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaNhanVien
            // 
            this.cbMaNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNhanVien.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNhanVien.FormattingEnabled = true;
            this.cbMaNhanVien.ItemHeight = 24;
            this.cbMaNhanVien.Location = new System.Drawing.Point(260, 58);
            this.cbMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbMaNhanVien.Name = "cbMaNhanVien";
            this.cbMaNhanVien.Size = new System.Drawing.Size(207, 32);
            this.cbMaNhanVien.TabIndex = 24;
            this.cbMaNhanVien.SelectedIndexChanged += new System.EventHandler(this.cbMaNhanVien_SelectedIndexChanged);
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(191, 229);
            this.btLuu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(141, 49);
            this.btLuu.TabIndex = 23;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tbTenNhanVien
            // 
            this.tbTenNhanVien.Location = new System.Drawing.Point(260, 137);
            this.tbTenNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbTenNhanVien.Name = "tbTenNhanVien";
            this.tbTenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.tbTenNhanVien.Size = new System.Drawing.Size(208, 28);
            this.tbTenNhanVien.TabIndex = 20;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(78, 143);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(115, 23);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "Nhân viên : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(78, 58);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(146, 23);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Mã nhân viên : ";
            // 
            // ChangeItemQuanLyNhanVien
            // 
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 335);
            this.Controls.Add(this.cbMaNhanVien);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbTenNhanVien);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChangeItemQuanLyNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi nhân viên";
            this.Load += new System.EventHandler(this.ChangeItemQuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNhanVien.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaNhanVien;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.TextEdit tbTenNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}