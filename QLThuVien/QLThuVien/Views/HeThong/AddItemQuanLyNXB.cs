using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLThuVien.Models;
using System.Data.SqlClient;

namespace QLThuVien.Views.HeThong
{
    public partial class AddItemQuanLyNXB : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public AddItemQuanLyNXB()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maNXB = tbMaNXB.Text;
            string tenNXB = tbTenNXB.Text;
            if (string.IsNullOrWhiteSpace(maNXB) || string.IsNullOrWhiteSpace(tenNXB))
            {
                XtraMessageBox.Show("Không được để trống thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "Select * from NXB where MaNXB = N'" + maNXB + "'";
                DataTable dataTable = new DataTable();
                db.readDatathroughAdapter(query, dataTable);
                if (dataTable.Rows.Count != 0)
                {

                    XtraMessageBox.Show("Mã nhà xuất bản đã tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialog = XtraMessageBox.Show("Bạn chắc chắn muốn thêm ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string inSert = "Insert into NXB values (N'" + maNXB + "', N'" + tenNXB + "')";
                        SqlCommand command = new SqlCommand(inSert);
                        db.executeQuery(command);
                        QuanLyNXB.utcQuanLyNXB.QuanLyNXB_Loading();
                        this.Hide();
                    }
                }
            }
        }
    }
}