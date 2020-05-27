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

namespace QLThuVien.Views.ChucNang.TimKiem
{
    public partial class TimKiemSach : DevExpress.XtraEditors.XtraUserControl
    {
        Database db = new Database();
        public static TimKiemSach utcTimKiemSach = new TimKiemSach();
        public TimKiemSach()
        {
            InitializeComponent();
        }
        DataTable data = new DataTable();
        private void TimKiemSach_Load(object sender, EventArgs e)
        {
            
        }

        private void tbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
