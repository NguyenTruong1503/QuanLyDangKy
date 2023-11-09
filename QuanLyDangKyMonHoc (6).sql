create database QuanLyDangKyMonHoc
use QuanLyDangKyMonHoc

create table HeDaoTao(
MaHe varchar (10) Primary Key,
TenHe nvarchar (50) NOT NULL
);

create table HocPhan(
MaHocPhan varchar (10) Primary Key,
TenHocPhan nvarchar (100) NOT NULL,
SoTinChi int CHECK (SoTinChi>0),
HocKy int CHECK (HocKy>0),
SoTiet int CHECK (SoTiet>0)
);

create table Khoa(
MaKhoa varchar(10) Primary Key,
TenKhoa nvarchar (100) NOT NULL,
NamThanhLap int NOT NULL
);

create table Nganh(
MaNganh varchar(10) Primary Key,
TenNganh nvarchar (100) NOT NULL,
MaKhoa varchar(10),
MaHe varchar (10),
Foreign key (MaKhoa) references Khoa(MaKhoa)
ON DELETE SET NULL
ON UPDATE CASCADE,
Foreign key (MaHe) references HeDaoTao(MaHe)
ON DELETE SET NULL
ON UPDATE CASCADE,
);


create table LopSinhVien(
MaLop varchar (10) Primary Key,
KhoaHoc varchar(10) NOT NULL,
SoLuong int CHECK (SoLuong>0),
MaNganh varchar (10) references Nganh(MaNganh)
ON DELETE SET NULL
ON UPDATE CASCADE
);


create table BoMon(
MaBoMon varchar (10) Primary Key,
TenBoMon nvarchar (100) NOT NULL,
NamThanhLap int NOT NULL,
MaKhoa varchar (10) references Khoa(MaKhoa)
ON DELETE SET NULL
ON UPDATE CASCADE,
);

create table GiangVien(
MaGiangVien varchar(20) Primary Key,
HoTen nvarchar (100) NOT NULL,
GioiTinh nvarchar (10),
NgaySinh date check (DATEDIFF(year, NgaySinh, GETDATE())>=18),
TrinhDo nvarchar (20) NOT NULL,
DiaChi nvarchar (80),
SoDienThoai varchar(10) CHECK (len (SoDienThoai)=10),
MaBoMon varchar (10) references BoMon(MaBoMon)
ON DELETE SET NULL
ON UPDATE CASCADE,
);

create table LopHocPhan(
MaLopHP varchar (10) Primary Key,
NgayBatDau date NOT NULL,
NgayKetThuc date NOT NULL,
GioiHan int CHECK (GioiHan>0 and GioiHan<=100),
PhongHoc varchar (10) NOT NULL,
Thu varchar (10) NOT NULL,
Tiet int CHECK (Tiet>0 and Tiet <15),
MaGiangVien varchar (20),
MaHocPhan varchar(10),
MaHe varchar (10),
CHECK (NgayBatDau<NgayKetThuc),
Foreign key (Magiangvien)references GiangVien(MaGiangVien)
ON DELETE SET NULL
ON UPDATE CASCADE,
Foreign key (MaHocPhan) references HocPhan(MaHocPhan)
ON DELETE SET NULL
ON UPDATE CASCADE,
Foreign key (MaHe) references HeDaoTao(MaHe)
ON DELETE SET NULL
ON UPDATE CASCADE
);


create table SinhVien(
MaSV varchar (10) Primary Key,
HoTen nvarchar (50) NOT NULL,
GioiTinh nvarchar(10),
NgaySinh date CHECK (DATEDIFF(year, NgaySinh, GETDATE())>=18),
DiaChi nvarchar(100),
SoDienThoai varchar(10) CHECK (len(SoDienThoai)=10),
MaLop varchar(10) references LopSinhVien(MaLop)
ON DELETE SET NULL
ON UPDATE CASCADE,
);

create table DangKy(
MaSV varchar(10),
MaLopHP varchar (10),
NgayDangKy date NOT NULL,
Primary key (MaSV,MaLopHP),
Foreign Key (MaLopHP) references LopHocPhan (MaLopHP)
ON DELETE  CASCADE,
Foreign Key (MaSV) references SinhVien (MaSV)
ON DELETE  CASCADE,
);



