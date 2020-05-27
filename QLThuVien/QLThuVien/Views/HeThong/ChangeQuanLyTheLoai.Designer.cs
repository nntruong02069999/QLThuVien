namespace QLThuVien.Views.HeThong
{
    partial class ChangeQuanLyTheLoai
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
            this.tbTenTheLoai = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbMaTheLoai = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTheLoai.Properties)).BeginInit();
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
            // tbTenTheLoai
            // 
            this.tbTenTheLoai.Location = new System.Drawing.Point(223, 112);
            this.tbTenTheLoai.Name = "tbTenTheLoai";
            this.tbTenTheLoai.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTenTheLoai.Properties.Appearance.Options.UseFont = true;
            this.tbTenTheLoai.Size = new System.Drawing.Size(178, 28);
            this.tbTenTheLoai.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(67, 117);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(72, 18);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "Thể loại : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(67, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 18);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Mã thể loại : ";
            // 
            // cbMaTheLoai
            // 
            this.cbMaTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaTheLoai.Font = new System.Drawing.Font("Times New Roman", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaTheLoai.FormattingEnabled = true;
            this.cbMaTheLoai.ItemHeight = 19;
            this.cbMaTheLoai.Location = new System.Drawing.Point(223, 48);
            this.cbMaTheLoai.Name = "cbMaTheLoai";
            this.cbMaTheLoai.Size = new System.Drawing.Size(178, 27);
            this.cbMaTheLoai.TabIndex = 14;
            this.cbMaTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbMaTheLoai_SelectedIndexChanged);
            // 
            // ChangeQuanLyTheLoai
            // 
            this.AcceptButton = this.btLuu;
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 272);
            this.Controls.Add(this.cbMaTheLoai);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbTenTheLoai);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "ChangeQuanLyTheLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thay đổi thể loại";
            this.Load += new System.EventHandler(this.ChangeQuanLyTheLoai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbTenTheLoai.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btLuu;
        private DevExpress.XtraEditors.TextEdit tbTenTheLoai;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbMaTheLoai;
    }
}