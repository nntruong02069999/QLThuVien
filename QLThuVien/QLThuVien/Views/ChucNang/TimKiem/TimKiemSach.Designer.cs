namespace QLThuVien.Views.ChucNang.TimKiem
{
    partial class TimKiemSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbDocGia = new DevExpress.XtraEditors.GroupControl();
            this.dgvTimKiemSach = new System.Windows.Forms.DataGridView();
            this.tbTimKiem = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gbDocGia)).BeginInit();
            this.gbDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimKiem.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDocGia
            // 
            this.gbDocGia.Controls.Add(this.labelControl3);
            this.gbDocGia.Controls.Add(this.tbTimKiem);
            this.gbDocGia.Controls.Add(this.dgvTimKiemSach);
            this.gbDocGia.Location = new System.Drawing.Point(216, 16);
            this.gbDocGia.Name = "gbDocGia";
            this.gbDocGia.Size = new System.Drawing.Size(922, 451);
            this.gbDocGia.TabIndex = 3;
            this.gbDocGia.Text = "Tìm kiếm sách";
            // 
            // dgvTimKiemSach
            // 
            this.dgvTimKiemSach.AllowUserToAddRows = false;
            this.dgvTimKiemSach.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            this.dgvTimKiemSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTimKiemSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTimKiemSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dgvTimKiemSach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(51)))), ((int)(((byte)(164)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTimKiemSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTimKiemSach.ColumnHeadersHeight = 32;
            this.dgvTimKiemSach.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvTimKiemSach.Location = new System.Drawing.Point(18, 82);
            this.dgvTimKiemSach.Name = "dgvTimKiemSach";
            this.dgvTimKiemSach.RowTemplate.Height = 30;
            this.dgvTimKiemSach.RowTemplate.ReadOnly = true;
            this.dgvTimKiemSach.Size = new System.Drawing.Size(889, 345);
            this.dgvTimKiemSach.TabIndex = 8;
            // 
            // tbTimKiem
            // 
            this.tbTimKiem.Location = new System.Drawing.Point(165, 36);
            this.tbTimKiem.Name = "tbTimKiem";
            this.tbTimKiem.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTimKiem.Properties.Appearance.Options.UseFont = true;
            this.tbTimKiem.Size = new System.Drawing.Size(742, 28);
            this.tbTimKiem.TabIndex = 27;
            this.tbTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTimKiem_KeyPress);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(18, 39);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 20);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "Tìm kiếm sách : ";
            // 
            // TimKiemSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbDocGia);
            this.Name = "TimKiemSach";
            this.Size = new System.Drawing.Size(1186, 552);
            this.Load += new System.EventHandler(this.TimKiemSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gbDocGia)).EndInit();
            this.gbDocGia.ResumeLayout(false);
            this.gbDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimKiemSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTimKiem.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gbDocGia;
        private System.Windows.Forms.DataGridView dgvTimKiemSach;
        private DevExpress.XtraEditors.TextEdit tbTimKiem;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
