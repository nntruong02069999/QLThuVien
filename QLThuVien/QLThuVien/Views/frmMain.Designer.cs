﻿namespace QLThuVien
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDangXuat = new DevExpress.XtraBars.BarButtonItem();
            this.btnChangePas = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLiSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLiTheLoai = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLiNXB = new DevExpress.XtraBars.BarButtonItem();
            this.btnListSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuanLiNhanVien = new DevExpress.XtraBars.BarButtonItem();
            this.btnMuonSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnTraSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnDocGia = new DevExpress.XtraBars.BarButtonItem();
            this.btnTimKiemSach = new DevExpress.XtraBars.BarButtonItem();
            this.btnSachTrongThuVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.btnQuaHan = new DevExpress.XtraBars.BarButtonItem();
            this.btnDocGiaDangMuon = new DevExpress.XtraBars.BarButtonItem();
            this.skinRibbonGalleryBarItem1 = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.tabDisplay = new DevExpress.XtraTab.XtraTabControl();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.AllowDrawArrow = false;
            this.ribbonControl1.ExpandCollapseItem.AllowDrawArrowInMenu = false;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Images = this.imageList1;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btnDangXuat,
            this.btnChangePas,
            this.btnQuanLiSach,
            this.btnQuanLiTheLoai,
            this.btnQuanLiNXB,
            this.btnListSach,
            this.btnQuanLiNhanVien,
            this.btnMuonSach,
            this.btnTraSach,
            this.btnDocGia,
            this.btnTimKiemSach,
            this.btnSachTrongThuVien,
            this.barButtonItem1,
            this.btnQuaHan,
            this.btnDocGiaDangMuon,
            this.skinRibbonGalleryBarItem1});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 17;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
            this.ribbonControl1.Size = new System.Drawing.Size(895, 158);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "agenda.png");
            this.imageList1.Images.SetKeyName(1, "arrow.png");
            this.imageList1.Images.SetKeyName(2, "book.png");
            this.imageList1.Images.SetKeyName(3, "books.png");
            this.imageList1.Images.SetKeyName(4, "different-squares.png");
            this.imageList1.Images.SetKeyName(5, "group.png");
            this.imageList1.Images.SetKeyName(6, "library.png");
            this.imageList1.Images.SetKeyName(7, "loupe.png");
            this.imageList1.Images.SetKeyName(8, "manufacture.png");
            this.imageList1.Images.SetKeyName(9, "output.png");
            this.imageList1.Images.SetKeyName(10, "padlock.png");
            this.imageList1.Images.SetKeyName(11, "profile.png");
            this.imageList1.Images.SetKeyName(12, "study.png");
            this.imageList1.Images.SetKeyName(13, "teamwork.png");
            this.imageList1.Images.SetKeyName(14, "book22.png");
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Caption = "Đăng xuất";
            this.btnDangXuat.Id = 1;
            this.btnDangXuat.ImageOptions.Image = global::QLThuVien.Properties.Resources.redo_16x16;
            this.btnDangXuat.ImageOptions.ImageIndex = 1;
            this.btnDangXuat.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.redo_32x32;
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDangXuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDangXuat_ItemClick);
            // 
            // btnChangePas
            // 
            this.btnChangePas.Caption = "Đổi mật khẩu";
            this.btnChangePas.Id = 2;
            this.btnChangePas.ImageOptions.Image = global::QLThuVien.Properties.Resources.bopermission_16x16;
            this.btnChangePas.ImageOptions.ImageIndex = 10;
            this.btnChangePas.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.bopermission_32x32;
            this.btnChangePas.Name = "btnChangePas";
            this.btnChangePas.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnChangePas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnChangePas_ItemClick);
            // 
            // btnQuanLiSach
            // 
            this.btnQuanLiSach.Caption = "Quản lý sách";
            this.btnQuanLiSach.Id = 3;
            this.btnQuanLiSach.ImageOptions.Image = global::QLThuVien.Properties.Resources.web_16x16;
            this.btnQuanLiSach.ImageOptions.ImageIndex = 3;
            this.btnQuanLiSach.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.web_32x32;
            this.btnQuanLiSach.Name = "btnQuanLiSach";
            this.btnQuanLiSach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnQuanLiSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLiSach_ItemClick);
            // 
            // btnQuanLiTheLoai
            // 
            this.btnQuanLiTheLoai.Caption = "Quản lí thể loại";
            this.btnQuanLiTheLoai.Id = 4;
            this.btnQuanLiTheLoai.ImageOptions.Image = global::QLThuVien.Properties.Resources.fullstackedbar_16x16;
            this.btnQuanLiTheLoai.ImageOptions.ImageIndex = 4;
            this.btnQuanLiTheLoai.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.fullstackedbar_32x32;
            this.btnQuanLiTheLoai.Name = "btnQuanLiTheLoai";
            this.btnQuanLiTheLoai.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnQuanLiTheLoai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLiTheLoai_ItemClick);
            // 
            // btnQuanLiNXB
            // 
            this.btnQuanLiNXB.Caption = "Quản lí NXB";
            this.btnQuanLiNXB.Id = 5;
            this.btnQuanLiNXB.ImageOptions.Image = global::QLThuVien.Properties.Resources.boresume_16x16;
            this.btnQuanLiNXB.ImageOptions.ImageIndex = 8;
            this.btnQuanLiNXB.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.boresume_32x32;
            this.btnQuanLiNXB.Name = "btnQuanLiNXB";
            this.btnQuanLiNXB.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnQuanLiNXB.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLiNXB_ItemClick);
            // 
            // btnListSach
            // 
            this.btnListSach.Caption = "Quản lý tác giả";
            this.btnListSach.Id = 6;
            this.btnListSach.ImageOptions.Image = global::QLThuVien.Properties.Resources.boposition2_16x16;
            this.btnListSach.ImageOptions.ImageIndex = 12;
            this.btnListSach.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.boposition2_32x32;
            this.btnListSach.Name = "btnListSach";
            this.btnListSach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnListSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnListSach_ItemClick);
            // 
            // btnQuanLiNhanVien
            // 
            this.btnQuanLiNhanVien.Caption = "Quản Lí Nhân Viên";
            this.btnQuanLiNhanVien.Id = 7;
            this.btnQuanLiNhanVien.ImageOptions.Image = global::QLThuVien.Properties.Resources.usergroup_16x16;
            this.btnQuanLiNhanVien.ImageOptions.ImageIndex = 13;
            this.btnQuanLiNhanVien.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.usergroup_32x32;
            this.btnQuanLiNhanVien.Name = "btnQuanLiNhanVien";
            this.btnQuanLiNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnQuanLiNhanVien_ItemClick);
            // 
            // btnMuonSach
            // 
            this.btnMuonSach.Caption = "Mượn sách";
            this.btnMuonSach.Id = 8;
            this.btnMuonSach.ImageOptions.Image = global::QLThuVien.Properties.Resources.editcontact_16x16;
            this.btnMuonSach.ImageOptions.ImageIndex = 0;
            this.btnMuonSach.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.editcontact_32x32;
            this.btnMuonSach.Name = "btnMuonSach";
            this.btnMuonSach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnMuonSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMuonSach_ItemClick);
            // 
            // btnTraSach
            // 
            this.btnTraSach.Caption = "Trả sách";
            this.btnTraSach.Id = 9;
            this.btnTraSach.ImageOptions.Image = global::QLThuVien.Properties.Resources.right_16x16;
            this.btnTraSach.ImageOptions.ImageIndex = 9;
            this.btnTraSach.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.right_32x32;
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnTraSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTraSach_ItemClick);
            // 
            // btnDocGia
            // 
            this.btnDocGia.Caption = "Độc giả";
            this.btnDocGia.Id = 10;
            this.btnDocGia.ImageOptions.Image = global::QLThuVien.Properties.Resources.boperson_16x16;
            this.btnDocGia.ImageOptions.ImageIndex = 11;
            this.btnDocGia.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.boperson_32x32;
            this.btnDocGia.Name = "btnDocGia";
            this.btnDocGia.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDocGia.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDocGia_ItemClick);
            // 
            // btnTimKiemSach
            // 
            this.btnTimKiemSach.Caption = "Tìm kiếm sách";
            this.btnTimKiemSach.Id = 11;
            this.btnTimKiemSach.ImageOptions.ImageIndex = 7;
            this.btnTimKiemSach.ImageOptions.SvgImage = global::QLThuVien.Properties.Resources.zoom;
            this.btnTimKiemSach.Name = "btnTimKiemSach";
            this.btnTimKiemSach.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTimKiemSach_ItemClick);
            // 
            // btnSachTrongThuVien
            // 
            this.btnSachTrongThuVien.Caption = "Sách trong thư viện";
            this.btnSachTrongThuVien.Id = 12;
            this.btnSachTrongThuVien.ImageOptions.Image = global::QLThuVien.Properties.Resources.morefunctions_16x16;
            this.btnSachTrongThuVien.ImageOptions.ImageIndex = 6;
            this.btnSachTrongThuVien.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.morefunctions_32x32;
            this.btnSachTrongThuVien.Name = "btnSachTrongThuVien";
            this.btnSachTrongThuVien.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnSachTrongThuVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSachTrongThuVien_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Sách đang được mượn";
            this.barButtonItem1.Id = 13;
            this.barButtonItem1.ImageOptions.Image = global::QLThuVien.Properties.Resources.recentlyuse_16x16;
            this.barButtonItem1.ImageOptions.ImageIndex = 12;
            this.barButtonItem1.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.recentlyuse_32x32;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnQuaHan
            // 
            this.btnQuaHan.Caption = "Sách quá hạn";
            this.btnQuaHan.Id = 14;
            this.btnQuaHan.ImageOptions.Image = global::QLThuVien.Properties.Resources.compatibility_16x16;
            this.btnQuaHan.ImageOptions.ImageIndex = 14;
            this.btnQuaHan.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.compatibility_32x32;
            this.btnQuaHan.Name = "btnQuaHan";
            this.btnQuaHan.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btnDocGiaDangMuon
            // 
            this.btnDocGiaDangMuon.Caption = "Độc giả đang mượn";
            this.btnDocGiaDangMuon.Id = 15;
            this.btnDocGiaDangMuon.ImageOptions.Image = global::QLThuVien.Properties.Resources.text_16x16;
            this.btnDocGiaDangMuon.ImageOptions.ImageIndex = 2;
            this.btnDocGiaDangMuon.ImageOptions.LargeImage = global::QLThuVien.Properties.Resources.text_32x32;
            this.btnDocGiaDangMuon.ImageOptions.SvgImageSize = new System.Drawing.Size(5, 5);
            this.btnDocGiaDangMuon.Name = "btnDocGiaDangMuon";
            this.btnDocGiaDangMuon.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.btnDocGiaDangMuon.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDocGiaDangMuon_ItemClick);
            // 
            // skinRibbonGalleryBarItem1
            // 
            this.skinRibbonGalleryBarItem1.Caption = "skinRibbonGalleryBarItem1";
            this.skinRibbonGalleryBarItem1.Id = 16;
            this.skinRibbonGalleryBarItem1.Name = "skinRibbonGalleryBarItem1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDangXuat);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnChangePas);
            this.ribbonPageGroup1.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Người dùng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQuanLiSach);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQuanLiTheLoai);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnQuanLiNXB);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnListSach);
            this.ribbonPageGroup2.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.State = DevExpress.XtraBars.Ribbon.RibbonPageGroupState.Expanded;
            this.ribbonPageGroup2.Text = "Thư viện";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnQuanLiNhanVien);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Nhân viên";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.skinRibbonGalleryBarItem1);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Giao diện";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Chức năng";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnMuonSach);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTraSach);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnDocGia);
            this.ribbonPageGroup3.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "Quản lí";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnTimKiemSach);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Tìm kiếm";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnSachTrongThuVien);
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup6.ItemLinks.Add(this.btnDocGiaDangMuon);
            this.ribbonPageGroup6.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.TwoRows;
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Thống kê";
            // 
            // tabDisplay
            // 
            this.tabDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDisplay.Location = new System.Drawing.Point(0, 158);
            this.tabDisplay.Name = "tabDisplay";
            this.tabDisplay.Size = new System.Drawing.Size(895, 422);
            this.tabDisplay.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 580);
            this.Controls.Add(this.tabDisplay);
            this.Controls.Add(this.ribbonControl1);
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("frmMain.IconOptions.SvgImage")));
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ THƯ VIỆN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabDisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTab.XtraTabControl tabDisplay;
        private DevExpress.XtraBars.BarButtonItem btnDangXuat;
        private DevExpress.XtraBars.BarButtonItem btnChangePas;
        private DevExpress.XtraBars.BarButtonItem btnQuanLiSach;
        private DevExpress.XtraBars.BarButtonItem btnQuanLiTheLoai;
        private DevExpress.XtraBars.BarButtonItem btnQuanLiNXB;
        private DevExpress.XtraBars.BarButtonItem btnListSach;
        private DevExpress.XtraBars.BarButtonItem btnQuanLiNhanVien;
        private DevExpress.XtraBars.BarButtonItem btnMuonSach;
        private DevExpress.XtraBars.BarButtonItem btnTraSach;
        private DevExpress.XtraBars.BarButtonItem btnDocGia;
        private DevExpress.XtraBars.BarButtonItem btnTimKiemSach;
        private DevExpress.XtraBars.BarButtonItem btnSachTrongThuVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnQuaHan;
        private DevExpress.XtraBars.BarButtonItem btnDocGiaDangMuon;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem skinRibbonGalleryBarItem1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private System.Windows.Forms.ImageList imageList1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    }
}

