namespace QLThuVien.Views.HeThong
{
    partial class AddItemQuanLyTheLoai
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
            this.tbTenTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.tbMaTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTheLoai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaTheLoai.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenTheLoai
            // 
            this.tbTenTheLoai.Location = new System.Drawing.Point(231, 111);
            this.tbTenTheLoai.Name = "tbTenTheLoai";
            this.tbTenTheLoai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTheLoai.Properties.Appearance.Options.UseFont = true;
            this.tbTenTheLoai.Size = new System.Drawing.Size(178, 28);
            this.tbTenTheLoai.TabIndex = 2;
            // 
            // tbMaTheLoai
            // 
            this.tbMaTheLoai.Location = new System.Drawing.Point(231, 44);
            this.tbMaTheLoai.Name = "tbMaTheLoai";
            this.tbMaTheLoai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaTheLoai.Properties.Appearance.Options.UseFont = true;
            this.tbMaTheLoai.Size = new System.Drawing.Size(178, 28);
            this.tbMaTheLoai.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(75, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Thể loại : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(75, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 18);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Mã thể loại : ";
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(172, 186);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(121, 40);
            this.btLuu.TabIndex = 8;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // AddItemQuanLyTheLoai
            // 
            this.AcceptButton = this.btLuu;
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 272);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbTenTheLoai);
            this.Controls.Add(this.tbMaTheLoai);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "AddItemQuanLyTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm thể loại";
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTheLoai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaTheLoai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit tbTenTheLoai;
        private DevExpress.XtraEditors.TextEdit tbMaTheLoai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btLuu;
    }
}