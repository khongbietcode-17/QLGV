use QLGV;

CREATE TABLE BoMon 
(
  Id int IDENTITY(1,1) primary key,
  TenBoMon nvarchar(100),
)

CREATE TABLE GiaoVien 
(
  Id int IDENTITY(1,1) primary key,
  HoLot nvarchar(100),
  Ten nvarchar(20),
  GioiTinh tinyint,
  NgaySinh date,
  DiaChi nvarchar(255),
  Email varchar(50),
  SoDienThoai varchar(12),
  BoMonId int FOREIGN KEY REFERENCES BoMon(Id),
)

CREATE TABLE ChucVu 
(
  Id int IDENTITY(1,1) primary key,
  TenChucVu nvarchar(200)
)

CREATE TABLE GiaoVienChucVu
(
  GiaoVienId int FOREIGN KEY REFERENCES GiaoVien(Id),
  ChucVuId int FOREIGN KEY REFERENCES ChucVu(Id),
  PRIMARY KEY (GiaoVienId, ChucVuId)
)

CREATE TABLE BangLuong
(
  GiaoVienId int primary key,
  HeSoLuong DECIMAL(3,2),
  HeSoPhuCap DECIMAL(3,2),
  Luong int,
  CONSTRAINT FK_GiaoVienId FOREIGN KEY (GiaoVienId) REFERENCES GiaoVien(Id)
)

CREATE TABLE ChuNhiem
(
  Id int IDENTITY(1,1) primary key,
  GiaoVienId int FOREIGN KEY REFERENCES GiaoVien(Id),
  TenLop varchar(5),
  NamHoc varchar(10)
)
