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
    public partial class DeleteQuanLyTacGia : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public DeleteQuanLyTacGia()
        {
            InitializeComponent();
        }

    }
}