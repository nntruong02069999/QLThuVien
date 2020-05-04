using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLThuVien.Models;
using System.Data.SqlClient;

namespace QLThuVien.Views.ChucNang.QuanLy
{
    public partial class QuanLyMuonSach : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public QuanLyMuonSach()
        {
            InitializeComponent();
        }
        public static QuanLyMuonSach utcQuanLyMuonSach = new QuanLyMuonSach();
    }
}
