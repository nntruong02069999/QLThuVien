namespace QLThuVien.Views.ChucNang.QuanLy
{
    partial class TraSach
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
            this.cbSachDaMuon = new System.Windows.Forms.ComboBox();
            this.btTraSach = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // cbSachDaMuon
            // 
            this.cbSachDaMuon.BackColor = System.Drawing.SystemColors.Window;
            this.cbSachDaMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSachDaMuon.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSachDaMuon.FormattingEnabled = true;
            this.cbSachDaMuon.Location = new System.Drawing.Point(138, 50);
            this.cbSachDaMuon.Name = "cbSachDaMuon";
            this.cbSachDaMuon.Size = new System.Drawing.Size(178, 25);
            this.cbSachDaMuon.TabIndex = 5;
            // 
            // btTraSach
            // 
            this.btTraSach.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraSach.Appearance.Options.UseFont = true;
            this.btTraSach.Location = new System.Drawing.Point(110, 115);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(126, 33);
            this.btTraSach.TabIndex = 6;
            this.btTraSach.Text = "Trả sách";
            this.btTraSach.Click += new System.EventHandler(this.btTraSach_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(25, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 21);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Số cá biệt : ";
            // 
            // TraSach
            // 
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 208);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.btTraSach);
            this.Controls.Add(this.cbSachDaMuon);
            this.Name = "TraSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trả sách";
            this.Load += new System.EventHandler(this.TraSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSachDaMuon;
        private DevExpress.XtraEditors.SimpleButton btTraSach;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}