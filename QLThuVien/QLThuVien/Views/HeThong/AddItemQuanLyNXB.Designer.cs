namespace QLThuVien.Views.HeThong
{
    partial class AddItemQuanLyNXB
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
            this.tbTenNXB = new DevExpress.XtraEditors.TextEdit();
            this.tbMaNXB = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNXB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaNXB.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(164, 187);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(121, 40);
            this.btLuu.TabIndex = 13;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tbTenNXB
            // 
            this.tbTenNXB.Location = new System.Drawing.Point(223, 112);
            this.tbTenNXB.Name = "tbTenNXB";
            this.tbTenNXB.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenNXB.Properties.Appearance.Options.UseFont = true;
            this.tbTenNXB.Size = new System.Drawing.Size(178, 28);
            this.tbTenNXB.TabIndex = 10;
            // 
            // tbMaNXB
            // 
            this.tbMaNXB.Location = new System.Drawing.Point(223, 45);
            this.tbMaNXB.Name = "tbMaNXB";
            this.tbMaNXB.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaNXB.Properties.Appearance.Options.UseFont = true;
            this.tbMaNXB.Size = new System.Drawing.Size(178, 28);
            this.tbMaNXB.TabIndex = 9;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(111, 18);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Nhà xuất bản : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 18);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Mã NXB : ";
            // 
            // AddItemQuanLyNXB
            // 
            this.AcceptButton = this.btLuu;
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 272);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbTenNXB);
            this.Controls.Add(this.tbMaNXB);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "AddItemQuanLyNXB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhà xuất bản";
            ((System.ComponentModel.ISupportInitialize)(this.tbTenNXB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaNXB.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.TextEdit tbTenNXB;
        private DevExpress.XtraEditors.TextEdit tbMaNXB;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}