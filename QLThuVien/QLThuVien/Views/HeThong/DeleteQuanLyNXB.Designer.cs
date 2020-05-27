namespace QLThuVien.Views.HeThong
{
    partial class DeleteQuanLyNXB
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
            this.tbTenNXB = new DevExpress.XtraEditors.TextEdit();
            this.cbMaNXB = new System.Windows.Forms.ComboBox();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNXB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenNXB
            // 
            this.tbTenNXB.Location = new System.Drawing.Point(92, 152);
            this.tbTenNXB.Name = "tbTenNXB";
            this.tbTenNXB.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNXB.Properties.Appearance.Options.UseFont = true;
            this.tbTenNXB.Properties.ReadOnly = true;
            this.tbTenNXB.Size = new System.Drawing.Size(178, 28);
            this.tbTenNXB.TabIndex = 20;
            // 
            // cbMaNXB
            // 
            this.cbMaNXB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaNXB.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaNXB.FormattingEnabled = true;
            this.cbMaNXB.ItemHeight = 22;
            this.cbMaNXB.Location = new System.Drawing.Point(92, 88);
            this.cbMaNXB.Name = "cbMaNXB";
            this.cbMaNXB.Size = new System.Drawing.Size(178, 30);
            this.cbMaNXB.TabIndex = 19;
            this.cbMaNXB.SelectedIndexChanged += new System.EventHandler(this.cbMaNXB_SelectedIndexChanged);
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(129, 219);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(113, 41);
            this.btXoa.TabIndex = 18;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(112, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(155, 25);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Nhà xuất bản :";
            // 
            // DeleteQuanLyNXB
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 294);
            this.Controls.Add(this.tbTenNXB);
            this.Controls.Add(this.cbMaNXB);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.labelControl1);
            this.Name = "DeleteQuanLyNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa nhà xuất bản";
            this.Load += new System.EventHandler(this.DeleteQuanLyNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNXB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbTenNXB;
        private System.Windows.Forms.ComboBox cbMaNXB;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}