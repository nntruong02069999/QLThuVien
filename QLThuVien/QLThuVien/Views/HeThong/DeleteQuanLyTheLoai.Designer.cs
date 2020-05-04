namespace QLThuVien.Views.HeThong
{
    partial class DeleteQuanLyTheLoai
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
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbMaTheLoai = new System.Windows.Forms.ComboBox();
            this.tbTenTheLoai = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTheLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(130, 209);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(113, 41);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(113, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(130, 25);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Mã thể loại :";
            // 
            // cbMaTheLoai
            // 
            this.cbMaTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaTheLoai.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTheLoai.FormattingEnabled = true;
            this.cbMaTheLoai.ItemHeight = 22;
            this.cbMaTheLoai.Location = new System.Drawing.Point(93, 78);
            this.cbMaTheLoai.Name = "cbMaTheLoai";
            this.cbMaTheLoai.Size = new System.Drawing.Size(178, 30);
            this.cbMaTheLoai.TabIndex = 15;
            this.cbMaTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbMaTheLoai_SelectedIndexChanged);
            // 
            // tbTenTheLoai
            // 
            this.tbTenTheLoai.Location = new System.Drawing.Point(93, 142);
            this.tbTenTheLoai.Name = "tbTenTheLoai";
            this.tbTenTheLoai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTheLoai.Properties.Appearance.Options.UseFont = true;
            this.tbTenTheLoai.Properties.ReadOnly = true;
            this.tbTenTheLoai.Size = new System.Drawing.Size(178, 28);
            this.tbTenTheLoai.TabIndex = 16;
            // 
            // DeleteQuanLyTheLoai
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 294);
            this.Controls.Add(this.tbTenTheLoai);
            this.Controls.Add(this.cbMaTheLoai);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.labelControl1);
            this.Name = "DeleteQuanLyTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xóa thể loại";
            this.Load += new System.EventHandler(this.DeleteQuanLyTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTheLoai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbMaTheLoai;
        private DevExpress.XtraEditors.TextEdit tbTenTheLoai;
    }
}