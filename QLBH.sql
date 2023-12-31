USE [master]
GO
/****** Object:  Database [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1]    Script Date: 23/12/2023 6:39:48 CH ******/
CREATE DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'8 _ HuynhKimTuyen_ QLBH BBN_20DTK1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER03\MSSQL\DATA\8 _ HuynhKimTuyen_ QLBH BBN_20DTK1.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'8 _ HuynhKimTuyen_ QLBH BBN_20DTK1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER03\MSSQL\DATA\8 _ HuynhKimTuyen_ QLBH BBN_20DTK1_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET ARITHABORT OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET  MULTI_USER 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'8 _ HuynhKimTuyen_ QLBH BBN_20DTK1', N'ON'
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET QUERY_STORE = OFF
GO
USE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1]
GO
/****** Object:  Table [dbo].[ChiTietHangBanTraLai]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHangBanTraLai](
	[MaHBTL] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[Soluongtra] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietHangBanTraLai] PRIMARY KEY CLUSTERED 
(
	[MaHBTL] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[Soluong] [int] NULL,
	[Thanhtien] [int] NULL,
 CONSTRAINT [PK_ChiTietHoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuGiaoHang]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuGiaoHang](
	[MaMH] [nchar](10) NOT NULL,
	[MaPGH] [nchar](10) NOT NULL,
	[SoLuongGiao] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietPhieuGiaoHang] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC,
	[MaPGH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhapKho]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhapKho](
	[MaPNK] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[TenMH] [nvarchar](200) NULL,
	[Soluong] [int] NULL,
	[NgayNK] [datetime] NULL,
 CONSTRAINT [PK_ChiTietPhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[MaPNK] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuXuatKho]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuXuatKho](
	[MaPXK] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NOT NULL,
	[TenMH] [nvarchar](200) NULL,
	[Soluong] [int] NULL,
	[NgayXK] [datetime] NULL,
	[NgayDH] [date] NULL,
 CONSTRAINT [PK_ChiTietPhieuXuatKho] PRIMARY KEY CLUSTERED 
(
	[MaPXK] ASC,
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaCV] [nchar](10) NOT NULL,
	[TenCV] [nvarchar](200) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_ChucVu] PRIMARY KEY CLUSTERED 
(
	[MaCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DonDatHang]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonDatHang](
	[SoDH] [nchar](10) NOT NULL,
	[NgayDH] [date] NULL,
	[NgayGH] [date] NULL,
	[Dkthanhtoan] [nvarchar](200) NULL,
	[MaNV] [nchar](10) NULL,
	[MaKH] [nchar](10) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_DonDatHang] PRIMARY KEY CLUSTERED 
(
	[SoDH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangBanTraLai]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangBanTraLai](
	[MaHBTL] [nchar](10) NOT NULL,
	[Ngaytra] [date] NULL,
	[Diengiai] [nvarchar](200) NOT NULL,
	[Ghichu] [nchar](100) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[MaKH] [nchar](10) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_HangBanTraLai] PRIMARY KEY CLUSTERED 
(
	[MaHBTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[Kyhieu] [nchar](10) NULL,
	[NgayHD] [date] NULL,
	[MaKH] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
	[MaPXK] [nchar](10) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[TenKH] [nvarchar](200) NULL,
	[SDT] [nchar](10) NULL,
	[Diachi] [nvarchar](200) NULL,
	[Gioitinh] [nvarchar](200) NOT NULL,
	[Ghichu] [nvarchar](200) NOT NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhoThanhPham]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhoThanhPham](
	[Makho] [nchar](10) NOT NULL,
	[Diachi] [nvarchar](200) NULL,
	[Succhua] [int] NULL,
	[Controng] [int] NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_KhoThanhPham] PRIMARY KEY CLUSTERED 
(
	[Makho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MatHang]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MatHang](
	[TenMH] [nvarchar](200) NULL,
	[MaMH] [nchar](10) NOT NULL,
	[Gia] [int] NULL,
	[NgaySX] [date] NULL,
	[HanSD] [date] NULL,
	[VAT] [int] NULL,
	[MaNH] [nchar](10) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_MatHang] PRIMARY KEY CLUSTERED 
(
	[MaMH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](200) NULL,
	[SDT] [int] NULL,
	[MaPB] [nchar](10) NULL,
	[MaCV] [nchar](10) NULL,
	[Ngayvaolam] [date] NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomHang]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomHang](
	[MaNH] [nchar](10) NOT NULL,
	[TenNH] [nvarchar](200) NULL,
	[Ghichu] [nchar](10) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_NhomHang] PRIMARY KEY CLUSTERED 
(
	[MaNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuGiaoHang]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuGiaoHang](
	[TenKH] [nvarchar](200) NULL,
	[TenNV] [nvarchar](200) NULL,
	[MaPGH] [nchar](10) NOT NULL,
	[MaHD] [nchar](10) NOT NULL,
	[MaKH] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[NgayGiao] [date] NOT NULL,
	[NguoiGiao] [nvarchar](200) NOT NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_PGH] PRIMARY KEY CLUSTERED 
(
	[MaPGH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapKho]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapKho](
	[MaPNK] [nchar](10) NOT NULL,
	[TenNV] [nvarchar](200) NULL,
	[MaNV] [nchar](10) NULL,
	[Makho] [nchar](10) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_PhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[MaPNK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuatKho]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuatKho](
	[MaPXK] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NULL,
	[TenNV] [nvarchar](200) NULL,
	[MaKH] [nchar](10) NULL,
	[MaKho] [nchar](10) NULL,
	[Ghichu] [nvarchar](200) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_PhieuXuatKho] PRIMARY KEY CLUSTERED 
(
	[MaPXK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [nchar](10) NOT NULL,
	[TenPB] [nvarchar](200) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_PhongBan] PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TaiKhoan]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TaiKhoan](
	[MaTK] [nchar](10) NOT NULL,
	[MaNV] [nchar](10) NOT NULL,
	[TaiKhoan] [nvarchar](50) NOT NULL,
	[MatKhau] [nchar](10) NOT NULL,
	[Role] [bit] NOT NULL,
 CONSTRAINT [PK_TaiKhoan] PRIMARY KEY CLUSTERED 
(
	[MaTK] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThuTienKhachHang]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThuTienKhachHang](
	[MaPT] [nchar](10) NOT NULL,
	[Sotien] [int] NULL,
	[Ngaythu] [date] NULL,
	[PTTT] [nvarchar](200) NULL,
	[MaKH] [nchar](10) NULL,
	[MaNV] [nchar](10) NULL,
	[MaHD] [nchar](10) NULL,
	[Createby] [nchar](10) NULL,
 CONSTRAINT [PK_ThuTienKhachHang] PRIMARY KEY CLUSTERED 
(
	[MaPT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TonKho]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TonKho](
	[Makho] [nchar](10) NOT NULL,
	[MaMH] [nchar](10) NULL,
	[Soluongton] [int] NULL,
	[Createby] [nchar](10) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[ChiTietHangBanTraLai] ([MaHBTL], [MaMH], [Soluongtra]) VALUES (N'TL6       ', N'133       ', 20)
GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMH], [Soluong], [Thanhtien]) VALUES (N'HD1       ', N'63        ', 50, 5000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMH], [Soluong], [Thanhtien]) VALUES (N'HD10      ', N'131       ', 30, 4500000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMH], [Soluong], [Thanhtien]) VALUES (N'HD2       ', N'132       ', 200, 9000000)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaMH], [Soluong], [Thanhtien]) VALUES (N'HD3       ', N'134       ', 150, 7000000)
GO
INSERT [dbo].[ChiTietPhieuGiaoHang] ([MaMH], [MaPGH], [SoLuongGiao]) VALUES (N'131       ', N'PGH01     ', 1000)
GO
INSERT [dbo].[ChiTietPhieuNhapKho] ([MaPNK], [MaMH], [TenMH], [Soluong], [NgayNK]) VALUES (N'PNK1      ', N'131       ', N'MÀNG PVC ĐƠN LỚP VÀ PVC CÓ PHỦ PVDC', 1000, CAST(N'2023-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietPhieuNhapKho] ([MaPNK], [MaMH], [TenMH], [Soluong], [NgayNK]) VALUES (N'PNK2      ', N'132       ', N'MÀNG PVC TRIPLEX TRONG SUỐT HOẶC CÓ MÀU', 5000, CAST(N'2023-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietPhieuNhapKho] ([MaPNK], [MaMH], [TenMH], [Soluong], [NgayNK]) VALUES (N'PNK3      ', N'133       ', N'MÀNG VỈ NHÔM ALU COLD FORM BLISTER', 4000, CAST(N'2023-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietPhieuNhapKho] ([MaPNK], [MaMH], [TenMH], [Soluong], [NgayNK]) VALUES (N'PNK4      ', N'200       ', N'Giấy Kín Màu', 200, CAST(N'2023-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietPhieuNhapKho] ([MaPNK], [MaMH], [TenMH], [Soluong], [NgayNK]) VALUES (N'PNK5      ', N'50        ', N'GIẤY KRAFT VÀNG NÂU', 600, CAST(N'2023-01-01T00:00:00.000' AS DateTime))
INSERT [dbo].[ChiTietPhieuNhapKho] ([MaPNK], [MaMH], [TenMH], [Soluong], [NgayNK]) VALUES (N'PNK6      ', N'63        ', N'NULLMÀNG OPP', 800, CAST(N'2023-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[ChiTietPhieuXuatKho] ([MaPXK], [MaMH], [TenMH], [Soluong], [NgayXK], [NgayDH]) VALUES (N'PXK1      ', N'135       ', N'VỈ BẤM NHÔM ALU 20MIC', 200, CAST(N'2023-12-23T00:00:00.000' AS DateTime), CAST(N'2023-12-23' AS Date))
INSERT [dbo].[ChiTietPhieuXuatKho] ([MaPXK], [MaMH], [TenMH], [Soluong], [NgayXK], [NgayDH]) VALUES (N'PXK2      ', N'132       ', N'MÀNG PVC TRIPLEX TRONG SUỐT HOẶC CÓ MÀU', 1000, CAST(N'2023-05-05T00:00:00.000' AS DateTime), CAST(N'2023-05-02' AS Date))
INSERT [dbo].[ChiTietPhieuXuatKho] ([MaPXK], [MaMH], [TenMH], [Soluong], [NgayXK], [NgayDH]) VALUES (N'PXK3      ', N'133       ', N'MÀNG VỈ NHÔM ALU COLD FORM BLISTER', 1000, CAST(N'2023-05-05T00:00:00.000' AS DateTime), CAST(N'2023-05-02' AS Date))
GO
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [Createby]) VALUES (N'BH        ', N'BÁN HÀNG', N'AD        ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [Createby]) VALUES (N'KD        ', N'KINH DOANH', N'NV0       ')
INSERT [dbo].[ChucVu] ([MaCV], [TenCV], [Createby]) VALUES (N'KT        ', N'KẾ TOÁN', N'AD        ')
GO
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH1       ', CAST(N'2023-01-01' AS Date), CAST(N'2023-01-03' AS Date), N'TIỀN MẶT', N'NV1       ', N'KH01      ', N'NV1       ')
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH10      ', CAST(N'2023-01-01' AS Date), CAST(N'2023-01-05' AS Date), N'TIỀN MẶT', NULL, NULL, N'NV2       ')
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH2       ', CAST(N'2023-02-02' AS Date), CAST(N'2023-02-05' AS Date), N'CHUYỂN KHOẢN', N'NV2       ', N'KH02      ', N'NV3       ')
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH3       ', CAST(N'2023-01-01' AS Date), CAST(N'2023-01-05' AS Date), N'CHUYỂN KHOẢN', NULL, NULL, N'NV0       ')
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH4       ', CAST(N'2023-04-03' AS Date), CAST(N'2023-04-05' AS Date), N'TIỀN MẶT', NULL, NULL, N'AD        ')
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH5       ', CAST(N'2023-01-01' AS Date), CAST(N'2023-01-05' AS Date), N'CHUYỂN KHOẢN', NULL, NULL, N'NV5       ')
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH6       ', CAST(N'2023-04-03' AS Date), CAST(N'2023-04-05' AS Date), N'TIỀN MẶT', NULL, NULL, N'NV9       ')
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH7       ', CAST(N'2023-04-03' AS Date), CAST(N'2023-04-05' AS Date), N'CHUYỂN KHOẢN', NULL, NULL, N'NV10      ')
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH8       ', CAST(N'2023-01-01' AS Date), CAST(N'2023-01-05' AS Date), N'TIỀN MẶT', NULL, NULL, N'NV7       ')
INSERT [dbo].[DonDatHang] ([SoDH], [NgayDH], [NgayGH], [Dkthanhtoan], [MaNV], [MaKH], [Createby]) VALUES (N'DH9       ', CAST(N'2023-04-03' AS Date), CAST(N'2023-04-05' AS Date), N'CHUYỂN KHOẢN', NULL, NULL, N'NV8       ')
GO
INSERT [dbo].[HangBanTraLai] ([MaHBTL], [Ngaytra], [Diengiai], [Ghichu], [MaNV], [MaKH], [Createby]) VALUES (N'TL1       ', CAST(N'2023-01-05' AS Date), N'in sai mẫu', N'Lỗi sản phẩm                                                                                        ', N'NV2       ', N'KH01      ', N'NV1       ')
INSERT [dbo].[HangBanTraLai] ([MaHBTL], [Ngaytra], [Diengiai], [Ghichu], [MaNV], [MaKH], [Createby]) VALUES (N'TL2       ', CAST(N'2023-04-03' AS Date), N'Sai Tiêu Đề', N'Lõi sản phẩm                                                                                        ', N'NV1       ', N'KH02      ', N'AD        ')
INSERT [dbo].[HangBanTraLai] ([MaHBTL], [Ngaytra], [Diengiai], [Ghichu], [MaNV], [MaKH], [Createby]) VALUES (N'TL3       ', CAST(N'2023-12-15' AS Date), N'Dư Hàng', N'Trả lại Hàng dư                                                                                     ', N'NV9       ', N'KH05      ', N'NV10      ')
INSERT [dbo].[HangBanTraLai] ([MaHBTL], [Ngaytra], [Diengiai], [Ghichu], [MaNV], [MaKH], [Createby]) VALUES (N'TL4       ', CAST(N'2023-12-15' AS Date), N'sai kích thướt', N'trả hàng                                                                                            ', N'NV21      ', N'KH06      ', N'NV0       ')
INSERT [dbo].[HangBanTraLai] ([MaHBTL], [Ngaytra], [Diengiai], [Ghichu], [MaNV], [MaKH], [Createby]) VALUES (N'TL5       ', CAST(N'2023-12-15' AS Date), N'Lỗi đóng gói', N'trả hàng                                                                                            ', N'NV8       ', N'KH03      ', N'NV5       ')
INSERT [dbo].[HangBanTraLai] ([MaHBTL], [Ngaytra], [Diengiai], [Ghichu], [MaNV], [MaKH], [Createby]) VALUES (N'TL6       ', CAST(N'2023-12-15' AS Date), N'HDH', N'VFR                                                                                                 ', N'NV4       ', N'KH04      ', N'NV1       ')
GO
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD1       ', N'KO        ', CAST(N'2023-01-01' AS Date), N'KH01      ', N'NV1       ', N'PXK1      ', N'NV1       ')
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD10      ', N'KO        ', CAST(N'2023-12-15' AS Date), N'KH05      ', N'NV3       ', N'PXK2      ', N'NV2       ')
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD2       ', N'KO        ', CAST(N'2023-02-02' AS Date), N'KH02      ', N'NV2       ', N'PXK2      ', N'NV5       ')
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD3       ', N'KO        ', CAST(N'2023-04-04' AS Date), N'KH03      ', N'NV3       ', N'PXK3      ', N'NV8       ')
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD4       ', N'KO        ', CAST(N'2023-12-15' AS Date), N'KH05      ', N'NV5       ', N'PXK1      ', N'NV3       ')
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD5       ', N'KO        ', CAST(N'2023-12-15' AS Date), N'KH06      ', N'NV6       ', N'PXK1      ', N'NV0       ')
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD6       ', N'KO        ', CAST(N'2023-12-15' AS Date), N'KH05      ', N'NV9       ', N'PXK2      ', N'NV7       ')
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD7       ', N'KO        ', CAST(N'2023-12-15' AS Date), N'KH06      ', N'NV21      ', N'PXK2      ', N'NV11      ')
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD8       ', N'KO        ', CAST(N'2023-12-15' AS Date), N'KH02      ', N'NV1       ', N'PXK2      ', N'NV0       ')
INSERT [dbo].[HoaDon] ([MaHD], [Kyhieu], [NgayHD], [MaKH], [MaNV], [MaPXK], [Createby]) VALUES (N'HD9       ', N'KO        ', CAST(N'2023-12-15' AS Date), N'KH05      ', N'NV3       ', N'PXK2      ', N'NV9       ')
GO
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Diachi], [Gioitinh], [Ghichu], [Createby]) VALUES (N'KH01      ', N'Trần Đại', N'0974361257', N'12/3/29, tổ 15, kp3, Trảng Dài, Biên Hòa, Đồng Nai', N'nam', N'Khách bán sỉ', N'NV0       ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Diachi], [Gioitinh], [Ghichu], [Createby]) VALUES (N'KH02      ', N'Hòa Minh', N'0843712987', N'58, Nguyễn Ái Quốc', N'nam', N'Khách bán sỉ', N'NV1       ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Diachi], [Gioitinh], [Ghichu], [Createby]) VALUES (N'KH03      ', N'Phạm Hải Triều', N'0937136452', N'65, Nguyễn Kiệm, Quận 7, TPHCM', N'nam', N'Khách bán sỉ', N'NV2       ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Diachi], [Gioitinh], [Ghichu], [Createby]) VALUES (N'KH04      ', N'Kim Hoa', N'0934125252', N'12 Nguyễn Trãi', N'nữ', N'Khách bán lẻ', N'NV3       ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Diachi], [Gioitinh], [Ghichu], [Createby]) VALUES (N'KH05      ', N'Trường Văn', N'0935471456', N'48 Nguyễn Chí Thanh', N'Nam', N'Khách bán lẻ', N'NV0       ')
INSERT [dbo].[KhachHang] ([MaKH], [TenKH], [SDT], [Diachi], [Gioitinh], [Ghichu], [Createby]) VALUES (N'KH06      ', N'Thảo Trang', N'0385245256', N'38/3 Lồ Ồ Dĩ An, Bình Dương', N'Nữ', N'Khách bán Lẻ', N'NV10      ')
GO
INSERT [dbo].[KhoThanhPham] ([Makho], [Diachi], [Succhua], [Controng], [Createby]) VALUES (N'KHO1      ', N'BÌNH THẠNH', 50000, 40000, N'NV1       ')
INSERT [dbo].[KhoThanhPham] ([Makho], [Diachi], [Succhua], [Controng], [Createby]) VALUES (N'KHO2      ', N'THỦ ĐỨC', 60000, 50000, N'NV2       ')
GO
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'MÀNG PVC ĐƠN LỚP VÀ PVC CÓ PHỦ PVDC', N'131       ', 150000, CAST(N'2023-12-15' AS Date), CAST(N'2023-12-15' AS Date), 10, N'BBD       ', N'NV3       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'MÀNG PVC TRIPLEX TRONG SUỐT HOẶC CÓ MÀU', N'132       ', 200000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'BBD       ', N'NV1       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'MÀNG VỈ NHÔM ALU COLD FORM BLISTER', N'133       ', 100000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'MN        ', N'NV0       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'TÚI GIẤY GHÉP NHÔM, PET GHÉP NHÔM', N'134       ', 180000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'MNH       ', N'NV0       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'VỈ BẤM NHÔM ALU 20MIC', N'135       ', 220000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'G         ', N'NV6       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'Giấy Kín', N'155       ', 135000, CAST(N'2023-12-15' AS Date), CAST(N'2023-12-15' AS Date), 10, N'G         ', N'NV10      ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'Giấy Kín Màu', N'200       ', 145000, CAST(N'2023-12-15' AS Date), CAST(N'2023-12-15' AS Date), 10, N'G         ', N'NV1       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'MÀN MẠ', N'31        ', 210000, CAST(N'2022-01-01' AS Date), CAST(N'2030-01-01' AS Date), 10, N'MM        ', N'NV8       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'MÀNG PA', N'33        ', 170000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'MM        ', N'NV7       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'GIẤY KRAFT VÀNG NÂU', N'50        ', 150000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'MN        ', N'NV0       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'MÀNG MẠ BÁN PHẦN MPET', N'57        ', 140000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'MNH       ', N'NV2       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'MÀNG MPET', N'58        ', 130000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'G         ', N'NV5       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'MÀNG NHÔM 9 MIC', N'60        ', 100000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'MM        ', N'NV9       ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'NULLMÀNG OPP', N'63        ', 160000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'MM        ', N'NV11      ')
INSERT [dbo].[MatHang] ([TenMH], [MaMH], [Gia], [NgaySX], [HanSD], [VAT], [MaNH], [Createby]) VALUES (N'MÀNG NHÔM 7 MICRON', N'94        ', 140000, CAST(N'2022-01-01' AS Date), CAST(N'2035-01-01' AS Date), 10, N'MN        ', N'NV3       ')
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV1       ', N'Phạm Trường Giang', 365022505, N'03        ', N'KD        ', CAST(N'2023-11-29' AS Date), N'AD        ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV10      ', N'Triệu Ánh Vy', 974582147, N'02        ', N'KD        ', CAST(N'2022-01-01' AS Date), N'AD        ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV11      ', N'Nguyễn Lệ', 536214125, N'03        ', N'BH        ', CAST(N'2023-11-29' AS Date), N'AD        ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV12      ', N'Tú Tri', 863241258, N'01        ', N'BH        ', CAST(N'2022-01-01' AS Date), N'NV0       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV13      ', N'Trần Vũ Kỳ', 541235287, N'02        ', N'KT        ', CAST(N'2022-01-01' AS Date), N'NV1       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV14      ', N'Nguyễn Tấn Tài', 362412879, N'03        ', N'KD        ', CAST(N'2023-11-29' AS Date), N'NV7       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV15      ', N'Phan Tấn Tới', 953214765, N'02        ', N'KT        ', CAST(N'2022-01-01' AS Date), N'NV4       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV16      ', N'Nguyễn Ngọc Vy', 325974145, N'01        ', N'KD        ', CAST(N'2022-01-01' AS Date), N'NV6       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV17      ', N'Đinh Ngọc Anh', 355241698, N'02        ', N'KT        ', CAST(N'2022-01-01' AS Date), N'NV3       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV18      ', N'Huỳnh An Vy', 369852247, N'03        ', N'KD        ', CAST(N'2023-11-29' AS Date), N'NV11      ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV19      ', N'Phạm Khả Hân', 957741352, N'02        ', N'KT        ', CAST(N'2022-01-01' AS Date), N'NV9       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV2       ', N'Lê Thị Ngọc Thúy', 798339115, N'02        ', N'BH        ', CAST(N'2022-03-02' AS Date), N'NV10      ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV20      ', N'Nguyễn Ngọc Phụng', 953226336, N'01        ', N'BH        ', CAST(N'2023-11-29' AS Date), N'AD        ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV21      ', N'Minh Tường', 395432145, N'03        ', N'BH        ', CAST(N'2023-12-10' AS Date), N'NV7       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV3       ', N'Lê Thị Mai', 704699147, N'01        ', N'KT        ', CAST(N'2022-01-01' AS Date), N'NV5       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV4       ', N'Lê Duẩn Đạt', 351256478, N'02        ', N'KD        ', CAST(N'2023-11-30' AS Date), N'NV2       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV5       ', N'Hoàng Minh Toàn', 945871256, N'01        ', N'KT        ', CAST(N'2023-11-30' AS Date), N'NV9       ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV6       ', N'Phạm Trường An', 365022506, N'03        ', N'KD        ', CAST(N'2023-11-29' AS Date), N'NV12      ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV7       ', N'Hoàng Minh Tùng', 397452571, N'01        ', N'KT        ', CAST(N'2023-11-30' AS Date), N'NV13      ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV8       ', N'Huỳnh Anh Minh', 394258712, N'01        ', N'KD        ', CAST(N'2022-01-01' AS Date), N'NV11      ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [SDT], [MaPB], [MaCV], [Ngayvaolam], [Createby]) VALUES (N'NV9       ', N'Đinh Minh Nghĩa', 395671256, N'01        ', N'KT        ', CAST(N'2023-09-07' AS Date), N'NV3       ')
GO
INSERT [dbo].[NhomHang] ([MaNH], [TenNH], [Ghichu], [Createby]) VALUES (N'BBD       ', N'BAO BÌ DƯỢC', NULL, N'AD        ')
INSERT [dbo].[NhomHang] ([MaNH], [TenNH], [Ghichu], [Createby]) VALUES (N'G         ', N'GIẤY', NULL, N'NV1       ')
INSERT [dbo].[NhomHang] ([MaNH], [TenNH], [Ghichu], [Createby]) VALUES (N'MM        ', N'MÀNG MẠ', NULL, N'NV2       ')
INSERT [dbo].[NhomHang] ([MaNH], [TenNH], [Ghichu], [Createby]) VALUES (N'MN        ', N'MÀNG NHÔM', NULL, N'NV3       ')
INSERT [dbo].[NhomHang] ([MaNH], [TenNH], [Ghichu], [Createby]) VALUES (N'MNH       ', N'MÀNG NHỰA', NULL, N'NV4       ')
INSERT [dbo].[NhomHang] ([MaNH], [TenNH], [Ghichu], [Createby]) VALUES (N'NPL       ', N'NGUYÊN PHỤ LIỆU', NULL, N'NV5       ')
GO
INSERT [dbo].[PhieuGiaoHang] ([TenKH], [TenNV], [MaPGH], [MaHD], [MaKH], [MaNV], [NgayGiao], [NguoiGiao], [Createby]) VALUES (N'Trần Đại', N'Phạm Trường Giang', N'PGH01     ', N'HD1       ', N'KH01      ', N'NV1       ', CAST(N'2023-10-05' AS Date), N'Lê Thị Ngọc Thúy', N'NV1       ')
INSERT [dbo].[PhieuGiaoHang] ([TenKH], [TenNV], [MaPGH], [MaHD], [MaKH], [MaNV], [NgayGiao], [NguoiGiao], [Createby]) VALUES (N'Hòa Minh', N'Đinh Minh Nghĩa', N'PGH02     ', N'HD3       ', N'KH02      ', N'NV9       ', CAST(N'2023-12-15' AS Date), N'Tú Tri', N'NV5       ')
INSERT [dbo].[PhieuGiaoHang] ([TenKH], [TenNV], [MaPGH], [MaHD], [MaKH], [MaNV], [NgayGiao], [NguoiGiao], [Createby]) VALUES (N'Hòa Minh', N'Lê Thị Mai', N'PGH03     ', N'HD2       ', N'KH02      ', N'NV3       ', CAST(N'2023-12-15' AS Date), N'Trần Đức', N'NV10      ')
GO
INSERT [dbo].[PhieuNhapKho] ([MaPNK], [TenNV], [MaNV], [Makho], [Createby]) VALUES (N'PNK1      ', N'Phạm Trường Giang', N'NV1       ', N'KHO1      ', N'NV2       ')
INSERT [dbo].[PhieuNhapKho] ([MaPNK], [TenNV], [MaNV], [Makho], [Createby]) VALUES (N'PNK2      ', N'Lê Thị Ngọc Thúy', N'NV2       ', N'KHO2      ', N'NV3       ')
INSERT [dbo].[PhieuNhapKho] ([MaPNK], [TenNV], [MaNV], [Makho], [Createby]) VALUES (N'PNK3      ', N'Lê Thị Mai', N'NV3       ', N'KHO1      ', N'NV0       ')
INSERT [dbo].[PhieuNhapKho] ([MaPNK], [TenNV], [MaNV], [Makho], [Createby]) VALUES (N'PNK4      ', N'Lê Duẩn Đạt', N'NV4       ', N'KHO2      ', N'NV10      ')
INSERT [dbo].[PhieuNhapKho] ([MaPNK], [TenNV], [MaNV], [Makho], [Createby]) VALUES (N'PNK5      ', N'Hoàng Minh Toàn', N'NV5       ', N'KHO1      ', N'NV5       ')
INSERT [dbo].[PhieuNhapKho] ([MaPNK], [TenNV], [MaNV], [Makho], [Createby]) VALUES (N'PNK6      ', N'Phạm Trường An', N'NV6       ', N'KHO2      ', N'NV8       ')
GO
INSERT [dbo].[PhieuXuatKho] ([MaPXK], [MaNV], [TenNV], [MaKH], [MaKho], [Ghichu], [Createby]) VALUES (N'PXK1      ', N'NV1       ', N'Phạm Trường Giang', N'KH02      ', N'KHO1      ', N'KO', N'NV3       ')
INSERT [dbo].[PhieuXuatKho] ([MaPXK], [MaNV], [TenNV], [MaKH], [MaKho], [Ghichu], [Createby]) VALUES (N'PXK2      ', N'NV2       ', N'Lê Thị Ngọc Thúy', N'KH05      ', N'KHO2      ', N'KO', N'NV1       ')
INSERT [dbo].[PhieuXuatKho] ([MaPXK], [MaNV], [TenNV], [MaKH], [MaKho], [Ghichu], [Createby]) VALUES (N'PXK3      ', N'NV3       ', N'Lê Thị Mai', N'KH03      ', N'KHO1      ', N'KO', N'NV6       ')
INSERT [dbo].[PhieuXuatKho] ([MaPXK], [MaNV], [TenNV], [MaKH], [MaKho], [Ghichu], [Createby]) VALUES (N'PXK4      ', N'NV4       ', N'Lê Duẩn Đạt', N'KH04      ', N'KHO1      ', N'KO', N'NV9       ')
INSERT [dbo].[PhieuXuatKho] ([MaPXK], [MaNV], [TenNV], [MaKH], [MaKho], [Ghichu], [Createby]) VALUES (N'PXK5      ', N'NV6       ', N'Phạm Trường An', N'KH01      ', N'KHO2      ', N'KO', N'AD        ')
GO
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [Createby]) VALUES (N'01        ', N'KẾ TOÁN', N'AD        ')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [Createby]) VALUES (N'02        ', N'BÁN HÀNG', N'NV0       ')
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [Createby]) VALUES (N'03        ', N'KINH DOANH', N'AD        ')
GO
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK0       ', N'AD        ', N'admin@gmail.com', N'admin123  ', 0)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK00      ', N'NV0       ', N'adminkinhdoanh@gmail.com', N'adminkd123', 0)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK1       ', N'NV1       ', N'giang@gmail.com', N'giang123  ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK10      ', N'NV10      ', N'vy@gmail.com', N'vy123     ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK11      ', N'NV11      ', N'le@gmail.com', N'le123     ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK12      ', N'NV12      ', N'tri@gmail.com', N'tr123     ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK13      ', N'NV13      ', N'ky@gmail.com', N'ky123     ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK14      ', N'NV14      ', N'tai@gmail.com', N'tai123    ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK15      ', N'NV15      ', N'toi@gmail.com', N'toi123    ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK16      ', N'NV16      ', N'nvy@gmail.com', N'nvy123    ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK17      ', N'NV17      ', N'anh@gmail.com', N'anh123    ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK18      ', N'NV18      ', N'avy@gmail.com', N'avy123    ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK19      ', N'NV19      ', N'han@gmail.com', N'han123    ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK2       ', N'NV2       ', N'thuy@gmail.com', N'thuy123   ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK20      ', N'NV20      ', N'phung@gmail.com', N'phung123  ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK21      ', N'NV21      ', N'tuong@gmail.com', N'tuong123  ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK3       ', N'NV3       ', N'mai@gmail.com', N'mai123    ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK4       ', N'NV4       ', N'dat@gmail.com', N'dat123    ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK5       ', N'NV5       ', N'toan@gmail.com', N'toan123   ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK6       ', N'NV6       ', N'an@gmail.com', N'an123     ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK7       ', N'NV7       ', N'tung@gmail.com', N'tung123   ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK8       ', N'NV8       ', N'minh@gmail.com', N'minh123   ', 1)
INSERT [dbo].[TaiKhoan] ([MaTK], [MaNV], [TaiKhoan], [MatKhau], [Role]) VALUES (N'TK9       ', N'NV9       ', N'nghia@gmail.com', N'nghia123  ', 1)
GO
INSERT [dbo].[ThuTienKhachHang] ([MaPT], [Sotien], [Ngaythu], [PTTT], [MaKH], [MaNV], [MaHD], [Createby]) VALUES (N'PT02      ', 15000000, CAST(N'2023-07-02' AS Date), N'CHUYỂN KHOẢN', N'KH02      ', N'NV2       ', N'HD2       ', N'NV1       ')
INSERT [dbo].[ThuTienKhachHang] ([MaPT], [Sotien], [Ngaythu], [PTTT], [MaKH], [MaNV], [MaHD], [Createby]) VALUES (N'PT03      ', 20000000, CAST(N'2023-08-03' AS Date), N'TIỀN MẶT', N'KH01      ', N'NV3       ', N'HD3       ', N'NV4       ')
INSERT [dbo].[ThuTienKhachHang] ([MaPT], [Sotien], [Ngaythu], [PTTT], [MaKH], [MaNV], [MaHD], [Createby]) VALUES (N'PT04      ', 1000000, CAST(N'2023-12-15' AS Date), N'TIỀN MẶT', N'KH06      ', N'NV9       ', N'HD3       ', N'NV8       ')
INSERT [dbo].[ThuTienKhachHang] ([MaPT], [Sotien], [Ngaythu], [PTTT], [MaKH], [MaNV], [MaHD], [Createby]) VALUES (N'PT05      ', 50000, CAST(N'2023-12-15' AS Date), N'CK', N'KH05      ', N'NV6       ', N'HD4       ', N'NV20      ')
GO
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO1      ', N'131       ', 1000, N'NV1       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO2      ', N'132       ', 2000, N'VN2       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO1      ', N'133       ', 500, N'VN3       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO2      ', N'133       ', 400, N'NV4       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO1      ', N'134       ', 200, N'NV5       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO2      ', N'135       ', 120, N'NV6       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO1      ', N'31        ', 400, N'NV10      ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO2      ', N'33        ', 100, N'NV9       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO1      ', N'50        ', 600, N'NV6       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO1      ', N'57        ', 550, N'NV8       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO2      ', N'58        ', 420, N'NV7       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO2      ', N'60        ', 630, N'NV11      ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO1      ', N'63        ', 470, N'NV5       ')
INSERT [dbo].[TonKho] ([Makho], [MaMH], [Soluongton], [Createby]) VALUES (N'KHO2      ', N'94        ', 350, N'NV3       ')
GO
ALTER TABLE [dbo].[ChiTietHangBanTraLai]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHangBanTraLai_HangBanTraLai] FOREIGN KEY([MaHBTL])
REFERENCES [dbo].[HangBanTraLai] ([MaHBTL])
GO
ALTER TABLE [dbo].[ChiTietHangBanTraLai] CHECK CONSTRAINT [FK_ChiTietHangBanTraLai_HangBanTraLai]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_MatHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuGiaoHang_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang] CHECK CONSTRAINT [FK_ChiTietPhieuGiaoHang_MatHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuGiaoHang_PhieuGiaoHang] FOREIGN KEY([MaPGH])
REFERENCES [dbo].[PhieuGiaoHang] ([MaPGH])
GO
ALTER TABLE [dbo].[ChiTietPhieuGiaoHang] CHECK CONSTRAINT [FK_ChiTietPhieuGiaoHang_PhieuGiaoHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapKho_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho] CHECK CONSTRAINT [FK_ChiTietPhieuNhapKho_MatHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhapKho_PhieuNhapKho] FOREIGN KEY([MaPNK])
REFERENCES [dbo].[PhieuNhapKho] ([MaPNK])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhapKho] CHECK CONSTRAINT [FK_ChiTietPhieuNhapKho_PhieuNhapKho]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuatKho_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuatKho] CHECK CONSTRAINT [FK_ChiTietPhieuXuatKho_MatHang]
GO
ALTER TABLE [dbo].[ChiTietPhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuXuatKho_PhieuXuatKho] FOREIGN KEY([MaPXK])
REFERENCES [dbo].[PhieuXuatKho] ([MaPXK])
GO
ALTER TABLE [dbo].[ChiTietPhieuXuatKho] CHECK CONSTRAINT [FK_ChiTietPhieuXuatKho_PhieuXuatKho]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_KhachHang]
GO
ALTER TABLE [dbo].[DonDatHang]  WITH CHECK ADD  CONSTRAINT [FK_DonDatHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DonDatHang] CHECK CONSTRAINT [FK_DonDatHang_NhanVien]
GO
ALTER TABLE [dbo].[HangBanTraLai]  WITH CHECK ADD  CONSTRAINT [FK_HangBanTraLai_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HangBanTraLai] CHECK CONSTRAINT [FK_HangBanTraLai_KhachHang]
GO
ALTER TABLE [dbo].[HangBanTraLai]  WITH CHECK ADD  CONSTRAINT [FK_HangBanTraLai_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HangBanTraLai] CHECK CONSTRAINT [FK_HangBanTraLai_NhanVien]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang1]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_PhieuXuatKho] FOREIGN KEY([MaPXK])
REFERENCES [dbo].[PhieuXuatKho] ([MaPXK])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_PhieuXuatKho]
GO
ALTER TABLE [dbo].[MatHang]  WITH CHECK ADD  CONSTRAINT [FK_MatHang_NhomHang] FOREIGN KEY([MaNH])
REFERENCES [dbo].[NhomHang] ([MaNH])
GO
ALTER TABLE [dbo].[MatHang] CHECK CONSTRAINT [FK_MatHang_NhomHang]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_ChucVu] FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaCV])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_ChucVu]
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [FK_NhanVien_PhongBan] FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [FK_NhanVien_PhongBan]
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] CHECK CONSTRAINT [FK_PhieuGiaoHang_HoaDon]
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] CHECK CONSTRAINT [FK_PhieuGiaoHang_KhachHang]
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_KhachHang1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] CHECK CONSTRAINT [FK_PhieuGiaoHang_KhachHang1]
GO
ALTER TABLE [dbo].[PhieuGiaoHang]  WITH CHECK ADD  CONSTRAINT [FK_PhieuGiaoHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuGiaoHang] CHECK CONSTRAINT [FK_PhieuGiaoHang_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_KhoThanhPham1] FOREIGN KEY([Makho])
REFERENCES [dbo].[KhoThanhPham] ([Makho])
GO
ALTER TABLE [dbo].[PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_KhoThanhPham1]
GO
ALTER TABLE [dbo].[PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_NhanVien]
GO
ALTER TABLE [dbo].[PhieuNhapKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhapKho_NhanVien1] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuNhapKho] CHECK CONSTRAINT [FK_PhieuNhapKho_NhanVien1]
GO
ALTER TABLE [dbo].[PhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatKho_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuXuatKho] CHECK CONSTRAINT [FK_PhieuXuatKho_KhachHang]
GO
ALTER TABLE [dbo].[PhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatKho_KhachHang1] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[PhieuXuatKho] CHECK CONSTRAINT [FK_PhieuXuatKho_KhachHang1]
GO
ALTER TABLE [dbo].[PhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatKho_KhoThanhPham] FOREIGN KEY([MaKho])
REFERENCES [dbo].[KhoThanhPham] ([Makho])
GO
ALTER TABLE [dbo].[PhieuXuatKho] CHECK CONSTRAINT [FK_PhieuXuatKho_KhoThanhPham]
GO
ALTER TABLE [dbo].[PhieuXuatKho]  WITH CHECK ADD  CONSTRAINT [FK_PhieuXuatKho_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[PhieuXuatKho] CHECK CONSTRAINT [FK_PhieuXuatKho_NhanVien]
GO
ALTER TABLE [dbo].[ThuTienKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_ThuTienKhachHang_HoaDon] FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ThuTienKhachHang] CHECK CONSTRAINT [FK_ThuTienKhachHang_HoaDon]
GO
ALTER TABLE [dbo].[ThuTienKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_ThuTienKhachHang_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[ThuTienKhachHang] CHECK CONSTRAINT [FK_ThuTienKhachHang_KhachHang]
GO
ALTER TABLE [dbo].[ThuTienKhachHang]  WITH CHECK ADD  CONSTRAINT [FK_ThuTienKhachHang_NhanVien] FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ThuTienKhachHang] CHECK CONSTRAINT [FK_ThuTienKhachHang_NhanVien]
GO
ALTER TABLE [dbo].[TonKho]  WITH CHECK ADD  CONSTRAINT [FK_TonKho_KhoThanhPham] FOREIGN KEY([Makho])
REFERENCES [dbo].[KhoThanhPham] ([Makho])
GO
ALTER TABLE [dbo].[TonKho] CHECK CONSTRAINT [FK_TonKho_KhoThanhPham]
GO
ALTER TABLE [dbo].[TonKho]  WITH CHECK ADD  CONSTRAINT [FK_TonKho_MatHang] FOREIGN KEY([MaMH])
REFERENCES [dbo].[MatHang] ([MaMH])
GO
ALTER TABLE [dbo].[TonKho] CHECK CONSTRAINT [FK_TonKho_MatHang]
GO
/****** Object:  StoredProcedure [dbo].[GetDataReportHoaDon]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE   PROC [dbo].[GetDataReportHoaDon](@id nchar(10)) AS BEGIN    SELECT        TenMH       ,Soluong       ,Gia       ,VAT       ,Thanhtien       ,TenKH       ,Diachi       ,SDT       ,ROW_NUMBER() OVER(ORDER BY HD.MaHD) AS STT    FROM HoaDon HD    LEFT JOIN ChiTietHoaDon CTHD ON HD.MaHD=CTHD.MaHD    LEFT JOIN MatHang MH ON CTHD.MaMH=MH.MaMH    LEFT JOIN KhachHang KH ON HD.MaKH=KH.MaKH    WHERE HD.MaHD=@id END
GO
/****** Object:  StoredProcedure [dbo].[GetDataReportPhieuThu]    Script Date: 23/12/2023 6:39:48 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE   PROC [dbo].[GetDataReportPhieuThu](@id nchar(10)) AS BEGIN    SELECT        MaPT       ,TenKH       ,Diachi       ,KH.SDT       ,TenNV       ,PTTT       ,NgayHD       ,Ngaythu       ,Sotien       ,ROW_NUMBER() OVER(ORDER BY MaPT) AS STT    FROM ThuTienKhachHang TTKH    LEFT JOIN KhachHang KH ON TTKH.MaKH=KH.MaKH    LEFT JOIN HoaDon HD ON TTKH.MaHD=HD.MaHD    LEFT JOIN NhanVien NV ON TTKH.MaNV=NV.MaNV    WHERE MaPT = @id END
GO
USE [master]
GO
ALTER DATABASE [8 _ HuynhKimTuyen_ QLBH BBN_20DTK1] SET  READ_WRITE 
GO