create table ChuongTrinhDaoTao(
MaNganh varchar(10),
MaHocPhan varchar (10),
LoaiHocPhan nvarchar(30) NOT NULL,
Primary Key (MaNganh,MaHocPhan),
Foreign Key (MaNganh) references Nganh (MaNganh)
ON DELETE cascade,
Foreign Key (MaHocPhan) references HocPhan (MaHocPhan)
ON DELETE cascade
);


insert into HeDaoTao values ('DT',N'Đại trà')
insert into HeDaoTao values ('CLC',N'Chất lượng cao')
insert into HeDaoTao values ('QT',N'Quốc tế')

insert into HocPhan values ('INIT130185',N'Nhập môn ngành CNTT',3,1,4)
insert into HocPhan values ('MATH143001',N'Đại số tuyến tính và cấu trúc đại số',4,1,4)
insert into HocPhan values ('INPR130285',N'Nhập môn lập trình',3,1,4)
insert into HocPhan values ('MATH132401',N'Toán 1',3,1,4)
insert into HocPhan values ('ECOM430984',N'Thương mại điện tử',3,1,3)
insert into HocPhan values ('PRTE230385',N'Kỹ thuật lập trình',3,2,4)
insert into HocPhan values ('DIGR230485',N'Toán rời rạc và lý thuyết đồ thị',3,2,4)
insert into HocPhan values ('NEES330380',N'Mạng máy tính căn bản',3,2,4)
insert into HocPhan values ('STMA230521',N'Sức bền vật liệu',3,2,4)
insert into HocPhan values ('TMMP230220',N'Nguyên lý-chi tiết máy',3,2,4)
insert into HocPhan values ('AMIC320133',N'Vi điều khiển',2,1,3)
insert into HocPhan values ('BENG330708',N'Kinh doanh thương mại',3,1,4)
insert into HocPhan values ('BLAW232408',N'Luật thương mại quốc tế',3,1,4)


insert into Khoa values(N'K001',N'Công nghệ thông tin',1960);
insert into Khoa values(N'K002',N'Cơ khí chế tạo máy',1968);
insert into Khoa values(N'K003',N'Cơ khí động lực',1964);
insert into Khoa values(N'K004',N'Hóa học và thực phẩm',1970);
insert into Khoa values(N'K005',N'May và thời trang',1958);
insert into Khoa values(N'K006',N'Điện-điện tử',1968);
insert into Khoa values(N'K007',N'In va truyền thông',1961);
insert into Khoa values(N'K008',N'Kinh tế',1965);
insert into Khoa values(N'K009',N'Ngoại ngữ',1974);
insert into Khoa values(N'K010',N'Xây dựng',1978);

insert into Nganh values('N001',N'Công nghệ thông tin','K001','QT');
insert into Nganh values('N002',N'Công nghệ in','K007','CLC');
insert into Nganh values('N003',N'Kỹ thuật nhiệt','K003','DT');
insert into Nganh values('N004',N'Xây dựng','K010','DT');
insert into Nganh values('N005',N'Công nghệ ô tô','K003','CLC');
insert into Nganh values('N006',N'Cơ khí','K002','DT');
insert into Nganh values('N007',N'Công nghệ may','K005','DT');
insert into Nganh values('N008',N'Ngôn ngữ Anh','K009','CLC');
insert into Nganh values('N009',N'Kiến trúc','K010','DT');
insert into Nganh values('N010',N'Quản trị kinh doanh','K008','DT');
insert into Nganh values('N011',N'Kỹ thuật cơ điện tử','K002','DT');


insert into LopSinhVien values('211101A',21,50,'N001');
insert into LopSinhVien values('211101B',21,50,'N001');
insert into LopSinhVien values('211101C',21,48,'N001');
insert into LopSinhVien values('201111A',20,30,'N001');
insert into LopSinhVien values('201111B',20,40,'N001');
insert into LopSinhVien values('191803A',19,45,'N004');
insert into LopSinhVien values('191803B',19,50,'N005');
insert into LopSinhVien values('211203A',21,50,'N007');
insert into LopSinhVien values('211203B',21,50,'N003');
insert into LopSinhVien values('211102A',21,50,'N004');

insert into BoMon values ('1',N'Công Nghệ Phần Mềm',2000,'K001')
insert into BoMon values ('2',N'Hệ Thống Thông Tin',2001,'K001')
insert into BoMon values ('3',N'Mạng Và An Ninh Mạng',2003,'K001')
insert into BoMon values ('4',N'Trí Tuệ Nhân Tạo',2010,'K001')
insert into BoMon values ('5',N'Cơ điện tử',2010,'K002')
insert into BoMon values ('6',N'Công nghệ chế tạo máy',2010,'K002')
insert into BoMon values ('7',N'Động cơ',1970,'K003')
insert into BoMon values ('8',N'Năng lượng tái tạo',1990,'K003')


