namespace QLThuVien.Views
{
    partial class ucChangePass
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbNewPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbConfirmPass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btOk = new DevExpress.XtraEditors.SimpleButton();
            this.tbOldPass = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfirmPass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOldPass.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tbOldPass);
            this.groupControl1.Controls.Add(this.btCancel);
            this.groupControl1.Controls.Add(this.btOk);
            this.groupControl1.Controls.Add(this.tbConfirmPass);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.tbNewPass);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(363, 67);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(567, 388);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thay đổi mật khẩu";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(86, 74);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 28);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Mật khẩu cũ : ";
            // 
            // tbNewPass
            // 
            this.tbNewPass.Location = new System.Drawing.Point(310, 149);
            this.tbNewPass.Name = "tbNewPass";
            this.tbNewPass.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewPass.Properties.Appearance.Options.UseFont = true;
            this.tbNewPass.Properties.PasswordChar = '*';
            this.tbNewPass.Size = new System.Drawing.Size(178, 28);
            this.tbNewPass.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(90, 147);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(135, 28);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Mật khẩu mới : ";
            // 
            // tbConfirmPass
            // 
            this.tbConfirmPass.Location = new System.Drawing.Point(310, 217);
            this.tbConfirmPass.Name = "tbConfirmPass";
            this.tbConfirmPass.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbConfirmPass.Properties.Appearance.Options.UseFont = true;
            this.tbConfirmPass.Properties.PasswordChar = '*';
            this.tbConfirmPass.Size = new System.Drawing.Size(178, 28);
            this.tbConfirmPass.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Sitka Heading", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(90, 215);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(179, 28);
            this.labelControl3.TabIndex = 12;
            this.labelControl3.Text = "Xác nhận mật khẩu : ";
            // 
            // btCancel
            // 
            this.btCancel.Appearance.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancel.Appearance.Options.UseFont = true;
            this.btCancel.AutoSize = true;
            this.btCancel.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.btCancel.Location = new System.Drawing.Point(325, 289);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(71, 33);
            this.btCancel.TabIndex = 15;
            this.btCancel.Text = "Cancel";
            // 
            // btOk
            // 
            this.btOk.Appearance.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOk.Appearance.Options.UseFont = true;
            this.btOk.AutoSize = true;
            this.btOk.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.btOk.Location = new System.Drawing.Point(178, 289);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(94, 33);
            this.btOk.TabIndex = 14;
            this.btOk.Text = "Xác nhận";
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // tbOldPass
            // 
            this.tbOldPass.Location = new System.Drawing.Point(310, 76);
            this.tbOldPass.Name = "tbOldPass";
            this.tbOldPass.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOldPass.Properties.Appearance.Options.UseFont = true;
            this.tbOldPass.Properties.PasswordChar = '*';
            this.tbOldPass.Size = new System.Drawing.Size(178, 28);
            this.tbOldPass.TabIndex = 16;
            // 
            // ucChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl1);
            this.Name = "ucChangePass";
            this.Size = new System.Drawing.Size(1058, 558);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNewPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbConfirmPass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbOldPass.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit tbConfirmPass;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbNewPass;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btCancel;
        private DevExpress.XtraEditors.SimpleButton btOk;
        private DevExpress.XtraEditors.TextEdit tbOldPass;
    }
}
