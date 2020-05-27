namespace QLThuVien.Views.ChucNang.QuanLy
{
    partial class LapPhieuMuon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btLuu = new DevExpress.XtraEditors.SimpleButton();
            this.tbIdPhieuMuon = new DevExpress.XtraEditors.TextEdit();
            this.tbSoThe = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dtNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.dgvShowSach = new System.Windows.Forms.DataGridView();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cbSachTrongKho = new System.Windows.Forms.ComboBox();
            this.btHoanThanh = new DevExpress.XtraEditors.SimpleButton();
            this.btAdd = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbIdPhieuMuon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoThe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btLuu
            // 
            this.btLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btLuu.Appearance.Options.UseFont = true;
            this.btLuu.Location = new System.Drawing.Point(243, 170);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(121, 40);
            this.btLuu.TabIndex = 23;
            this.btLuu.Text = "Lập phiếu";
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click_1);
            // 
            // tbIdPhieuMuon
            // 
            this.tbIdPhieuMuon.Location = new System.Drawing.Point(295, 66);
            this.tbIdPhieuMuon.Name = "tbIdPhieuMuon";
            this.tbIdPhieuMuon.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdPhieuMuon.Properties.Appearance.Options.UseFont = true;
            this.tbIdPhieuMuon.Size = new System.Drawing.Size(203, 28);
            this.tbIdPhieuMuon.TabIndex = 20;
            // 
            // tbSoThe
            // 
            this.tbSoThe.Location = new System.Drawing.Point(295, 16);
            this.tbSoThe.Name = "tbSoThe";
            this.tbSoThe.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSoThe.Properties.Appearance.Options.UseFont = true;
            this.tbSoThe.Properties.ReadOnly = true;
            this.tbSoThe.Size = new System.Drawing.Size(203, 28);
            this.tbSoThe.TabIndex = 19;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(110, 71);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(122, 18);
            this.labelControl2.TabIndex = 21;
            this.labelControl2.Text = "ID Phiếu mượn : ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(110, 19);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 18);
            this.labelControl1.TabIndex = 22;
            this.labelControl1.Text = "Số thẻ : ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(110, 123);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(97, 18);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Ngày mượn : ";
            // 
            // dtNgayMuon
            // 
            this.dtNgayMuon.CalendarFont = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtNgayMuon.Location = new System.Drawing.Point(295, 123);
            this.dtNgayMuon.Name = "dtNgayMuon";
            this.dtNgayMuon.Size = new System.Drawing.Size(203, 21);
            this.dtNgayMuon.TabIndex = 28;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(110, 264);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(73, 18);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "Mã sách : ";
            // 
            // cbMaSach
            // 
            this.cbMaSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaSach.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(295, 258);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(203, 24);
            this.cbMaSach.TabIndex = 30;
            this.cbMaSach.SelectedIndexChanged += new System.EventHandler(this.cbMaSach_SelectedIndexChanged);
            // 
            // dgvShowSach
            // 
            this.dgvShowSach.AllowUserToAddRows = false;
            this.dgvShowSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.dgvShowSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvShowSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvShowSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvShowSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(51)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvShowSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvShowSach.ColumnHeadersHeight = 32;
            this.dgvShowSach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvShowSach.Location = new System.Drawing.Point(36, 317);
            this.dgvShowSach.Name = "dgvShowSach";
            this.dgvShowSach.RowTemplate.Height = 30;
            this.dgvShowSach.RowTemplate.ReadOnly = true;
            this.dgvShowSach.Size = new System.Drawing.Size(538, 77);
            this.dgvShowSach.TabIndex = 31;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(110, 419);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(145, 18);
            this.labelControl5.TabIndex = 32;
            this.labelControl5.Text = "Số sách trong kho : ";
            // 
            // cbSachTrongKho
            // 
            this.cbSachTrongKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSachTrongKho.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbSachTrongKho.FormattingEnabled = true;
            this.cbSachTrongKho.Location = new System.Drawing.Point(295, 413);
            this.cbSachTrongKho.Name = "cbSachTrongKho";
            this.cbSachTrongKho.Size = new System.Drawing.Size(203, 24);
            this.cbSachTrongKho.TabIndex = 33;
            // 
            // btHoanThanh
            // 
            this.btHoanThanh.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btHoanThanh.Appearance.Options.UseFont = true;
            this.btHoanThanh.Location = new System.Drawing.Point(351, 465);
            this.btHoanThanh.Name = "btHoanThanh";
            this.btHoanThanh.Size = new System.Drawing.Size(121, 40);
            this.btHoanThanh.TabIndex = 34;
            this.btHoanThanh.Text = "Hoàn thành";
            this.btHoanThanh.Click += new System.EventHandler(this.btHoanThanh_Click);
            // 
            // btAdd
            // 
            this.btAdd.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btAdd.Appearance.Options.UseFont = true;
            this.btAdd.Location = new System.Drawing.Point(134, 465);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(121, 40);
            this.btAdd.TabIndex = 35;
            this.btAdd.Text = "Thêm";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // LapPhieuMuon
            // 
            this.Appearance.BackColor = System.Drawing.Color.Azure;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 547);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btHoanThanh);
            this.Controls.Add(this.cbSachTrongKho);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.dgvShowSach);
            this.Controls.Add(this.cbMaSach);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.dtNgayMuon);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.btLuu);
            this.Controls.Add(this.tbIdPhieuMuon);
            this.Controls.Add(this.tbSoThe);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Name = "LapPhieuMuon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập phiếu mượn sách";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LapPhieuMuon_FormClosing);
            this.Load += new System.EventHandler(this.LapPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbIdPhieuMuon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSoThe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btLuu;
        public DevExpress.XtraEditors.TextEdit tbIdPhieuMuon;
        public DevExpress.XtraEditors.TextEdit tbSoThe;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.DateTimePicker dtNgayMuon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.DataGridView dgvShowSach;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cbSachTrongKho;
        private DevExpress.XtraEditors.SimpleButton btHoanThanh;
        private DevExpress.XtraEditors.SimpleButton btAdd;
    }
}