insert into GiangVien values ('001',N'Huỳnh Xuân Tú','Nam','1989-10-10',N'Thạc Sĩ',N'Bình Định','0912312389','1')
insert into GiangVien values ('002',N'Đặng Phúc Vĩnh','Nam','1986-12-11',N'Tiến Sĩ',N'Tiền Giang','0912312432','2')
insert into GiangVien values ('003',N'Nguyễn Thị Thanh Tâm ',N'Nữ','1990-6-22',N'Thạc Sĩ',N'Kiên Giang','0912312366','3')
insert into GiangVien values ('004',N'Trần Xuân Nghị','Nam','1986-5-30',N'Thạc Sĩ',N'Long An','0912312289','4')
insert into GiangVien values ('005',N'Nguyễn Hoài Bảo','Nam','1993-3-25','Thạc Sĩ',N'Bình Dương','0912123229','5')
insert into GiangVien values ('006',N'Bùi Thị Hân',N'Nữ','1978-4-25',N'Thạc Sĩ',N'Hà Nội','0912123224','5')
insert into GiangVien values ('007',N'Nguyễn Quang Vinh','Nam','1975-7-13',N'Thạc Sĩ',N'An Giang','0912345229','6')
insert into GiangVien values ('008',N'Nguyễn Hoài Thương','Nam','1993-2-22',N'Thạc Sĩ',N'Bình Dương','0912123539','7')


insert into LopHocPhan Values (N'LHP01', N'2023-08-21', N'2023-11-27', 100,N'A101', N'Thứ 2', 1, N'001', N'INIT130185', N'DT') 
insert into LopHocPhan Values (N'LHP02', N'2023-08-22', N'2023-11-28', 80,N'A102', N'Thứ 3', 5, N'002', N'MATH143001', N'DT') 
insert into LopHocPhan Values (N'LHP03', N'2023-08-23', N'2023-11-29', 80,N'A103', N'Thứ 4', 7, N'003', N'INPR130285', N'CLC') 
insert into LopHocPhan Values (N'LHP04', N'2023-08-23', N'2023-11-29', 100,N'A104', N'Thứ 4', 6, N'004', N'MATH132401', N'QT') 
insert into LopHocPhan Values (N'LHP05', N'2023-08-24', N'2023-11-30', 100,N'A105', N'Thứ 5', 5, N'002', N'ECOM430984', N'DT') 

insert into SinhVien Values (N'211101', N'Nguyễn Đăng Trường', N'Nam',N'2003-03-15' ,N'Bến Tre', N'0392773846',N'211101B') 
insert into SinhVien Values (N'211102', N'Nguyễn Hữu Tiến', N'Nam', N'2003-10-15',N'Quảng Nam', N'0395112033', N'211101B')
insert into SinhVien Values (N'211103', N'Nguyễn Quốc Thịnh', N'Nam', N'2003-10-24',N'Long An', N'0311432658', N'211101C')
insert into SinhVien Values (N'211104', N'Bùi Quang Thiện', N'Nam', N'2003-09-15',N'Bến Tre', N'0315338659', N'201111A')
insert into SinhVien Values (N'211105', N'Nguyễn Thị Mỹ Tiên', N'Nữ', N'2003-09-03',N'Vũng Tàu', N'0345312034', N'201111B')
insert into SinhVien Values (N'211106', N'Phan Thanh Nam', N'Nam', N'2003-01-20',N'Tiền Giang', N'0339774153', N'191803A')
insert into SinhVien Values (N'211107', N'Nguyễn Thị Hồng Ngọc', N'Nữ', N'2003-05-17',N'Tây Ninh', N'0348774724', N'191803B')
insert into SinhVien Values (N'211108', N'Bùi Thị Tố Như', N'Nữ', N'2003-05-04',N'Quảng Trị', N'0305412034', N'211203A')
insert into SinhVien Values (N'211109', N'Nguyễn Tiến Đạt', N'Nam', N'2003-11-15',N'Đà Lạt', N'0377334215', N'211203B')
insert into SinhVien Values (N'211110', N'Nguyễn Thanh Trọng', N'Nam', N'2003-06-12',N'Quảng Nam', N'0333557746', N'211102A')

