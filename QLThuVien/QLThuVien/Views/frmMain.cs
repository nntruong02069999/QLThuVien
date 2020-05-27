using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLThuVien.Views;
using DevExpress.XtraTab;


namespace QLThuVien
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        internal static List<byte> typePages = new List<byte>();
        public void AddTabPages(XtraUserControl uct, byte typeControl, string tenTab)
        {
            for (int i = 0; i < tabDisplay.TabPages.Count; i++)
            {
                if (tabDisplay.TabPages[i].Contains(uct))
                {
                    tabDisplay.SelectedTabPage = tabDisplay.TabPages[i];
                    return;
                }
            }
            XtraTabPage tab = new XtraTabPage();
            typePages.Add(typeControl);
            tab.Name = uct.Name;
            tab.Size = tabDisplay.Size;
            tab.Text = tenTab;
            tabDisplay.TabPages.Add(tab);
            tabDisplay.SelectedTabPage = tab;
            uct.Dock = DockStyle.Fill;
            tab.Controls.Add(uct);
            uct.Focus();
        }

        public void DongTabHienTai()
        {
            tabDisplay.TabPages.Remove(tabDisplay.SelectedTabPage);
        }
        public void DongTatCaTab()
        {
            while (tabDisplay.TabPages.Count > 0)
            {
                DongTabHienTai();
            }
        }

        public void skins()
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Office 2010 Blue";
        }
         private void frmMain_Load(object sender, EventArgs e)
        {
            skins();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btnChangePas_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(ucChangePass.utcChangePass, 4, "Đổi mật khẩu");
        }

        private void btnDangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dialog = XtraMessageBox.Show("Bạn có muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Hide();
                frmLogin form = new frmLogin();
                form.Show();
            }
        }

        private void btnQuanLiSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.HeThong.QuanLySach.utcQuanLySach, 4, "Quản lý sách");
        }

        private void btnQuanLiTheLoai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.HeThong.QuanLyTheLoai.utcQuanLyTheLoai, 4, "Quản lý thể loại");
        }

        private void btnQuanLiNXB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.HeThong.QuanLyNXB.utcQuanLyNXB, 4, "Quản lý nhà xuất bản");
        }

        private void btnListSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.HeThong.QuanLyTacGia.utcQuanLyTacGia, 4, "Quản lý tác giả");
        }

        private void btnQuanLiNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.HeThong.QuanLyNhanVien.utcQuanLyNhanVien, 4, "Quản lý nhân viên");
        }

        private void btnMuonSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.ChucNang.QuanLy.QuanLyMuonSach.utcQuanLyMuonSach, 4, "Quản lý mượn sách");
        }

        private void btnTraSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.ChucNang.QuanLy.QuanLyTraSach.utcQuanLyTraSach, 4, "Quản lý trả sách");
        }

        private void btnDocGia_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.ChucNang.QuanLy.QuanLyDocGia.utcQuanLyDocGia, 4, "Quản lý độc giả");
        }

        private void btnTimKiemSach_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.ChucNang.TimKiem.TimKiemSach.utcTimKiemSach, 4, "Tìm kiếm sách");
        }

        private void btnSachTrongThuVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.ChucNang.ThongKe.ThongKeSachTrongThuVien.utcThongKeSachTrongThuVien, 4, "Thống kê sách trong thư viên");
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.ChucNang.ThongKe.ThongKeSachDangMuon.utcThongKeSachDangMuon, 4, "Thống kê sách đang được mượn");
        }

        private void btnDocGiaDangMuon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AddTabPages(Views.ChucNang.ThongKe.ThongKeDocGiaDangMuon.utcThongKeDocGiaDangMuon, 4, "Thống kê độc giả đang mượn");
        }
    }
}
