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
    public partial class LapPhieuMuon : DevExpress.XtraEditors.XtraForm
    {
        Database db = new Database();
        PhieuMuon phieuMuon = new PhieuMuon();
        public LapPhieuMuon()
        {
            InitializeComponent();
        }
        public static LapPhieuMuon utcLapPhieuMuon;
        private void btLuu_Click(object sender, EventArgs e)
        {

        }

        private void LapPhieuMuon_Load(object sender, EventArgs e)
        {
            tbSoThe.Text = QuanLyMuonSach.soTheDocGia;
            btLuu.Enabled = true;
            tbIdPhieuMuon.ReadOnly = false;
            dtNgayMuon.Enabled = true;
            cbMaSach.Enabled = false;
            dgvShowSach.Enabled = false;
            cbSachTrongKho.Enabled = false;
            btAdd.Enabled = false;
            btHoanThanh.Enabled = false;
            ShowComboxMaSach();
        }
        public void ShowComboxMaSach ()
        {
            string query = "Select MaSach from DauSach";
            DataTable data = new DataTable();
            db.readDatathroughAdapter(query, data);
            foreach(DataRow  row in data.Rows)
            {
                cbMaSach.Items.Add(row[0]);
            }
        }

        private void btLuu_Click_1(object sender, EventArgs e)
        {
            
            phieuMuon.SoThe = tbSoThe.Text;
            phieuMuon.NgayMuon = dtNgayMuon.Value;
            string idPhieuMuon = tbIdPhieuMuon.Text;
            if(string.IsNullOrEmpty(idPhieuMuon)) {
                XtraMessageBox.Show("Không được phép để trống ID phiếu mượn !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string queryCheck = "Select * from PhieuMuon where IdPhieuMuon = '" + idPhieuMuon + "'";
            DataTable dataTable = new DataTable();
            db.readDatathroughAdapter(queryCheck, dataTable);
            if(dataTable.Rows.Count >0)
            {
                XtraMessageBox.Show("ID phiếu mượn mã tồn tại !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            phieuMuon.IdPhieuMuon = idPhieuMuon;
            btLuu.Enabled = false;
            tbIdPhieuMuon.ReadOnly = true;
            dtNgayMuon.Enabled = false;

            cbMaSach.Enabled = true;
            dgvShowSach.Enabled = true;
            cbSachTrongKho.Enabled = true;
            btAdd.Enabled = true;
            btHoanThanh.Enabled = true;
            if(QuanLyMuonSach.utcQuanLyMuonSach.dgvSachDangChon.Rows.Count > 0)
            {
                DataTable dataTable_Clear = (DataTable)QuanLyMuonSach.utcQuanLyMuonSach.dgvSachDangChon.DataSource;
                dataTable_Clear.Rows.Clear();
            }
            
        }

        private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSachTrongKho.Items.Clear();
            string query = "SELECT MaSach as [Mã sách], TenSach as [Tên sách], tg.TenTacGia as [Tên tác giả], " +
                "tl.TenTheLoai as [Tên thể loại], nxb.TenNXB as [Nhà xuất bản], NamXuatBan as [Năm xuất bản] " +
                "From DauSach JOIN TacGia tg on DauSach.MaTacGia = tg.MaTacGia " +
                "Join TheLoai tl on DauSach.MaTheLoai = tl.MaTheLoai " +
                "join NXB nxb on DauSach.MaNXB = nxb.MaNXB where MaSach = '" + cbMaSach.Text+"'";
            DataTable table = new DataTable();
            db.readDatathroughAdapter(query, table);
            dgvShowSach.DataSource = table;

            string querySachTrongKho = "Select SoCaBiet From Sach where MaSach = '" + cbMaSach.Text + "' and TrangThai = 1";
            DataTable table1 = new DataTable();
            db.readDatathroughAdapter(querySachTrongKho, table1);
            if(table1.Rows.Count == 0 )
            {
                XtraMessageBox.Show("Sách trong kho đã hết !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return;
            }
            foreach(DataRow row in table1.Rows)
            {
                cbSachTrongKho.Items.Add(row[0]);
            }

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if(cbMaSach.Text == "")
            {
                XtraMessageBox.Show("Hãy chọn sách rồi mới dược thêm !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(cbSachTrongKho.Text == "")
            {
                XtraMessageBox.Show("Chọn sách trong kho !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable dataTable = (DataTable)QuanLyMuonSach.utcQuanLyMuonSach.dgvSachDangChon.DataSource;
            DataRow dataRow = dataTable.NewRow();
            dataRow["ID phiếu mượn"] = tbIdPhieuMuon.Text;
            dataRow["Số cá biệt"] = cbSachTrongKho.Text;
            dataRow["Mã sách"] = cbMaSach.Text;
            dataTable.Rows.Add(dataRow);
            dataTable.AcceptChanges();
        }

        private void btHoanThanh_Click(object sender, EventArgs e)
        {
            if(QuanLyMuonSach.utcQuanLyMuonSach.dgvSachDangChon.Rows.Count == 0)
            {
                XtraMessageBox.Show("Hãy chọn sách đi !!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult log = XtraMessageBox.Show("Đã chắc chắn chưa ?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(log == DialogResult.Yes)
            {
                try
                {
                    string query = "Insert into PhieuMuon (IdPhieuMuon,NgayMuon,SoThe) " +
                    "values (N'" + tbIdPhieuMuon.Text + "',N'" + dtNgayMuon.Value + "', N'" + tbSoThe.Text + "')";
                    SqlCommand commandLapPhieu = new SqlCommand(query);
                    db.executeQuery(commandLapPhieu);
                    for (int i = 0; i < QuanLyMuonSach.utcQuanLyMuonSach.dgvSachDangChon.Rows.Count; i++)
                    {
                        string idPhieuMuon = Convert.ToString(QuanLyMuonSach.utcQuanLyMuonSach.dgvSachDangChon.Rows[i].Cells["ID phiếu mượn"].Value);
                        string soCaBiet = Convert.ToString(QuanLyMuonSach.utcQuanLyMuonSach.dgvSachDangChon.Rows[i].Cells["Số cá biệt"].Value);
                        string queryInsert = "Insert into ChungThucTra (IdPhieuMuon,SoCaBiet,DaTra) " +
                            "values (N'" + idPhieuMuon + "', N'" + soCaBiet + "', 0 )";
                        SqlCommand sql = new SqlCommand(queryInsert);
                        db.executeQuery(sql);
                        string queryUpdate = "Update Sach set TrangThai = 1 where SoCaBiet = N'" + soCaBiet + "'";
                        SqlCommand sqlCommand = new SqlCommand(queryUpdate);
                        db.executeQuery(sqlCommand);
                    }

                    XtraMessageBox.Show("Thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                } catch(Exception err)
                {
                    
                    XtraMessageBox.Show("Lỗi sql rồi", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                frmLapPhieu lapPhieu = new frmLapPhieu();
                lapPhieu.Show();
                
            }

        }

        private void LapPhieuMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            
        }
    }
}