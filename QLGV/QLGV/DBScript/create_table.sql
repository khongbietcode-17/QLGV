use QLGV;

CREATE TABLE BoMon 
(
  BoMonId int IDENTITY(1,1) primary key,
  TenBoMon nvarchar(100),
)

CREATE TABLE GiaoVien 
(
  GiaoVienId int IDENTITY(1,1) primary key,
  HoLot nvarchar(100),
  Ten nvarchar(20),
  GioiTinh tinyint,
  NgaySinh date,
  DiaChi nvarchar(255),
  Email varchar(50),
  SoDienThoai varchar(12),
  BoMonId int FOREIGN KEY REFERENCES BoMon(BoMonId),
)

CREATE TABLE ChucVu 
(
  ChucVuId int IDENTITY(1,1) primary key,
  TenChucVu nvarchar(200)
)

CREATE TABLE PhanCong
(
  GiaoVienId int FOREIGN KEY REFERENCES GiaoVien(GiaoVienId),
  ChucVuId int FOREIGN KEY REFERENCES ChucVu(ChucVuId),
  PRIMARY KEY (GiaoVienId, ChucVuId)
)

CREATE TABLE BangLuong
(
  GiaoVienId int primary key,
  HeSoLuong DECIMAL(3,2),
  HeSoPhuCap DECIMAL(3,2),
  Luong int,
  CONSTRAINT FK_GiaoVienId FOREIGN KEY (GiaoVienId) REFERENCES GiaoVien(GiaoVienId)
)

CREATE TABLE ChuNhiem
(
  ChuNhiemId int IDENTITY(1,1) primary key,
  GiaoVienId int FOREIGN KEY REFERENCES GiaoVien(GiaoVienId),
  TenLop varchar(5),
  NamHoc varchar(10)
)
