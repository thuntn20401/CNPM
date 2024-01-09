use QuanLyCuaHangAnNhanh
go

----sp doi mat khau
create proc sp_DoiMatKhau
@TenNguoiDung varchar(20),
@MatKhauCu varchar(20),
@MatKhauMoi varchar(20),
@XacNhanMK varchar(20)
AS
BEGIN
		DECLARE @MatKhau varchar(20),@status nvarchar(100)
		IF EXISTS (SELECT * FROM DBO.TaiKhoan WHERE TenNguoiDung = @TenNguoiDung AND MatKhau = @MatKhauCu)
		BEGIN 
			IF(@MatKhauCu != @MatKhauMoi)
			BEGIN 
				IF(@MatKhauMoi = @XacNhanMK)
				BEGIN 
					UPDATE dbo.TaiKhoan set MatKhau = @MatKhauMoi
					WHERE TenNguoiDung = @TenNguoiDung
					SET @status = N'Đổi mật khẩu thành công!'
				END
				ELSE
				BEGIN
					SET @status = N'Mật khẩu xác nhận không đúng!'
				END
			END
			ELSE
				BEGIN
					SET @status = N'Mật khẩu mới phải khác mật khẩu cũ'
				END
		END
		BEGIN 
			SET @status = N'Mật khẩu không đúng!'
		END
		SELECT @status as status
END
GO
----sp kiem tra dang nhap
create proc sp_KiemTraDangNhap
@TenNguoiDung varchar(20),
@MatKhau varchar(20)
AS 
BEGIN
	DECLARE @status int, @Quyen nvarchar(20)
	IF EXISTS(SELECT * FROM dbo.TaiKhoan WHERE TenNguoiDung = @TenNguoiDung AND MatKhau = @MatKhau)
	BEGIN 
		SET @Quyen = (SELECT dbo.TaiKhoan.Quyen FROM dbo.TaiKhoan WHERE TenNguoiDung = @TenNguoiDung)
		SET @status = 1
	END
	ELSE
		SET @status = 0
	SELECT @status AS status, @Quyen AS role
END
GO

------------sp xoa don hang
CREATE PROC sp_XoaDonHang
@MaDonHang int 
AS 
BEGIN 
	DELETE dbo.DonHang
	WHERE MaDonHang = @MaDonHang
END
GO
-----------SP XOA SAN PHAM
CREATE PROC sp_XoaSanPham
@MaSanPham int
AS
BEGIN
	DELETE dbo.SanPham
	WHERE MaSanPham = @MaSanPham
END
GO

----------SP XOA CHI TIET DH

CREATE PROC sp_XoaChiTietDH
@MaChiTietDH int
AS 
BEGIN 
	DELETE dbo.DonHang WHERE MaChiTietDH = @MaChiTietDH
	DELETE dbo.ChiTietDonHang WHERE MaChiTietDH = @MaChiTietDH;
END
GO

--------SP XOA TAI KHOAN

CREATE PROC sp_XoaTaiKhoan
@TenNguoiDung varchar(20)
AS 
BEGIN
	DECLARE @sql1 nvarchar(MAX), @sql2 nvarchar(MAX)
	DELETE DBO.TaiKhoan
	WHERE TenNguoiDung = @TenNguoiDung
	SET @sql1 = 'XOA TAI KHOAN ' + @TenNguoiDung+ '';
	SET @sql2 = 'XOA DANG NHAP ' + @TenNguoiDung+ '';
	EXEC(@sql1);
	EXEC(@sql2);
END
GO

-----------sp lay tat ca san pham
CREATE PROC sp_LayTatCaSP
AS
BEGIN 
	SELECT dbo.SanPham.MaSanPham AS MaSanPham, dbo.SanPham.TenSanPham,dbo.TheLoai.TenTheLoai, dbo.NhaPhanPhoi.TenNhaPhanPhoi, dbo.SanPham.SoLuong,
	dbo.SanPham.GiaGoc, dbo.SanPham.GiaBan, dbo.SanPham.NgaySanXuat,dbo.SanPham.HanSuDung, dbo.SanPham.MoTa
	FROM dbo.SanPham, dbo.TheLoai,dbo.NhaPhanPhoi
	WHERE SanPham.MaTheLoai = TheLoai.MaTheLoai AND SanPham.MaNhaPhanPhoi = NhaPhanPhoi.MaNhaPhanPhoi
END
GO

--------SP LAY CHI TIET DON DAT HANG
CREATE PROC sp_LayChiTietDH
@TenNguoiDung varchar(20),
@MaChiTietDH int
AS 
BEGIN
	SELECT MaDonHang, TenSanPham, SoLuong, GiaTien
	FROM View_DanhSachHangDaDat WHERE TenNguoiDung = @TenNguoiDung AND MaChiTietDH = @MaChiTietDH
END
GO
---------sp lay san pham
CREATE PROC sp_LaySanPham
@MaSanPham int 
AS 
BEGIN 
	SELECT * FROM dbo.SanPham WHERE MaSanPham = @MaSanPham
