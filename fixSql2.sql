USE [master]
GO
/****** Object:  Database [QuanLyThuVien]    Script Date: 5/27/2020 2:51:02 PM ******/
CREATE DATABASE [QuanLyThuVien]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyThuVien', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER1\MSSQL\DATA\QuanLyThuVien.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyThuVien_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER1\MSSQL\DATA\QuanLyThuVien_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [QuanLyThuVien] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyThuVien].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyThuVien] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyThuVien] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyThuVien] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyThuVien] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyThuVien] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyThuVien] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyThuVien] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyThuVien] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyThuVien] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyThuVien', N'ON'
GO
ALTER DATABASE [QuanLyThuVien] SET QUERY_STORE = OFF
GO
USE [QuanLyThuVien]
GO
/****** Object:  Table [dbo].[ChungThucTra]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChungThucTra](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IdPhieuMuon] [varchar](255) NOT NULL,
	[SoCaBiet] [int] NOT NULL,
	[NgayTra] [date] NULL,
	[DaTra] [int] NOT NULL,
 CONSTRAINT [PK__ChungThu__3214EC272FB38DAB] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DauSach]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DauSach](
	[MaSach] [varchar](255) NOT NULL,
	[TenSach] [nvarchar](255) NOT NULL,
	[NamXuatBan] [int] NOT NULL,
	[MaTacGia] [varchar](255) NULL,
	[MaTheLoai] [varchar](255) NULL,
	[MaNXB] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocGia]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocGia](
	[IdDocGia] [int] IDENTITY(1,1) NOT NULL,
	[DiaChi] [nvarchar](255) NOT NULL,
	[TenDocGia] [nvarchar](255) NOT NULL,
	[SDT] [varchar](255) NOT NULL,
	[SoThe] [varchar](255) NOT NULL,
 CONSTRAINT [PK__DocGia__D6DC7FF63CFF5749] PRIMARY KEY CLUSTERED 
(
	[IdDocGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[IDNhanVien] [varchar](255) NOT NULL,
	[TenNhanVien] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IDNhanVien] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[MaNXB] [varchar](255) NOT NULL,
	[TenNXB] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNXB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[IdPhieuMuon] [varchar](255) NOT NULL,
	[NgayMuon] [date] NOT NULL,
	[IdNhanVien] [varchar](255) NULL,
	[SoThe] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPhieuMuon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[SoCaBiet] [int] IDENTITY(1,1) NOT NULL,
	[MaSach] [varchar](255) NULL,
	[TrangThai] [int] NULL,
 CONSTRAINT [PK__Sach__C12C79A1B39BD4E9] PRIMARY KEY CLUSTERED 
(
	[SoCaBiet] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[TenTacGia] [nvarchar](255) NOT NULL,
	[MaTacGia] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTacGia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheLoai]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheLoai](
	[MaTheLoai] [varchar](255) NOT NULL,
	[TenTheLoai] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTheLoai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheThuVien]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheThuVien](
	[ID_The] [varchar](255) NOT NULL,
	[NgayTaoThe] [date] NOT NULL,
	[NgayHetHan] [date] NOT NULL,
	[IDNhanVien] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID_The] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/27/2020 2:51:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[username] [varchar](255) NOT NULL,
	[password] [varchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChungThucTra] ON 

INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (1, N'PM01', 1, NULL, 1)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (2, N'PM01', 4, CAST(N'2020-05-26' AS Date), 1)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (3, N'PM01', 13, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (4, N'PM02', 2, NULL, 1)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (5, N'PM02', 5, NULL, 1)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (6, N'PM03', 3, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (7, N'PM04', 6, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (8, N'PM05', 18, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (9, N'PM05', 20, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (10, N'PM05', 24, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (12, N'PM00', 7, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (13, N'PM000', 16, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (14, N'PM0000', 21, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (15, N'PM0101', 16, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (16, N'PM0102', 22, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (17, N'PM0100', 12, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (18, N'PM123456', 9, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (19, N'PM123456', 10, NULL, 0)
INSERT [dbo].[ChungThucTra] ([ID], [IdPhieuMuon], [SoCaBiet], [NgayTra], [DaTra]) VALUES (20, N'PM00000', 23, NULL, 0)
SET IDENTITY_INSERT [dbo].[ChungThucTra] OFF
GO
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS01', N'Sự kết thúc của thời đại giả kim', 2010, N'TG01', N'TL12', N'NXB06')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS02', N'Nhà giả kim', 2012, N'TG04', N'TL07', N'NXB03')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS03', N'Đắc nhân tâm', 2011, N'TG02', N'TL10', N'NXB07')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS04', N'Tội ác và trừng phạt', 2006, N'TG06', N'TL10', N'NXB06')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS05', N'Bắt trẻ đồng xanh', 2000, N'TG03', N'TL04', N'NXB04')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS06', N'7 thói quen để thành đạt', 2007, N'TG07', N'TL02', N'NXB01')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS07', N'Thép đã tôi thế đấy', 1995, N'TG05', N'TL05', N'NXB05')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS08', N'Đọc vị bất kì ai', 2004, N'TG04', N'TL04', N'NXB04')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS09', N'Cuộc đời của Pi', 1999, N'TG06', N'TL11', N'NXB09')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS10', N'Giết Con Chim Nhại', 2003, N'TG02', N'TL10', N'NXB10')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS11', N'Ông Trăm Tuổi Trèo Qua Cửa Sổ Và Biến Mất', 2007, N'TG06', N'TL10', N'NXB07')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS12', N'Ông Già Và Biển Cả', 2005, N'TG05', N'TL10', N'NXB08')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS13', N'Điều Kỳ Diệu Của Tiệm Tạp Hóa Namiya', 2007, N'TG01', N'TL10', N'NXB07')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS14', N'Hai Vạn Dặm Dưới Đáy Biển', 2006, N'TG05', N'TL10', N'NXB04')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS15', N'Chiến Binh Cầu Vồng', 1998, N'TG07', N'TL10', N'NXB10')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS16', N'Khi Lỗi Thuộc Về Những Vì Sao', 1996, N'TG06', N'TL10', N'NXB04')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS17', N'Suối Nguồn', 1999, N'TG04', N'TL12', N'NXB01')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS18', N'Số Đỏ', 2014, N'TG01', N'TL11', N'NXB02')
INSERT [dbo].[DauSach] ([MaSach], [TenSach], [NamXuatBan], [MaTacGia], [MaTheLoai], [MaNXB]) VALUES (N'MS19', N'Cội nguồn của tội ác', 2019, N'TG01', N'TL10', N'NXB01')
GO
SET IDENTITY_INSERT [dbo].[DocGia] ON 

INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (1, N'Hà Nội', N'Nguyễn Nam Trường', N'0375860699', N'17150204')
INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (2, N'Hải Phòng', N'Nguyễn Tư Tỉnh', N'0885123456', N'17150205')
INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (3, N'Nha Trang', N'Nguyện Yêu Em', N'0944224906', N'17150206')
INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (4, N'Khánh Hòa', N'Căn Bản Là Thích', N'0754258963', N'17150207')
INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (5, N'Thái Nguyên', N'Một Là Đi Hai Là Đi', N'0789123456', N'17150208')
INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (6, N'TP HCM', N'I DONT KNOW', N'0456789123', N'17150209')
INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (7, N'0886257994', N'Nguyễn Hành Quyêt', N'0886257994', N'17150210')
INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (8, N'034567899', N'Trịnh Đằng Hương', N'034567899', N'17150211')
INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (9, N'0147258963', N'Bùi Hải Thành', N'0147258963', N'17150212')
INSERT [dbo].[DocGia] ([IdDocGia], [DiaChi], [TenDocGia], [SDT], [SoThe]) VALUES (10, N'456', N'ABC', N'456', N'17150213')
SET IDENTITY_INSERT [dbo].[DocGia] OFF
GO
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV01', N'Nguyễn Nam Trường 2')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV02', N'Bùi Văn Nguyện')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV03', N'Huỳnh Phước Sang')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV04', N'Nguyễn Thành Nam')
INSERT [dbo].[NhanVien] ([IDNhanVien], [TenNhanVien]) VALUES (N'NV05', N'Dương Trung Quốc')
GO
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB01', N'Nhà xuất bản Hồng Đức')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB02', N'Testing 2')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB03', N'Testing 2')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB04', N'Testing 2')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB05', N'Testing 2')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB06', N'Testing 2')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB07', N'Testing 2')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB08', N'Testing 2')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB09', N'Testing 2')
INSERT [dbo].[NXB] ([MaNXB], [TenNXB]) VALUES (N'NXB10', N'Testing 2')
GO
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM00', CAST(N'2020-05-23' AS Date), NULL, N'17150205')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM000', CAST(N'2020-05-25' AS Date), NULL, N'17150205')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM0000', CAST(N'2020-05-25' AS Date), NULL, N'17150205')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM00000', CAST(N'2020-05-25' AS Date), NULL, N'17150205')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM01', CAST(N'2020-03-18' AS Date), N'NV01', N'17150204')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM0100', CAST(N'2020-05-25' AS Date), NULL, N'17150205')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM0101', CAST(N'2020-05-25' AS Date), NULL, N'17150205')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM0102', CAST(N'2020-05-25' AS Date), NULL, N'17150205')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM02', CAST(N'2020-03-26' AS Date), N'NV02', N'17150205')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM03', CAST(N'2020-03-20' AS Date), N'NV03', N'17150206')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM04', CAST(N'2020-03-25' AS Date), N'NV04', N'17150207')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM05', CAST(N'2020-03-27' AS Date), N'NV05', N'17150208')
INSERT [dbo].[PhieuMuon] ([IdPhieuMuon], [NgayMuon], [IdNhanVien], [SoThe]) VALUES (N'PM123456', CAST(N'2020-05-25' AS Date), NULL, N'17150206')
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (1, N'MS01', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (2, N'MS01', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (3, N'MS01', 0)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (4, N'MS02', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (5, N'MS02', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (6, N'MS03', 0)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (7, N'MS04', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (8, N'MS05', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (9, N'MS05', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (10, N'MS05', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (11, N'MS06', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (12, N'MS07', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (13, N'MS08', 0)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (14, N'MS07', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (15, N'MS08', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (16, N'MS09', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (17, N'MS10', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (18, N'MS10', 0)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (19, N'MS10', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (20, N'MS11', 0)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (21, N'MS12', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (22, N'MS13', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (23, N'MS14', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (24, N'MS15', 0)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (25, N'MS16', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (27, N'MS17', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (28, N'MS18', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (29, N'MS19', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (30, N'MS19', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (31, N'MS19', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (32, N'MS19', 1)
INSERT [dbo].[Sach] ([SoCaBiet], [MaSach], [TrangThai]) VALUES (33, N'MS19', 1)
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Nguyễn Nam Trường', N'TG01')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Nguyễn Hải Đăng', N'TG02')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Nguyễn Bùi Chung Quân', N'TG03')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Hoàng Công Chất', N'TG04')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Bùi Văn Nguyện', N'TG05')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Đặng Hương Tràm', N'TG06')
INSERT [dbo].[TacGia] ([TenTacGia], [MaTacGia]) VALUES (N'Nguyễn Tư Tỉnh', N'TG07')
GO
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL02', N'Hài hước')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL03', N'Hành động 2')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL04', N'Giật gân')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL05', N'Tình cảm')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL06', N'Ngôn tình')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL07', N'Trinh thám')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL08', N'Siêu nhiên')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL09', N'Khoa học')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL10', N'Triết học')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL11', N'Pháp luật')
INSERT [dbo].[TheLoai] ([MaTheLoai], [TenTheLoai]) VALUES (N'TL12', N'Văn học')
GO
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150204', CAST(N'2020-03-24' AS Date), CAST(N'2020-04-02' AS Date), N'NV01')
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150205', CAST(N'2020-03-24' AS Date), CAST(N'2020-07-09' AS Date), N'NV02')
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150206', CAST(N'2020-03-24' AS Date), CAST(N'2020-10-29' AS Date), N'NV03')
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150207', CAST(N'2020-03-24' AS Date), CAST(N'2020-07-09' AS Date), N'NV04')
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150208', CAST(N'2020-03-24' AS Date), CAST(N'2020-08-01' AS Date), N'NV05')
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150209', CAST(N'2020-03-24' AS Date), CAST(N'2020-07-09' AS Date), N'NV03')
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150210', CAST(N'2020-05-25' AS Date), CAST(N'2020-08-20' AS Date), N'NV04')
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150211', CAST(N'2020-05-25' AS Date), CAST(N'2020-08-06' AS Date), N'NV03')
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150212', CAST(N'2020-05-25' AS Date), CAST(N'2020-08-14' AS Date), N'NV02')
INSERT [dbo].[TheThuVien] ([ID_The], [NgayTaoThe], [NgayHetHan], [IDNhanVien]) VALUES (N'17150213', CAST(N'2020-05-25' AS Date), CAST(N'2020-08-06' AS Date), N'NV03')
GO
INSERT [dbo].[User] ([username], [password]) VALUES (N'123', N'1234')
INSERT [dbo].[User] ([username], [password]) VALUES (N'12345', N'12345')
GO
ALTER TABLE [dbo].[ChungThucTra]  WITH CHECK ADD  CONSTRAINT [FK_IDPhieuMuon] FOREIGN KEY([IdPhieuMuon])
REFERENCES [dbo].[PhieuMuon] ([IdPhieuMuon])
GO
ALTER TABLE [dbo].[ChungThucTra] CHECK CONSTRAINT [FK_IDPhieuMuon]
GO
ALTER TABLE [dbo].[ChungThucTra]  WITH CHECK ADD  CONSTRAINT [FK_SoCaBiet] FOREIGN KEY([SoCaBiet])
REFERENCES [dbo].[Sach] ([SoCaBiet])
GO
ALTER TABLE [dbo].[ChungThucTra] CHECK CONSTRAINT [FK_SoCaBiet]
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD FOREIGN KEY([MaNXB])
REFERENCES [dbo].[NXB] ([MaNXB])
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD FOREIGN KEY([MaTacGia])
REFERENCES [dbo].[TacGia] ([MaTacGia])
GO
ALTER TABLE [dbo].[DauSach]  WITH CHECK ADD FOREIGN KEY([MaTheLoai])
REFERENCES [dbo].[TheLoai] ([MaTheLoai])
GO
ALTER TABLE [dbo].[DocGia]  WITH CHECK ADD  CONSTRAINT [FK_SoThe] FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([ID_The])
GO
ALTER TABLE [dbo].[DocGia] CHECK CONSTRAINT [FK_SoThe]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_IdNhanVien_PhieuMuon] FOREIGN KEY([IdNhanVien])
REFERENCES [dbo].[NhanVien] ([IDNhanVien])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_IdNhanVien_PhieuMuon]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_SoThe_PhieuMuon] FOREIGN KEY([SoThe])
REFERENCES [dbo].[TheThuVien] ([ID_The])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_SoThe_PhieuMuon]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK__Sach__MaSach__3F466844] FOREIGN KEY([MaSach])
REFERENCES [dbo].[DauSach] ([MaSach])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK__Sach__MaSach__3F466844]
GO
ALTER TABLE [dbo].[TheThuVien]  WITH CHECK ADD  CONSTRAINT [FK_IDNhanVien] FOREIGN KEY([IDNhanVien])
REFERENCES [dbo].[NhanVien] ([IDNhanVien])
GO
ALTER TABLE [dbo].[TheThuVien] CHECK CONSTRAINT [FK_IDNhanVien]
GO
USE [master]
GO
ALTER DATABASE [QuanLyThuVien] SET  READ_WRITE 
GO
