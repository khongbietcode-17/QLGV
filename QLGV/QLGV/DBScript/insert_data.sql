use QLGV;

-- BoMon
INSERT INTO BoMon (TenBoMon) 
VALUES (N'Toán');

INSERT INTO BoMon (TenBoMon) 
VALUES (N'Ngữ Văn');

INSERT INTO BoMon (TenBoMon) 
VALUES (N'Lịch Sử');

INSERT INTO BoMon (TenBoMon) 
VALUES (N'Địa Lí');

INSERT INTO BoMon (TenBoMon) 
VALUES (N'Giáo Dục Công Dân');

INSERT INTO BoMon (TenBoMon) 
VALUES (N'Sinh Học');

INSERT INTO BoMon (TenBoMon) 
VALUES (N'Vật Lí');

INSERT INTO BoMon (TenBoMon) 
VALUES (N'Hoá Học');


-- Giao Vien table
INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Nguyen', N'Anh Tu', 1, '1980-05-15', N'Hà Nội', 'nguyen.anh.tu@gmail.com', '0912345678', 1);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Tran', N'Thi Lan', 2, '1990-11-25', N'Hồ Chí Minh', 'tran.thi.lan@outlook.com', '0987654321', 2);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Le', N'Minh Tu', 1, '1985-01-10', N'Đà Nẵng', 'le.minhtu@gmail.com', '0901234567', 3);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Hoang', N'Thanh Mai', 2, '1992-07-20', N'Hải Phòng', 'hoang.thanhmai@gmail.com', '0934567890', 1);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Phan', N'Hoang Nam', 1, '1978-12-30', N'Cần Thơ', 'phan.hoangnam@icloud.com', '0912347890', 2);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Nguyen', N'Mai Lan', 2, '1995-03-18', N'Bắc Ninh', 'nguyen.mai.lan@yahoo.com', '0945671234', 4);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Dang', N'Thi Mai', 2, '1983-10-12', N'Thanh Hóa', 'dang.thimai@gmail.com', '0967890123', 5);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Bui', N'Thu Hoa', 2, '1991-08-14', N'Quảng Ninh', 'bui.thuhoa@gmail.com', '0976543210', 3);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Pham', N'Quang Hieu', 1, '1988-02-25', N'Thái Nguyên', 'pham.quanghieu@gmail.com', '0906549876', 4);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Truong', N'Thuy Linh', 2, '1993-04-02', N'Nghệ An', 'truong.thuylinh@hotmail.com', '0912348888', 5);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Vu', N'Minh Thi', 1, '1981-09-30', N'Vinh Phúc', 'vu.minhthi@gmail.com', '0923456789', 1);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Nguyen', N'Thi Lan', 2, '1990-12-18', N'Hà Nội', 'nguyen.thilan@gmail.com', '0943672589', 3);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Le', N'Ngoc Hoa', 2, '1987-06-21', N'Bình Dương', 'le.ngochhoa@gmail.com', '0907654321', 2);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Phan', N'Nguyen Mai', 2, '1984-11-05', N'Hải Dương', 'phan.nguyenmai@outlook.com', '0982345678', 4);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Hoang', N'Thi Thuy', 2, '1992-09-28', N'Lạng Sơn', 'hoang.thithuy@gmail.com', '0978765432', NULL);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Truong', N'Khai An', 1, '1980-05-19', N'Hà Nội', 'truong.khaian@gmail.com', '0932233445', NULL);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Vũ', N'Hồng Quang', 1, '1989-10-02', N'Hồ Chí Minh', 'vu.hongquang@gmail.com', '0909786543', 2);

INSERT INTO GiaoVien (HoLot, Ten, GioiTinh, NgaySinh, DiaChi, Email, SoDienThoai, BoMonId) 
VALUES (N'Bùi', N'Bích Hằng', 2, '1995-01-13', N'Vũng Tàu', 'bui.bichhang@live.com', '0934567890', 1);


-- ChucVu

INSERT INTO ChucVu (TenChucVu)
VALUES (N'Chủ Nhiệm');

INSERT INTO ChucVu (TenChucVu)
VALUES (N'Tổ Trưởng Bộ Môn');

INSERT INTO ChucVu (TenChucVu)
VALUES (N'Tổ Phó Bộ Môn');

INSERT INTO ChucVu (TenChucVu)
VALUES (N'Chủ Tịch Công Đoàn');

INSERT INTO ChucVu (TenChucVu)
VALUES (N'Phó Hiệu Trưởng');

INSERT INTO ChucVu (TenChucVu)
VALUES (N'Hiệu Trưởng');


INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (1,1)

INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (1,2)

INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (2,1)

INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (2,2)

INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (3,4)

INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (4,5)

INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (4,6)

INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (4,1)

INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (5,1)

INSERT INTO PhanCong(GiaoVienId, ChucVuId)
VALUES (6,1)



INSERT INTO ChuNhiem(GiaoVienId, TenLop, NamHoc)
VALUES (1,'12A1','2024-2025')

INSERT INTO ChuNhiem(GiaoVienId, TenLop, NamHoc)
VALUES (2,'12A2','2024-2025')

INSERT INTO ChuNhiem(GiaoVienId, TenLop, NamHoc)
VALUES (4,'12A3','2024-2025')

INSERT INTO ChuNhiem(GiaoVienId, TenLop, NamHoc)
VALUES (5,'12A4','2024-2025')

INSERT INTO ChuNhiem(GiaoVienId, TenLop, NamHoc)
VALUES (6,'12A5','2024-2025')


INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (1, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (2, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (3, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (4, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (5, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (6, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (7, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (8, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (9, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (10, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (11, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (12, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (13, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (14, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (15, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (16, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (17, 4.4, 0, 10296000)

INSERT INTO BangLuong(GiaoVienId, HeSoLuong, HeSoPhuCap, Luong)
VALUES (18, 4.4, 0, 10296000)

INSERT INTO LuongCoSo(LuongCoSo, UpdateAt)
VALUES (2340000, '2024-11-26 20:30:00')

INSERT INTO UserTbl(UserName, Password) 
VALUES('admin', 'admin123')