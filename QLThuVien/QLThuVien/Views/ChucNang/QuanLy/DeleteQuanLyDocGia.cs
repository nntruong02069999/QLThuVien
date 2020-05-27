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

namespace QLThuVien.Views.ChucNang.QuanLy
{
    public partial class DeleteQuanLyDocGia : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public DeleteQuanLyDocGia()
        {
            InitializeComponent();
        }

        private void DeleteQuanLyDocGia_Load(object sender, EventArgs e)
        {
            
        }

        private void cbNhanVienTao_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            
        }
    }
}