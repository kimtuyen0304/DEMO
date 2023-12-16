CREATE PROC GetDataReportHoaDon(@id nchar(10))
AS
BEGIN
	SELECT
		TenMH
	   ,Soluong
	   ,Gia
	   ,VAT
	   ,Thanhtien
	   ,TenKH
	   ,Diachi
	   ,SDT
	   ,ROW_NUMBER() OVER(ORDER BY HD.MaHD) AS STT
	FROM HoaDon HD
	LEFT JOIN ChiTietHoaDon CTHD ON HD.MaHD=CTHD.MaHD
	LEFT JOIN MatHang MH ON CTHD.MaMH=MH.MaMH
	LEFT JOIN KhachHang KH ON HD.MaKH=KH.MaKH
	WHERE HD.MaHD=@id
END

CREATE PROC GetDataReportPhieuThu(@id nchar(10))
AS
BEGIN
	SELECT
		MaPT
	   ,TenKH
	   ,Diachi
	   ,KH.SDT
	   ,TenNV
	   ,PTTT
	   ,NgayHD
	   ,Ngaythu
	   ,Sotien
	   ,ROW_NUMBER() OVER(ORDER BY MaPT) AS STT
	FROM ThuTienKhachHang TTKH
	LEFT JOIN KhachHang KH ON TTKH.MaKH=KH.MaKH
	LEFT JOIN HoaDon HD ON TTKH.MaHD=HD.MaHD
	LEFT JOIN NhanVien NV ON TTKH.MaNV=NV.MaNV
	WHERE MaPT = @id
END