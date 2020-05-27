namespace QLThuVien.Views.HeThong
{
    partial class ChangeItemQuanLySach
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
            this.tbMaSach = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btTimKiem = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbMaSach.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tbMaSach
            // 
            this.tbMaSach.Location = new System.Drawing.Point(48, 81);
            this.tbMaSach.Name = "tbMaSach";
            this.tbMaSach.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMaSach.Properties.Appearance.Options.UseFont = true;
            this.tbMaSach.Size = new System.Drawing.Size(178, 28);
            this.tbMaSach.TabIndex = 2;
            this.tbMaSach.TextChanged += new System.EventHandler(this.tbMaSach_BindingContextChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(95, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 23);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã sách : ";
            // 
            // btTimKiem
            // 
            this.btTimKiem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btTimKiem.Appearance.Options.UseFont = true;
            this.btTimKiem.Location = new System.Drawing.Point(95, 135);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(85, 30);
            this.btTimKiem.TabIndex = 8;
            this.btTimKiem.Text = "Tìm kiếm";
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // ChangeItemQuanLySach
            // 
            this.AcceptButton = this.btTimKiem;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(181)))), ((int)(((byte)(254)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 209);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.tbMaSach);
            this.Name = "ChangeItemQuanLySach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi đầu sách";
            ((System.ComponentModel.ISupportInitialize)(this.tbMaSach.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public DevExpress.XtraEditors.TextEdit tbMaSach;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btTimKiem;
    }
}