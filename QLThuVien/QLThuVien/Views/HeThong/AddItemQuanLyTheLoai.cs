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
    public partial class AddItemQuanLyTheLoai : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public AddItemQuanLyTheLoai()
        {
            InitializeComponent();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            string maTheLoai = tbMaTheLoai.Text;
            string tenTheLoai = tbTenTheLoai.Text;
            if(string.IsNullOrWhiteSpace(maTheLoai) || string.IsNullOrWhiteSpace(tenTheLoai))
            {
                XtraMessageBox.Show("Không được để trống thông tin", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "Select * from TheLoai where MaTheLoai = N'" + maTheLoai + "'";
                DataTable dataTable = new DataTable();
                db.readDatathroughAdapter(query, dataTable);
                if(dataTable.Rows.Count != 0)
                {

                    XtraMessageBox.Show("Mã thể loại đã tồn tại !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult dialog = XtraMessageBox.Show("Bạn chắc chắn muốn thêm ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dialog == DialogResult.Yes)
                    {
                        string inSert = "Insert into TheLoai values (N'" + maTheLoai + "', N'" + tenTheLoai + "')";
                        SqlCommand command = new SqlCommand(inSert);
                        db.executeQuery(command);
                        QuanLyTheLoai.utcQuanLyTheLoai.QuanLyTheLoai_Loading();
                        this.Hide();
                    }
                }
            }
        }
    }
}