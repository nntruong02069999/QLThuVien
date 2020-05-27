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
    public partial class ChangeItemQuanLyTacGia : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        public ChangeItemQuanLyTacGia()
        {
            InitializeComponent();
        }

        private void ChangeItemQuanLyTacGia_Load(object sender, EventArgs e)
        {
            string query = "Select MaTacGia from TacGia";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            foreach (DataRow row in dataTable.Rows)
            {
                cbMaTacGia.Items.Add(row[0]);
            }
        }

        private void cbMaTacGia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string maTacGia = cbMaTacGia.Text;
            string query = "Select TenTacGia from TacGia where MaTacGia =N'" + maTacGia + "'";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(query, dataTable);
            string tenTacGia = dataTable.Rows[0].Field<String>("TenTacGia");
            tbTenTacGia.Text = tenTacGia;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {

        }
    }
}