
CREATE DATABASE QLSV2
GO
USE QLSV2
GO
CREATE TABLE Khoa (
    MaKhoa nVARCHAR(6) PRIMARY KEY NOT NULL,
    TenKhoa nVARCHAR(30) NOT NULL
);

CREATE TABLE SinhVien (
  MaSo INT PRIMARY KEY NOT NULL,
  HoTen nVARCHAR(50) NOT NULL,
  NgaySinh DATETIME NOT NULL,
  GioiTinh BIT NOT NULL,
  DiaChi nVARCHAR(50) NOT NULL,
  DienThoai INT NOT NULL,
  MaKhoa nVARCHAR(6) NOT NULL,
  FOREIGN KEY (MaKhoa) REFERENCES Khoa(MaKhoa)
)

CREATE TABLE Mon (
    MaMH nVARCHAR(6) PRIMARY KEY NOT NULL,
    TenMH nVARCHAR(50) NOT NULL,
	SoTiet INT NOT NULL
);

CREATE TABLE KetQua (
    MaSo INT NOT NULL,
    MaMH nVARCHAR(6) NOT NULL,
    Diem INT,
	PRIMARY KEY(MaSo, MaMH),
	FOREIGN KEY (MaSo) REFERENCES SinhVien(MaSo),
	FOREIGN KEY (MaMH) REFERENCES Mon(MaMH)
);
INSERT INTO Khoa (MaKhoa, TenKhoa) VALUES 
('CNTP', N'Công Nghệ Thực Phẩm'),
('CNTT', N'Công Nghệ Thông Tin'),
('DDT', N'Điện-Điện Tử'),
('MT', N'Môi Trường'),
('NN', N'Ngoại Ngữ'),
('QTKD', N'Quản Trị Kinh Doanh')

INSERT INTO Mon (MaMH, TenMH, SoTiet) VALUES 
('LTWD', N'Lập Trình Window', 45),
('CSDL', N'Cơ Sở Dữ Liệu', 45),
('CTDL', N'Cấu Trúc Dữ Liệu', 60),
('KTLT', N'Kỹ Thuật Lập Trình', 45),
('NP', N'Ngữ Pháp', 30),
('DHI', N'Đọc Hiểu', 30),
('NN', N'Nghe Nói', 45),
('NVA', N'Ngữ Văn Anh', 30),
('DHO', N'Đồ Họa', 45),
('VS', N'Vi Sinh', 45),
('HH', N'Hóa Học', 45)

INSERT INTO SinhVien (MaSo, HoTen, NgaySinh, GioiTinh, DiaChi, DienThoai, MaKhoa) VALUES
(100, N'Nguyễn Văn Sơn', '2003-11-30', 1, N'32 Đường Nguyễn Huệ, Quận 2, TP HCM', '0901234567', 'CNTP'),
(101, N'Nguyễn Văn An', '2003-12-20', 1, N'123 Đường Lê Lợi, Quận 1, TP HCM', '0901234567', 'CNTT'),
(102, N'Trần Thị Bích', '2003-03-04', 0, N'456 Đường Nguyễn Huệ, Quận 2, TP HCM', '0909876543', 'CNTP'),
(103, N'Lê Văn Cường', '2003-04-19', 1, N'789 Đường Trần Hưng Đạo, Quận 3, TP HCM', '0905678912', 'DDT'),
(104, N'Phạm Thị Đào', '2003-01-10', 0, N'321 Đường Võ Văn Kiệt, Quận 4, TP HCM', '0902468135', 'DDT'),
(105, N'Hoàng Văn Hải', '2003-09-20', 1, N'654 Đường Nguyễn Văn Cừ, Quận 5, TP HCM', '0901357924', 'MT'),
(106, N'Nguyễn Thị Hoàng', '2003-10-23', 0, N'987 Đường Trường Sơn, Quận 6, TP HCM', '0905792468', 'MT'),
(107, N'Trần Văn Gia', '2003-12-26', 1, N'258 Đường Trần Quang Khải, Quận 7, TP HCM', '0902468135', 'NN'),
(108, N'Lê Thị Hoa', '2003-11-15', 0, N'369 Đường Lý Tự Trọng, Quận 1, TP HCM', '0908912345', 'QTKD'),
(109, N'Nguyễn Văn An', '2003-11-30', 1, N'33 Đường Nguyễn Huệ, Quận 5, TP HCM', '0901234567', 'CNTP')

INSERT INTO KetQua (MaSo, MaMH, Diem) VALUES
(100, 'HH', 9),
(100, 'VS', 7),
(100, 'NN', 8),
(100, 'NP', 10),

(101, 'LTWD', 9),
(101, 'CTDL', 10),
(101, 'CSDL', 10),
(101, 'KTLT', 9),

(102, 'HH', 10),
(102, 'VS', 10),
(102, 'NN', 10),
(102, 'NP', 10),

(103, 'NP', 9),
(103, 'CTDL', 8),
(103, 'CSDL', 8),
(103, 'NN', 9),

(104, 'NVA', 9),
(104, 'NN', 9),
(104, 'DHI', 9),
(104, 'NP', 9),

(105, 'LTWD', 9),
(105, 'CTDL', 9),
(105, 'KTLT', 9),
(105, 'DHO', 10),

(106, 'LTWD', 9),
(106, 'NP', 8),
(106, 'NN', 8),
(106, 'DHI', 9),

(107, 'LTWD', 6),
(107, 'NP', 10),
(107, 'DHI', 9),
(107, 'NN', 7),

(108, 'NP', 9),
(108, 'DHI', 9),
(108, 'DHO', 9),
(108, 'NN', 9),

(109, 'VS', 10),
(109, 'NN', 8),
(109, 'DHI', 7),
(109, 'NVA', 9)
--*/