END
GO
-----sp lay chi tiet don hang cua nguoi dung
CREATE PROC  sp_LayChiTietDHNguoiDung
@TenNguoiDung varchar(20)
AS
BEGIN
	SELECT * FROM DBO.ChiTietDonHang
	WHERE TenNguoiDung = @TenNguoiDung
END
GO

---------sp lay chi tiet don hang theo ngay
CREATE PROC sp_LayCTDHTheoNgay
@TenNguoiDung varchar(20),
@datefrom varchar(20),
@dateto varchar(20)
AS
BEGIN
	SELECT * FROM dbo.ChiTietDonHang
	WHERE TenNguoiDung = @TenNguoiDung AND NgayLapDon >= @datefrom AND NgayLapDon <= @dateto
END
GO

-----SP THONG TIN NGUOI DUNG
CREATE PROC sp_ThongTinNguoiDung
@TenNguoiDung varchar(20)
AS
BEGIN
	SELECT * FROM dbo.TaiKhoan
	WHERE TenNguoiDung = @TenNguoiDung
END
GO

-----SP THEM DON HANG
CREATE PROC sp_ThemDonHang
@TenNguoiDung varchar(20),
@MaChiTietDH int,
@MaSanPham int,
@SoLuong int
AS
BEGIN
	INSERT INTO DBO.DonHang (TenNguoiDung, MaChiTietDH, MaSanPham, SoLuong)
	VALUES (@TenNguoiDung, @MaChiTietDH, @MaChiTietDH, @SoLuong)
END
GO
--------sp them san pham
CREATE PROC sp_ThemSanPham
@MaTheLoai int,
@MaNhaPhanPhoi int,
@TenSanPham nvarchar(50),
@SoLuong int,
@GiaGoc float,
@GiaBan float,
@NgaySanXuat date,
@HanSuDung date,
@MoTa nvarchar(100)
AS
BEGIN
	INSERT INTO dbo.SanPham (MaTheLoai, MaNhaPhanPhoi, TenSanPham, SoLuong, GiaGoc, GiaBan, MoTa, NgaySanXuat, HanSuDung)
	VALUES (@MaTheLoai, @MaNhaPhanPhoi, @TenSanPham, @SoLuong, @GiaGoc, @GiaBan, @MoTa, @NgaySanXuat, @HanSuDung)
END
GO
---------sp them chi tiet don hang
CREATE PROC sp_ThemChiTietDH
@TenNguoiDung varchar(20),
@DiaChi nvarchar(MAX),
@SoDienThoai char(11),
@NgayLapDon date,
@GhiChu nvarchar(100)
AS
BEGIN
	INSERT INTO dbo.ChiTietDonHang (TenNguoiDung, DiaChiGiaoHang, SDTNhanHang, NgayLapDon, GhiChu)
	VALUES (@TenNguoiDung,@DiaChi, @SoDienThoai,@NgayLapDon,@GhiChu)
END
GO

------sp Them nguoi dung
CREATE PROC sp_ThemNguoiDung
@TenNguoiDung varchar(20),
@MatKhau varchar(20),
@Ho nvarchar(50),
@Ten nvarchar(50),
@DiaChi nvarchar(50),
@NgaySinh date,
@GioiTinh nchar(1),
@SoDienThoai varchar(11),
@Email varchar(50),
@Quyen nvarchar(20) = N'Khách hàng'
AS
BEGIN 
	INSERT INTO dbo.TaiKhoan
	VALUES (@TenNguoiDung, @MatKhau, @Ho, @Ten, @DiaChi, @NgaySinh, @GioiTinh, @SoDienThoai, @Email, @Quyen)
END
GO