insert into DangKy Values (N'211101', N'LHP01', N'2023-08-08') 
insert into DangKy Values (N'211101', N'LHP02', N'2023-08-08') 
insert into DangKy Values (N'211102', N'LHP03', N'2023-08-08') 
insert into DangKy Values (N'211103', N'LHP04', N'2023-08-08') 
insert into DangKy Values (N'211104', N'LHP05', N'2023-08-09') 
insert into DangKy Values (N'211105', N'LHP01', N'2023-08-08') 
insert into DangKy Values (N'211106', N'LHP02', N'2023-08-09') 
insert into DangKy Values (N'211107', N'LHP03', N'2023-08-09') 
insert into DangKy Values (N'211108', N'LHP04', N'2023-08-08') 
insert into DangKy Values (N'211109', N'LHP05', N'2023-08-08') 
insert into DangKy Values (N'211110', N'LHP05', N'2023-08-08')

insert into ChuongTrinhDaoTao values ('N001','INIT130185',N'Bắt buộc')
insert into ChuongTrinhDaoTao values ('N001','ECOM430984',N'Tự chọn')
insert into ChuongTrinhDaoTao values ('N001','INPR130285',N'Bắt buộc')
insert into ChuongTrinhDaoTao values ('N010','BENG330708',N'Bắt buộc')
insert into ChuongTrinhDaoTao values ('N010','BLAW232408',N'Bắt buộc')
insert into ChuongTrinhDaoTao values ('N011','STMA230521',N'Bắt buộc')


alter table Khoa add TruongKhoa varchar(20) references GiangVien (MaGiangVien)
update Khoa SET TruongKhoa = '001' WHERE MaKhoa='K001';
update Khoa SET TruongKhoa = '005' WHERE MaKhoa='K002';
update Khoa SET TruongKhoa = '008' WHERE MaKhoa='K003';

alter table BoMon add TruongBoMon varchar (20) references GiangVien (MaGiangVien)
update BoMon set TruongBoMon = '002' where MaBoMon = '2'
update BoMon set TruongBoMon = '007' where MaBoMon = '6'


-- load thông tin sinh viên ở form quảng trị
CREATE FUNCTION [dbo].[fLoadDSSV]()
RETURNS TABLE AS RETURN
(
SELECT *
FROM SinhVien
)

-- Tìm thông tin sinh viên từ mã số sv trong quảng trị
CREATE FUNCTION [dbo].[TimKiemSinhVienTheoMa]
(
    @MaSinhVien NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM SinhVien WHERE MaSV = @MaSinhVien
);

-- Xóa thông tin một sinh viên
CREATE PROCEDURE [dbo].[proc_xoaSinhVien]
@MaSV nchar(10)
AS
BEGIN
	BEGIN TRANSACTION
		BEGIN TRY
			DELETE FROM dbo.SinhVien WHERE SinhVien.MaSV = @MaSV
		END TRY
		BEGIN CATCH
			DECLARE @err NVARCHAR(MAX)
			SELECT @err = N'Lỗi' + ERROR_MESSAGE()
			RAISERROR(@err, 16, 1)
			ROLLBACK TRANSACTION;
			THROW;
		END CATCH
	COMMIT TRANSACTION;
END

-- Cập nhật lại thông tin sinh viên
CREATE   PROC [dbo].[CapNhatThongTinSinhVien]
(
    @MaSV VARCHAR(10), 
    @HoTen NVARCHAR(50), 
    @GioiTinh NCHAR(10),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(100),
	@SoDienThoai VARCHAR (10),
    @MaLop CHAR(10)
)
AS
BEGIN
	BEGIN TRY
	     UPDATE SinhVien
		SET [HoTen] = @HoTen,
		[GioiTinh] = @GioiTinh,
		[NgaySinh] = @NgaySinh,
		[DiaChi] = @DiaChi,
		[SoDienThoai]=@SoDienThoai,
		[MaLop] = @MaLop
		WHERE [MaSV] = @MaSV	
END TRY        
BEGIN CATCH
	DECLARE @err NVARCHAR(MAX)
    SELECT @err = N'Lỗi' + ERROR_MESSAGE()
	RAISERROR(@err,16,1)
END CATCH
END

-- Thêm sinh viên
CREATE PROC [dbo].[InsertSV]
	@MaSV VARCHAR(10), 
    @HoTen NVARCHAR(50), 
    @GioiTinh NCHAR(10),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(100),
	@SoDienThoai VARCHAR (10),
    @MaLop CHAR(10)
