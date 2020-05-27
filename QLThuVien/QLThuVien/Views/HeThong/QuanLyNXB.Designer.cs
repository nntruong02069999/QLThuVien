namespace QLThuVien.Views.HeThong
{
    partial class QuanLyNXB
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvQuanLyNXB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btThem = new DevExpress.XtraEditors.SimpleButton();
            this.btSua = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNXB)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanLyNXB
            // 
            this.dgvQuanLyNXB.AllowUserToAddRows = false;
            this.dgvQuanLyNXB.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.dgvQuanLyNXB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvQuanLyNXB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyNXB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(217)))), ((int)(((byte)(235)))));
            this.dgvQuanLyNXB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvQuanLyNXB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(51)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvQuanLyNXB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvQuanLyNXB.ColumnHeadersHeight = 32;
            this.dgvQuanLyNXB.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvQuanLyNXB.Location = new System.Drawing.Point(182, 114);
            this.dgvQuanLyNXB.Name = "dgvQuanLyNXB";
            this.dgvQuanLyNXB.RowTemplate.Height = 30;
            this.dgvQuanLyNXB.RowTemplate.ReadOnly = true;
            this.dgvQuanLyNXB.Size = new System.Drawing.Size(932, 431);
            this.dgvQuanLyNXB.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(181)))));
            this.groupBox1.Controls.Add(this.btXoa);
            this.groupBox1.Controls.Add(this.btThem);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Location = new System.Drawing.Point(182, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(932, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // btXoa
            // 
            this.btXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btXoa.Appearance.Options.UseFont = true;
            this.btXoa.Location = new System.Drawing.Point(668, 12);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(61, 43);
            this.btXoa.TabIndex = 12;
            this.btXoa.Text = "Xóa";
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btThem
            // 
            this.btThem.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btThem.Appearance.Options.UseFont = true;
            this.btThem.Location = new System.Drawing.Point(158, 15);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(76, 40);
            this.btThem.TabIndex = 12;
            this.btThem.Text = "Thêm";
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // btSua
            // 
            this.btSua.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.btSua.Appearance.Options.UseFont = true;
            this.btSua.Location = new System.Drawing.Point(431, 12);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(71, 43);
            this.btSua.TabIndex = 12;
            this.btSua.Text = "Sửa";
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // QuanLyNXB
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(217)))), ((int)(((byte)(235)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvQuanLyNXB);
            this.Controls.Add(this.groupBox1);
            this.Name = "QuanLyNXB";
            this.Size = new System.Drawing.Size(1280, 571);
            this.Load += new System.EventHandler(this.QuanLyNXB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyNXB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyNXB;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btXoa;
        private DevExpress.XtraEditors.SimpleButton btThem;
        private DevExpress.XtraEditors.SimpleButton btSua;
    }
}
