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

        private void btLuu_Click(object sender, EventArgs e)
        {
            DataTable dtMaSach = new DataTable();
            string maSach, tenSach, tacGia, theLoai, nhaXuatBan, NXB;
            maSach = tbMaSach.Text;
            tenSach = tbTenSach.Text;
            NXB = tbNamXuatBan.Text;
            tacGia = cbTacGia.Text;
            theLoai = cbTheLoai.Text;
            nhaXuatBan = cbNhaXuatBan.Text;
            if(string.IsNullOrWhiteSpace(maSach) || string.IsNullOrWhiteSpace(tenSach) || 
                string.IsNullOrWhiteSpace(NXB) || string.IsNullOrWhiteSpace(tacGia) ||
                string.IsNullOrWhiteSpace(theLoai) || string.IsNullOrWhiteSpace(nhaXuatBan))
            {
                XtraMessageBox.Show("Không được phép để trống thông tin !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string checkMaSach = "Select * from DauSach where MaSach = '" + maSach + "'";
                db.readDatathroughAdapter(checkMaSach, dtMaSach);
                if(dtMaSach.Rows.Count != 0)
                {
                    XtraMessageBox.Show("Mã sách đã tồn tại !!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if(nupdowSoLuongSach.Value <= 0)
                    {
                        XtraMessageBox.Show("Vui lòng điền số lượng sách chính xác!!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string inSert = "Insert into DAUSACH Values (N'" + maSach + "' , N'" + tenSach
                        + "' , " + NXB + ", N'" + tacGia + "', N'" + theLoai + "' , N'" + nhaXuatBan + "')";
                    SqlCommand command = new SqlCommand(inSert);
                    db.executeQuery(command);
                    for (int i =0; i< nupdowSoLuongSach.Value; i++)
                    {
                        string inSertSoLuong = "Insert into Sach (MaSach, TrangThai) values (N'" + maSach + "' , 1 )";
                        SqlCommand command1 = new SqlCommand(inSertSoLuong);
                        db.executeQuery(command1);
                    }
                    XtraMessageBox.Show("Thêm thành công .", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    QuanLySach.utcQuanLySach.QuanLySach_Loading();
                    this.Hide();
                }
            }
        }
    }
}