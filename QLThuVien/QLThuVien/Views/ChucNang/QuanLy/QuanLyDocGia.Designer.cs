namespace QLThuVien.Views.ChucNang.QuanLy
{
    partial class QuanLyDocGia
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDocGia = new DevExpress.XtraEditors.GroupControl();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gbDocGia)).BeginInit();
            this.gbDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDocGia
            // 
            this.gbDocGia.Controls.Add(this.btXoa);
            this.gbDocGia.Controls.Add(this.btSua);
            this.gbDocGia.Controls.Add(this.btThem);
            this.gbDocGia.Controls.Add(this.dgvDocGia);
            this.gbDocGia.Location = new System.Drawing.Point(221, 13);
            this.gbDocGia.Name = "gbDocGia";
            this.gbDocGia.Size = new System.Drawing.Size(922, 468);
            this.gbDocGia.TabIndex = 2;
            this.gbDocGia.Text = "Độc giả";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.AllowUserToAddRows = false;
            this.dgvDocGia.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.dgvDocGia.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDocGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDocGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvDocGia.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(51)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDocGia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDocGia.ColumnHeadersHeight = 32;
            this.dgvDocGia.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDocGia.Location = new System.Drawing.Point(14, 38);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.RowTemplate.Height = 30;
            this.dgvDocGia.RowTemplate.ReadOnly = true;
            this.dgvDocGia.Size = new System.Drawing.Size(889, 316);
            this.dgvDocGia.TabIndex = 8;
            // 
            // btThem
            // 
            this.btThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.Location = new System.Drawing.Point(114, 388);
            this.btThem.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Office2003;
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(121, 40);
            this.btThem.TabIndex = 24;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.Location = new System.Drawing.Point(406, 388);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(121, 40);
            this.btSua.TabIndex = 24;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(711, 388);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(121, 40);
            this.btXoa.TabIndex = 24;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // QuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDocGia);
            this.Name = "QuanLyDocGia";
            this.Size = new System.Drawing.Size(1157, 538);
            this.Load += new System.EventHandler(this.QuanLyDocGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbDocGia)).EndInit();
            this.gbDocGia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbDocGia;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btSua;
        private DevExpress.XtraEditors.SimpleButton btThem;
    }
}