AS
	INSERT INTO SinhVien(MaSV, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai,MaLop)
	VALUES (@MaSV, @HoTen, @GioiTinh, @NgaySinh, @DiaChi,@SoDienThoai ,@MaLop)

-- Trigger bắt lỗi khi thêm sửa sinh viên
CREATE TRIGGER trg_CheckSinhVien
ON SinhVien
FOR INSERT, UPDATE
AS
BEGIN
	-- check MaSV
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(MaSV) = ' ')
	BEGIN
		RAISERROR('Mã sinh viên không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	IF NOT EXISTS (SELECT * FROM SinhVien WHERE MaSV IN (SELECT MaSV FROM
	inserted))
		BEGIN
		RAISERROR('Mã giảng viên đã tồn tại', 16, 1)
		ROLLBACK TRANSACTION
	RETURN
	END
	-- check họ tên
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(HoTen) = ' ')
	BEGIN
		RAISERROR('Tên sinh viên không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	-- check ngay sinh
	IF EXISTS (
	SELECT * FROM inserted WHERE
	datediff(year,inserted.NgaySinh,getdate())<(18)
	)
	BEGIN
		RAISERROR ('Sinh viên phải trên 18 tuổi', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	-- check dia chi
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(DiaChi) = '' )
	BEGIN
		RAISERROR('Địa chỉ không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	-- check so dien thoai
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(SoDienThoai) = '' )
	BEGIN
		RAISERROR('Số điện thoại không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	IF NOT EXISTS (SELECT * FROM inserted WHERE len(TRIM(SoDienThoai)) = (10))
	BEGIN
		RAISERROR('Số điện thoại gồm 10 chữ số', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	IF EXISTS (SELECT 1 FROM inserted i INNER JOIN SinhVien n ON i.MaSV != n.MaSV
	AND TRIM(i.SoDienThoai) = TRIM(n.SoDienThoai))
	BEGIN
		RAISERROR('Số điện thoại đã tồn tại', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	-- check ma bo mon
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(MaLop) = '' )
	BEGIN
		RAISERROR('Mã bộ môn không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	IF NOT EXISTS (SELECT 1 FROM inserted i INNER JOIN BoMon n ON i.MaLop != n.MaLop)
	BEGIN
		RAISERROR('Mã lớp không tồn tại', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
END
-- load thông tin giáo viên ở form quản trị
CREATE FUNCTION [dbo].[fLoadDSGV]()
RETURNS TABLE AS RETURN
(
SELECT 
	GiangVien.MaGiangVien,
    GiangVien.HoTen,
    GiangVien.GioiTinh,
    GiangVien.NgaySinh,
    GiangVien.TrinhDo,
    GiangVien.DiaChi,
    GiangVien.SoDienThoai,
	Khoa.TenKhoa,
	BoMon.TenBoMon,
	Khoa.MaKhoa,
    Khoa.TruongKhoa,
    BoMon.TruongBoMon
FROM 
    Khoa JOIN BoMon ON Khoa.MaKhoa = BoMon.MaKhoa
JOIN GiangVien ON BoMon.MaBoMon = GiangVien.MaBoMon
)

-- Tìm thông tin giáo viên từ mã giáo viên trong quản trị
CREATE FUNCTION [dbo].[TimKiemGiangVienTheoMa]
(
    @MaGV NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN (
    SELECT 
	GiangVien.MaGiangVien,
    GiangVien.HoTen,
    GiangVien.GioiTinh,
    GiangVien.NgaySinh,
    GiangVien.TrinhDo,
    GiangVien.DiaChi,
    GiangVien.SoDienThoai,
	Khoa.TenKhoa,
	BoMon.TenBoMon,
	Khoa.MaKhoa,
    Khoa.TruongKhoa,
    BoMon.TruongBoMon
FROM 
    Khoa JOIN BoMon ON Khoa.MaKhoa = BoMon.MaKhoa
JOIN GiangVien ON BoMon.MaBoMon = GiangVien.MaBoMon
WHERE MaGiangVien = @MaGV
);

-- Xóa thông tin một giảng viên
CREATE PROCEDURE [dbo].[proc_xoaGiangVien]
@MaGiangVien varchar(10)
AS
BEGIN
BEGIN TRANSACTION
BEGIN TRY
DELETE FROM dbo.Khoa WHERE Khoa.TruongKhoa = @MaGiangVien
DELETE FROM dbo.BoMon WHERE BoMon.TruongBoMon = @MaGiangVien
DELETE FROM dbo.GiangVien WHERE GiangVien.MaGiangVien = @MaGiangVien
COMMIT TRAN
END TRY
BEGIN CATCH
ROLLBACK
DECLARE @err NVARCHAR(MAX)
SELECT @err = N'Lỗi' + ERROR_MESSAGE()
RAISERROR(@err, 16, 1)
END CATCH
END


-- Cập nhật lại thông tin giảng viên
CREATE   PROC [dbo].[CapNhatThongTinGiangVien]
(
    @MaGiangVien VARCHAR(20), 
    @HoTen NVARCHAR(100), 
    @GioiTinh NCHAR(10),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(80),
	@SoDienThoai VARCHAR (10),
	@TrinhDo nvarchar (20),
    @MaBoMon NVARCHAR(10)
)
AS
BEGIN TRY
	     UPDATE GiangVien
		SET [HoTen] = @HoTen,
		[GioiTinh] = @GioiTinh,
		[NgaySinh] = @NgaySinh,
		[DiaChi] = @DiaChi,
		[SoDienThoai]=@SoDienThoai,
		[TrinhDo] = @TrinhDo,
		[MaBoMon] = @MaBoMon
		WHERE [MaGiangVien] = @MaGiangVien	
END TRY        
BEGIN CATCH
DECLARE @err NVARCHAR(MAX)
	SELECT @err = N'Lỗi ' + ERROR_MESSAGE()
    RAISERROR(@err,25,1)
END CATCH

-- Thêm giảng viên
CREATE PROC [dbo].[InsertGV]
    @MaGiangVien VARCHAR(20), 
    @HoTen NVARCHAR(100), 
    @GioiTinh NCHAR(10),
    @NgaySinh DATE,
    @DiaChi NVARCHAR(80),
	@SoDienThoai VARCHAR (10),
	@TrinhDo nvarchar (20),
    @MaBoMon VARCHAR(10)
AS
	INSERT INTO GiangVien(MaGiangVien, HoTen, GioiTinh, NgaySinh, DiaChi, SoDienThoai,TrinhDo,MaBoMon)
	VALUES (@MaGiangVien, @HoTen, @GioiTinh, @NgaySinh, @DiaChi,@SoDienThoai ,@TrinhDo, @MaBoMon)


-- Trigger bắt lỗi khi thêm hoặc sửa thông tin giảng viên
CREATE TRIGGER trg_CheckGiangVien
ON GiangVien
FOR INSERT, UPDATE
AS
BEGIN
	-- check MaNV
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(MaGiangVien) = ' ')
	BEGIN
		RAISERROR('Mã giảng viên không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	IF NOT EXISTS (SELECT * FROM GiangVien WHERE MaGiangVien IN (SELECT MaGiangVien FROM
	inserted))
		BEGIN
		RAISERROR('Mã giảng viên đã tồn tại', 16, 1)
		ROLLBACK TRANSACTION
	RETURN
	END
	-- check họ tên
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(HoTen) = ' ')
	BEGIN
		RAISERROR('Tên giảng viên không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	-- check ngay sinh
	IF EXISTS (
	SELECT * FROM inserted WHERE
	datediff(year,inserted.NgaySinh,getdate())<(18)
	)
	BEGIN
		RAISERROR ('Giảng viên phải trên 18 tuổi', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	-- check dia chi
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(DiaChi) = '' )
	BEGIN
		RAISERROR('Địa chỉ không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	-- check trình độ
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(TrinhDo) = '' )
	BEGIN
		RAISERROR('Trình độ không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	-- check so dien thoai
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(SoDienThoai) = '' )
	BEGIN
		RAISERROR('Số điện thoại không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	IF NOT EXISTS (SELECT * FROM inserted WHERE len(TRIM(SoDienThoai)) = (10))
	BEGIN
		RAISERROR('Số điện thoại gồm 10 chữ số', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	IF EXISTS (SELECT 1 FROM inserted i INNER JOIN GiangVien n ON i.MaGiangVien != n.MaGiangVien
	AND TRIM(i.SoDienThoai) = TRIM(n.SoDienThoai))
	BEGIN
		RAISERROR('Số điện thoại đã tồn tại', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	-- check ma bo mon
	IF EXISTS (SELECT * FROM inserted WHERE TRIM(MaBoMon) = '' )
	BEGIN
		RAISERROR('Mã bộ môn không được để trống', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
	IF NOT EXISTS (SELECT 1 FROM inserted i INNER JOIN BoMon n ON i.MaBoMon != n.MaBoMon)
	BEGIN
		RAISERROR('Mã bộ môn không tồn tại', 16, 1)
		ROLLBACK TRANSACTION
		RETURN
	END
END





-- HỌC PHẦN

-- Tìm theo mã học phần
CREATE FUNCTION [dbo].[TimKiemMaHocPhan]
(
    @MaHocPhan NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM HocPhan WHERE MaHocPhan = @MaHocPhan
);

-- Tìm theo tên học phần
CREATE FUNCTION [dbo].[TimKiemTenHocPhan]
(
    @TenHocPhan NVARCHAR(50)
)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM HocPhan WHERE TenHocPhan = @TenHocPhan
);


-- CHƯƠNG TRÌNH ĐÀO TẠO


-- Tìm	     CHƯƠNG TRÌNH ĐÀO TẠO    theo        mã ngành
CREATE FUNCTION [dbo].[TimKiemChuongTrinhDaoTao_MaNganh]
(
    @MaNganh VARCHAR(10)
)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM ChuongTrinhDaoTao WHERE MaNganh = @MaNganh
);




-- Tìm	     CHƯƠNG TRÌNH ĐÀO TẠO    theo        mã học phần

CREATE FUNCTION [dbo].[TimKiemChuongTrinhDaoTao_MaNganh]
(
    @MaHocPhan VARCHAR(10)
)
RETURNS TABLE
AS
RETURN (
    SELECT * FROM ChuongTrinhDaoTao WHERE MaHocPhan = @MaHocPhan
);



-- Thêm chương trình đào tạo
CREATE   PROC [dbo].[ThemChuongTrinhDaoTao]
(
    @MaNganh VARCHAR(10), 
    @MaHocPhan NVARCHAR(10), 
    @LoaiHocPhan NVARCHAR(30)
)
AS
BEGIN
    DECLARE @CTDTCount int
    BEGIN TRANSACTION
	    INSERT INTO ChuongTrinhDaoTao(MaHocPhan,MaNganh,LoaiHocPhan)
		VALUES (@MaHocPhan, @MaNganh, @LoaiHocPhan)
	
		
		SELECT @CTDTCount = COUNT(*) FROM ChuongTrinhDaoTao WHERE MaHocPhan = @MaHocPhan and MaNganh=@MaNganh
		IF( @CTDTCount > 1)
        BEGIN
            RAISERROR('Hoc Phan da thuoc Nganh',25,1)
            ROLLBACK
        END
        ELSE
        BEGIN
            COMMIT
        END 
END


-- Xóa Chương trình đào tạo
CREATE PROCEDURE XoaChuongTrinhDaoTao
@MaNganh varchar(10),
@MaHocPhan varchar(10)
AS
BEGIN
DELETE
FROM ChuongTrinhDaoTao
WHERE [MaNganh] = @MaNganh and [MaHocPhan] = @MaHocPhan
END


-- Sửa chương trình đào tạo
CREATE   PROC [dbo].[CapNhatChuongTrinhDaoTao]
(
    @MaNganh VARCHAR(10), 
    @MaHocPhan NVARCHAR(10), 
    @LoaiHocPhan NVARCHAR(30)
)
AS
BEGIN TRY
    BEGIN TRANSACTION
	     UPDATE ChuongTrinhDaoTao
		SET 
		[LoaiHocPhan] = @LoaiHocPhan
		WHERE [MaNganh] = @MaNganh and MaHocPhan=@MaHocPhan	
		COMMIT
END TRY        
BEGIN CATCH
    RAISERROR('Thong tin sai, khong the update',25,1)
    ROLLBACK
END CATCH



--View xem các học phần có trong kì
CREATE VIEW V_DanhSachHocPhan AS
SELECT MaHocPhan, TenHocPhan, SoTinChi, SoTiet
FROM dbo.HocPhan
WHERE HocKy=hocky
GO

--View xem các lớp học phần có trong kì
CREATE VIEW V_DanhSachLopHocPhan AS
SELECT MaLopHP, NgayBatDau, NgayKetThuc, Phonghoc, Thu, Tiet
FROM dbo.LopHocPhan
GO


--View xem danh sách giảng viên
CREATE VIEW V_DanhSachGiangVien AS
SELECT MaGiangVien, HoTen, SoDienThoai, MaBoMon
FROM dbo.GiangVien
GO



--View xem danh sách sinh viên trong lớp
CREATE VIEW V_DanhSachSinhVien AS
SELECT MaSV, HoTen, SoDienThoai
FROM dbo.SinhVien
WHERE MaLop = malop
GO


--View xem danh sách Khoa
CREATE VIEW V_DanhSachKhoa AS
SELECT MaKhoa, TenKhoa, NamThanhLap
FROM dbo.Khoa
GO

--View xem danh sách Ngành
CREATE VIEW V_DanhSachNganh AS
SELECT MaNganh, TenNganh
FROM dbo.Nganh
GO

-- Thông báo khi hủy lớp học phần của sinh viên
CREATE TRIGGER tg_NotiDeleteLHPSV on DangKy
FOR DELETE
AS
BEGIN
DECLARE @MaLopHP nchar(10)
SELECT @MaLopHP = ol.MaLopHP
FROM Deleted as ol
IF (@MaLopHP NOT IN (SELECT MaLopHP FROM DangKy))
PRINT (N'Đã hủy lớp học phần ' + RTRIM(@MaLopHP))
END


-- Thông báo khi xóa sinh viên của quản trị viên
CREATE TRIGGER tg_NotiDeleteSV on SinhVien
FOR DELETE
AS
BEGIN
DECLARE @MaSV nchar(10)
SELECT @MaSV = ol.MaSV
FROM Deleted as ol
IF (@MaSV NOT IN (SELECT MaSV FROM SinhVien))
PRINT N'Đã xóa sinh viên ' + RTRIM(@MaSV)
END

-- Thông báo khi xóa lớp học phần của quản trị viên
CREATE TRIGGER tg_NotiDeleteLHP on LopHocPhan
FOR DELETE
AS
BEGIN
DECLARE @MaLopHP nchar(10)
SELECT @MaLopHP = ol.MaLopHP
FROM Deleted as ol
IF (@MaLopHP NOT IN (SELECT MaLopHP FROM LopHocPhan))
PRINT (N'Đã xóa học phần ' + RTRIM(@MaLopHP))
END

--Thông báo khi thêm hoặc cập nhật sinh viên của quản trị viên
CREATE TRIGGER tg_KTNhapTTSinhVien on SinhVien
FOR INSERT, UPDATE AS
BEGIN
DECLARE @MaSV nchar(10), @HoTen nvarchar(50)
SELECT @MaSV = ne.MaSV, @HoTen = ne.HoTen
FROM Inserted as ne
IF (RTRIM(@MaSV) = '')
BEGIN
PRINT(N'Hãy nhập mã SV')
ROLLBACK
END
ELSE IF (RTRIM(@HoTen) = '')
BEGIN
PRINT(N'Hãy nhập tên SV')
ROLLBACK
END
END


-- Kiểm tra giới tính khi thêm hoặc cập nhật
CREATE TRIGGER tg_ktGioiTinh ON SinhVien
FOR INSERT, UPDATE
AS
BEGIN
DECLARE @MaSV nchar(10), @GioiTinh nvarchar(50)
SELECT @MaSV = ne.MaSV, @GioiTinh = ne.GioiTinh
FROM INSERTED ne
IF (RTRIM(@GioiTinh) = '')
BEGIN
UPDATE SinhVien
SET GioiTinh = N'N/A'
WHERE MaSV = @MaSV
END
END



CREATE TRIGGER KiemtraTrungHP ON DangKy
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM DangKy dk
        JOIN inserted i ON dk.MaLopHP = i.MaLopHP
    )
    BEGIN
        RAISERROR('Học phần đã tồn tại trong đăng ký', 16, 1);
        ROLLBACK TRANSACTION; -- Không cho phép chèn dữ liệu
    END;
END;

-- chưa xong
CREATE TRIGGER TG_TrungMaLopHP
ON dbo.DangKy
AFTER INSERT, UPDATE
AS
IF EXISTS (SELECT 1 FROM inserted i INNER JOIN DangKy d ON i.MaLopHP != d.MaLopHP
AND TRIM(i.MaLopHP) = TRIM(d.MaLopHP))
BEGIN
 RAISERROR('Lớp học phần đã tồn tại', 16, 1)
 ROLLBACK TRANSACTION
 RETURN
 END


