namespace QLThuVien.Views.HeThong
{
    partial class ChangeItemQuanLyTacGia
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
            this.cbMaTacGia = new System.Windows.Forms.ComboBox();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.tbTenTacGia = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTacGia.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMaTacGia
            // 
            this.cbMaTacGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaTacGia.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTacGia.FormattingEnabled = true;
            this.cbMaTacGia.ItemHeight = 19;
            this.cbMaTacGia.Location = new System.Drawing.Point(223, 47);
            this.cbMaTacGia.Name = "cbMaTacGia";
            this.cbMaTacGia.Size = new System.Drawing.Size(178, 27);
            this.cbMaTacGia.TabIndex = 19;
            this.cbMaTacGia.SelectedIndexChanged += new System.EventHandler(this.cbMaTacGia_SelectedIndexChanged);
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(164, 186);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(121, 40);
            this.btLuu.TabIndex = 18;
            this.btLuu.Text = "Lưu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // tbTenTacGia
            // 
            this.tbTenTacGia.Location = new System.Drawing.Point(223, 111);
            this.tbTenTacGia.Name = "tbTenTacGia";
            this.tbTenTacGia.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTacGia.Properties.Appearance.Options.UseFont = true;
            this.tbTenTacGia.Size = new System.Drawing.Size(178, 28);
            this.tbTenTacGia.TabIndex = 15;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 116);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(66, 18);
            this.labelControl2.TabIndex = 16;
            this.labelControl2.Text = "Tác giả : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 47);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(89, 18);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Mã tác giả : ";
            // 
            // ChangeItemQuanLyTacGia
            // 
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 272);
            this.Controls.Add(this.cbMaTacGia);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbTenTacGia);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ChangeItemQuanLyTacGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi tác giả";
            this.Load += new System.EventHandler(this.ChangeItemQuanLyTacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTacGia.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaTacGia;
        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.TextEdit tbTenTacGia;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}