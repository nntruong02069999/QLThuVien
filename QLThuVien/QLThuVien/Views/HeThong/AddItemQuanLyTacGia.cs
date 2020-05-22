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
    public partial class AddItemQuanLyTacGia : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public AddItemQuanLyTacGia()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maTacGia = tbMaTacGia.Text;
            string tenTacGia = tbTenTacGia.Text;
            if (string.IsNullOrWhiteSpace(maTacGia) || string.IsNullOrWhiteSpace(tenTacGia))
            {
                XtraMessageBox.Show("Không được để trống thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "Select * from TacGia where MaTacGia = N'" + maTacGia + "'";
                DataTable dataTable = new DataTable();
                db.readDatathroughAdapter(query, dataTable);
                if (dataTable.Rows.Count != 0)
                {

                    XtraMessageBox.Show("Mã tác giả bản đã tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialog = XtraMessageBox.Show("Bạn chắc chắn muốn thêm ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        string inSert = "Insert into TacGia values (N'" + tenTacGia + "', N'" + maTacGia + "')";
                        SqlCommand command = new SqlCommand(inSert);
                        db.executeQuery(command);
                        QuanLyTacGia.utcQuanLyTacGia.QuanLyTacGia_Loadding();
                        this.Hide();
                    }
                }
            }
        }
    }
}