create database SinhVien;
go
use SinhVien;
go

create table SinhVien(
	ID int IDENTITY(1,1),
	mSV char(10) primary key,
	tenSV nvarchar(100),
	namsinh int,
	gioitinh nvarchar(10),
	quequan nvarchar(100));

create table MonHoc(
	ID int IDENTITY(1,1),
	mMH char(10) primary key,
	tenMH nvarchar(100),
	thongtin text);

create table GiangVien(
	ID int IDENTITY(1,1),
	mGV char(10) primary key,
	tenGV nvarchar(100),
	namsinh int,
	gioitinh nvarchar(10),
	quequan nvarchar(100));

create table KQHocTap(
	ID int IDENTITY(1,1),
	mSV char(10) references SinhVien(mSV),
	mMH char(10) references MonHoc(mMH),
	mGV char(10) references GiangVien(mGV),
	diem real check (diem >= 0 and diem <= 10));

insert into SinhVien
	values 
	('SV01', N'Trần Văn Anh Tú', '2002', N'Nam', N'Hà Nội'),
	('SV02', N'Nguyễn Thị Bình', '2002', N'Nữ', N'Yên Bái'),
	('SV03', N'Lê Minh Tuấn', '2002', N'Nam', N'Lào Cai'),
	('SV04', N'Nguyễn Việt Hoàng', '2002', N'Nam', N'Hải Dương'),
	('SV05', N'Lê Bảo Linh', '2002', N'Nữ', N'Hồ Chí Minh'),
	('SV06', N'Nguyễn Thị Phương', '2002', N'Nữ', N'Lạng Sơn'),
	('SV07', N'Phạm Quang Huy', '2002', N'Nam', N'Điện Biên');

insert into MonHoc
	values
	('MH01', N'Toán Đại Số', N''),
	('MH02', N'Toán Giải Tích', N''),
	('MH03', N'Kĩ thuật đồ họa', N''),
	('MH04', N'Hệ trợ giúp quyết định', N''),
	('MH05', N'Ngôn Ngữ Java', N'');

insert into GiangVien
	values
	('GV01', N'Lê Thuý Loan', '1986', N'Nữ', N'Bắc Ninh'),
	('GV02', N'Phạm Nhật Vượng', '1972', N'Nam', N'Đà Lạt'),
	('GV03', N'Nguyễn Thanh Minh', '1980', N'Nam', N'Hạ Long'),
	('GV04', N'Hoàng Mạnh Hà', '1990', N'Nữ', N'Hà Nội'),
	('GV05', N'Trần Thủ Độ', '1974', N'Nam', N'Thanh Hoá');

insert into KQHocTap
	values
	('SV01', 'MH05', 'GV02', '9'),
	('SV02', 'MH02', 'GV04', '2'),
	('SV03', 'MH03', 'GV03', '4'),
	('SV04', 'MH04', 'GV01', '3'),
	('SV05', 'MH01', 'GV01', '1'),
	('SV06', 'MH04', 'GV02', '5'),
	('SV07', 'MH02', 'GV05', '8'),
	('SV01', 'MH03', 'GV05', '10'),
	('SV02', 'MH05', 'GV03', '7'),
	('SV03', 'MH02', 'GV02', '5'),
	('SV04', 'MH01', 'GV03', '2'),
	('SV05', 'MH03', 'GV01', '3'),
	('SV06', 'MH04', 'GV04', '1'),
	('SV07', 'MH02', 'GV02', '2'),
	('SV05', 'MH03', 'GV05', '4');

