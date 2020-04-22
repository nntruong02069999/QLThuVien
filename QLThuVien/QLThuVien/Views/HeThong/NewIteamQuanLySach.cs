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


namespace QLThuVien.Views.HeThong
{
    public partial class NewIteamQuanLySach : DevExpress.XtraEditors.XtraForm
    {
        public NewIteamQuanLySach()
        {
            InitializeComponent();
        }
        Database db = new Database();

        private void NewIteamQuanLySach_Load(object sender, EventArgs e)
        {
            // Add values to combobox tác giả
            string queryTacGia = "Select TenTacGia From TacGia";
            DataTable tacGia = new DataTable();
            db.readDatathroughAdapter(queryTacGia, tacGia);
            foreach(DataRow row in tacGia.Rows)
            {
                cbTacGia.Items.Add(row[0]);
            }
            //Add values to combox thể loại
            string queryTheLoai = "Select TenTheLoai From TheLoai";
            DataTable theLoai = new DataTable();
            db.readDatathroughAdapter(queryTheLoai, theLoai);
            foreach (DataRow row in theLoai.Rows)
            {
                cbTheLoai.Items.Add(row[0]);
            }
            //Add values to combo box Nhà xuất bản
            string queryNXB = "Select TenNXB From NXB";
            DataTable NXB = new DataTable();
            db.readDatathroughAdapter(queryNXB, NXB);
            foreach (DataRow row in NXB.Rows)
            {
                cbNhaXuatBan.Items.Add(row[0]);
            }
            //
        }
    }
}