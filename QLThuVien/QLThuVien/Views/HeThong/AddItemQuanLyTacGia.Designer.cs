namespace QLThuVien.Views.HeThong
{
    partial class AddItemQuanLyTacGia
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
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.tbTenTacGia = new DevExpress.XtraEditors.TextEdit();
            this.tbMaTacGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTacGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaTacGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(164, 187);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(121, 40);
            this.btLuu.TabIndex = 18;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tbTenTacGia
            // 
            this.tbTenTacGia.Location = new System.Drawing.Point(223, 112);
            this.tbTenTacGia.Name = "tbTenTacGia";
            this.tbTenTacGia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTacGia.Properties.Appearance.Options.UseFont = true;
            this.tbTenTacGia.Size = new System.Drawing.Size(178, 28);
            this.tbTenTacGia.TabIndex = 15;
            // 
            // tbMaTacGia
            // 
            this.tbMaTacGia.Location = new System.Drawing.Point(223, 45);
            this.tbMaTacGia.Name = "tbMaTacGia";
            this.tbMaTacGia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaTacGia.Properties.Appearance.Options.UseFont = true;
            this.tbMaTacGia.Size = new System.Drawing.Size(178, 28);
            this.tbMaTacGia.TabIndex = 14;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(94, 18);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Tên tác giả : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 18);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Mã tác giả : ";
            // 
            // AddItemQuanLyTacGia
            // 
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 272);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbTenTacGia);
            this.Controls.Add(this.tbMaTacGia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "AddItemQuanLyTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm tác giả";
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTacGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaTacGia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.TextEdit tbTenTacGia;
        private DevExpress.XtraEditors.TextEdit tbMaTacGia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}