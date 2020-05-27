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
using MySql.Data.MySqlClient;

namespace QLThuVien.Views.HeThong
{
    public partial class ChangingItemQuanLySach : DevExpress.XtraEditors.XtraForm
    {
        public ChangingItemQuanLySach()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void ChangingItemQuanLySach_Load(object sender, EventArgs e)
        {
            // Add values to combobox tác giả
            string queryTacGia = "Select TenTacGia From TacGia";
            DataTable tacGia = new DataTable();
            db.readDatathroughAdapter(queryTacGia, tacGia);
            foreach (DataRow row in tacGia.Rows)
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

        private void btLuu_Click(object sender, EventArgs e)
        {
            
            DataTable dtMaSach = new DataTable();
            string maSach, tenSach, tacGia, theLoai, nhaXuatBan, NXB;
            maSach = ChangeItemQuanLySach.getMaSach;
            tenSach = tbTenSach.Text;
            NXB = tbNamXuatBan.Text;
            tacGia = cbTacGia.Text;
            theLoai = cbTheLoai.Text;
            nhaXuatBan = cbNhaXuatBan.Text;
            if ( string.IsNullOrWhiteSpace(tenSach) ||
                string.IsNullOrWhiteSpace(NXB) || string.IsNullOrWhiteSpace(tacGia) ||
                string.IsNullOrWhiteSpace(theLoai) || string.IsNullOrWhiteSpace(nhaXuatBan))
            {
                XtraMessageBox.Show("Không được phép để trống thông tin !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
               
                    int nXb = Int32.Parse(NXB);
                    DataTable tempDt = new DataTable();
                    string queryTacGia = "Select MaTacGia from TacGia where TenTacGia = N'" + tacGia + "'";
                    db.readDatathroughAdapter(queryTacGia, tempDt);
                    tacGia = tempDt.Rows[0].Field<String>("MaTacGia");

                    string queryTheLoai = "Select MaTheLoai from TheLoai where TenTheLoai = N'" + theLoai + "'";
                    tempDt.Reset();
                    db.readDatathroughAdapter(queryTheLoai, tempDt);
                    theLoai = tempDt.Rows[0].Field<String>("MaTheLoai");

                    string queryNXB = "Select MaNXB from NXB where TenNXB = N'" + nhaXuatBan + "'";
                    tempDt.Reset();
                    db.readDatathroughAdapter(queryNXB, tempDt);
                    nhaXuatBan = tempDt.Rows[0].Field<String>("MaNXB");

                    string upDate = "Update DAUSACH Set TenSach = N'" + tenSach + "' , NamXuatBan =" 
                    + NXB + ",MaTacGia = N'" + tacGia + "',MaTheLoai = N'" + theLoai 
                    + "' ,MaNXB= N'" + nhaXuatBan + "' Where MaSach =N'" + maSach + "'";
                    SqlCommand command = new SqlCommand(upDate);
                    db.executeQuery(command);
                    XtraMessageBox.Show("Thay đổi thành công .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLySach.utcQuanLySach.QuanLySach_Loading();
                    this.Hide();
                    
            }
        }
    }
}