-----sp quyen dang nhap
CREATE PROC sp_QuyenDangNhap
@TenNguoiDung varchar(20),
@MatKhau varchar(20),
@Quyen varchar(20)
AS 
BEGIN 
	DECLARE @sql nvarchar(MAX)
	IF(@Quyen = N'Khách hàng')
	BEGIN
		SET @sql = ' CREATE LOGIN ['+@TenNguoiDung+'] WITH PASSWORD= '''+@MatKhau+''',
									DEFAULT_DATABASE = [QuanLyCuaHangAnNhanh],CHECK_EXPIRATION=ON, CHECK_POLICY=ON;
									CREATE USER ['+@TenNguoiDung+'] FOR LOGIN['+@TenNguoiDung+'];
									ALTER ROLE [db_datareader] ADD MEMBER ['+@TenNguoiDung+'];
									ALTER ROLE [db_datawriter] ADD MEMBER ['+@TenNguoiDung+']';
		EXEC(@sql);
		PRINT N'EXEC CUSTOMER'
	END
	ELSE
	IF(@Quyen = N'Quản lý')
	BEGIN
		SET @sql =' CREATE LOGIN ['+@TenNguoiDung+ '] WITH PASSWORD= '''+@MatKhau+''',
					DEFAULT_DATABASE=[DIEPFAMILY],CHECK_EXPIRATION=ON, CHECK_POLICY=ON;
					ALTER SERVER ROLE [securityadmin] ADD MEMBER ['+@TenNguoiDung+'];
					CREATE USER ['+@TenNguoiDung+'] FOR LOGIN['+@TenNguoiDung+'];
					ALTER ROLE [db_owner] ADD MEMBER ['+@TenNguoiDung+']';
		EXEC(@sql);
		PRINT N'EXEC ADMIN'
	END
	ELSE
	IF(@Quyen = N'Nhân viên')
	BEGIN
		SET @sql = 'CREATE LOGIN ['+@TenNguoiDung+'] WITH PASSWORD= '''+@MatKhau+''', 
					DEFAULT_DATABASE=[DIEPFAMILY],CHECK_EXPIRATION=ON, CHECK_POLICY=ON;
					CREATE USER['+@TenNguoiDung+'] FOR LOGIN[' +@TenNguoiDung+'];
					ALTER ROLE [db_owner] ADD MEMBER ['+@TenNguoiDung+']';
		EXEC(@sql);
		PRINT N'EXEC EMPLOYEE'
	END
END
GO

---------sp dang ki tai khoan
CREATE PROC sp_DangkyTK
@TenNguoiDung varchar(20),
@MatKhau varchar(20),
@XacNhanMk varchar(20)
AS 
BEGIN 
	BEGIN
		exec sp_ThemNguoiDung @TenNguoiDung, @MatKhau, '','','', '','','','',N'Khách hàng'
	END
END

---sp tim kiem san pham theo ten
CREATE PROC sp_TimKiemSPTheoTen
@TenSanPham nvarchar(50)
AS
BEGIN
	SELECT MaSanPham, TenSanPham,dbo.SanPham.SoLuong, dbo.SanPham.GiaBan, TenNhaPhanPhoi, TenTheLoai, dbo.SanPham.NgaySanXuat, dbo.SanPham.HanSuDung, dbo.SanPham.MoTa
	FROM dbo.SanPham, dbo.NhaPhanPhoi, dbo.TheLoai
	WHERE TenSanPham like '%'+@TenSanPham+'%' AND dbo.SanPham.MaNhaPhanPhoi = dbo.NhaPhanPhoi.MaNhaPhanPhoi AND dbo.SanPham.MaTheLoai = dbo.TheLoai.MaTheLoai 
END
GO

----sp cap nhat don hang
CREATE PROC sp_CapNhatDonHang
@MaDonHang int,
@SoLuong int
AS
BEGIN
	UPDATE dbo.DonHang
	SET SoLuong = @SoLuong
	WHERE MaDonHang = @MaDonHang
END
GO
---sp cap nhat san pham
CREATE PROC sp_CapNhatSanPham
@MaSanPham int,
@MaTheLoai int,
@MaNhaPhanPhoi int,
@TenSanPham nvarchar(50),
@SoLuong int,
@GiaGoc real,
@GiaBan real,
@NgaySanXuat date,
@HanSuDung date,
@MoTa nvarchar(100)
AS 
BEGIN 
	UPDATE dbo.SanPham
	SET MaTheLoai = @MaTheLoai,
		MaNhaPhanPhoi = @MaNhaPhanPhoi,
		TenSanPham = @TenSanPham,
		SoLuong = @SoLuong,
		GiaGoc = @GiaGoc,
		GiaBan = @GiaBan,
		NgaySanXuat =@NgaySanXuat,
		HanSuDung = @HanSuDung,
		MoTa = @MoTa
	WHERE MaSanPham = @MaSanPham
END
GO
-----sp cap nhat tai khoan
CREATE PROC sp_CapNhatTaiKhoan
@TenNguoiDung varchar(20),
@MatKhau varchar(20),
@Ho nvarchar(50),
@Ten nvarchar(50),
@DiaChi nvarchar(50),
@NgaySinh date,
@GioiTinh nchar(1),
@SoDienThoai varchar(11),
@Email varchar(50),
@Quyen nvarchar(20)
AS
BEGIN
	DECLARE @sql1 nvarchar(MAX), @sql2 nvarchar(MAX)
	UPDATE dbo.TaiKhoan
	SET
		Ho = @Ho,
		Ten = @Ten,
		DiaChi = @DiaChi,
		NgaySinh = @NgaySinh,
		GioiTinh = @GioiTinh,
		SoDienThoai = @SoDienThoai,
		Email = @Email,
		Quyen = @Quyen
	WHERE TenNguoiDung = @TenNguoiDung

	SET @sql1 = 'DROP USER ' + @TenNguoiDung+'';
	SET @sql2 = 'DROP LOGIN ' + @TenNguoiDung+'';
	EXEC(@sql1);
	EXEC(@sql2);
	EXEC sp_QuyenDangNhap @TenNguoiDung, @MatKhau,@Quyen
END
GO



		


