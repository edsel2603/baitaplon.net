create table ACC(
Tendangnhap varchar(30) primary key,
Matkhau varchar(30) )



insert into ACC values('hokage26','hoasonquy')

select *from ACC

select Tendangnhap from ACC
-- Trình độ
CREATE TABLE TrinhDo (
    MaTD VARCHAR(10) NOT NULL,
    TenTD NVARCHAR(50)
);

-- Chức năng
CREATE TABLE ChucNang (
    MaChucNang VARCHAR(10) NOT NULL,
    TenChucNang NVARCHAR(50)
);

-- Chức vụ
CREATE TABLE ChucVu (
    MaChucVu VARCHAR(10) NOT NULL,
    TenChucVu NVARCHAR(50)
);

-- Chuyên môn
CREATE TABLE ChuyenMon (
    MaCM VARCHAR(10) NOT NULL,
    TenCM NVARCHAR(50)
);

-- Phòng ban
CREATE TABLE PhongBan (
    MaPhong VARCHAR(10) NOT NULL,
    TenPhong NVARCHAR(50),
    DienThoai VARCHAR(20)
);

-- Nhân viên
CREATE TABLE NhanVien (
    MaNV VARCHAR(10) NOT NULL,
    TenNV NVARCHAR(50),
    MaPhong VARCHAR(10),
    MaChucVu VARCHAR(10),
    MaTD VARCHAR(10),
    MaCM VARCHAR(10),
    DiaChi NVARCHAR(100),
    NgaySinh DATE,
    GioiTinh NVARCHAR(10),
    DienThoai VARCHAR(20),
    Mobile VARCHAR(20),
    Email VARCHAR(50)
);

-- Thể loại
CREATE TABLE TheLoai (
    MaTheLoai VARCHAR(10) NOT NULL,
    TenTheLoai NVARCHAR(50)
);

-- Báo
CREATE TABLE Bao (
    MaBao VARCHAR(10) NOT NULL,
    TenBao NVARCHAR(100),
    DiaChi NVARCHAR(100),
    MaChucNang VARCHAR(10),
    DienThoai VARCHAR(20)
);

-- Báo - Thể loại
CREATE TABLE Bao_TheLoai (
    MaBao VARCHAR(10) NOT NULL,
    MaTheLoai VARCHAR(10) NOT NULL
);

-- Lĩnh vực hoạt động
CREATE TABLE LinhVucHoatDong (
    MaLVHD VARCHAR(10) NOT NULL,
    TenLVHD NVARCHAR(100)
);

-- Khách hàng
CREATE TABLE KhachHang (
    MaKH VARCHAR(10) NOT NULL,
    TenKH NVARCHAR(50),
    DiaChi NVARCHAR(100),
    DienThoai VARCHAR(20),
    DiDong VARCHAR(20),
    Email VARCHAR(50),
    MaLVHD VARCHAR(10)
);

-- Thông tin quảng cáo
CREATE TABLE TTQuangCao (
    MaQC VARCHAR(10) NOT NULL,
    TenQC NVARCHAR(100)
);

-- Bảng giá
CREATE TABLE BangGia (
    MaBao VARCHAR(10) NOT NULL,
    MaQC VARCHAR(10) NOT NULL,
    DonGia DECIMAL(18, 2)
);

-- Khách gửi bài
CREATE TABLE KhachGuiBai (
    MaLanGui VARCHAR(10) NOT NULL,
    MaKH VARCHAR(10),
    MaTheLoai VARCHAR(10),
    MaNV VARCHAR(10),
    TieuDe NVARCHAR(200),
    NoiDung NVARCHAR(MAX),
    NgayDang DATE,
    NhuanBut DECIMAL(18, 2)
);

-- Khách quảng cáo
CREATE TABLE Khach_QuangCao (
    MaLanQC VARCHAR(10) NOT NULL,
    MaKH VARCHAR(10),
    MaBao VARCHAR(10),
    MaNV VARCHAR(10),
    MaQC VARCHAR(10),
    NoiDung NVARCHAR(MAX),
    NgayBD DATE,
    NgayKT DATE,
    TongTien DECIMAL(18, 2)
);
-- Tài khoản mật khẩu
CREATE TABLE TaiKhoan (
    ID INT IDENTITY(100,1)PRIMARY KEY,
    HoTen VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL UNIQUE,
    DiaChi VARCHAR(255),
    Tendangnhap VARCHAR(255) NOT NULL UNIQUE,
    MatKhau VARCHAR(255) NOT NULL,
    Quyen INT NOT NULL CHECK (Quyen IN (1, 2, 3))
);

--THÊM KHÓA CHÍNH & KHÓA NGOẠI

-- Khóa chính
ALTER TABLE TrinhDo ADD PRIMARY KEY (MaTD);
ALTER TABLE ChucNang ADD PRIMARY KEY (MaChucNang);
ALTER TABLE ChucVu ADD PRIMARY KEY (MaChucVu);
ALTER TABLE ChuyenMon ADD PRIMARY KEY (MaCM);
ALTER TABLE PhongBan ADD PRIMARY KEY (MaPhong);
ALTER TABLE NhanVien ADD PRIMARY KEY (MaNV);
ALTER TABLE TheLoai ADD PRIMARY KEY (MaTheLoai);
ALTER TABLE Bao ADD PRIMARY KEY (MaBao);
ALTER TABLE LinhVucHoatDong ADD PRIMARY KEY (MaLVHD);
ALTER TABLE KhachHang ADD PRIMARY KEY (MaKH);
ALTER TABLE TTQuangCao ADD PRIMARY KEY (MaQC);
ALTER TABLE KhachGuiBai ADD PRIMARY KEY (MaLanGui);
ALTER TABLE Khach_QuangCao ADD PRIMARY KEY (MaLanQC);
ALTER TABLE Bao_TheLoai ADD PRIMARY KEY (MaBao, MaTheLoai);
ALTER TABLE BangGia ADD PRIMARY KEY (MaBao, MaQC);

-- Khóa ngoại
ALTER TABLE NhanVien
ADD FOREIGN KEY (MaPhong) REFERENCES PhongBan(MaPhong),
    FOREIGN KEY (MaChucVu) REFERENCES ChucVu(MaChucVu),
    FOREIGN KEY (MaTD) REFERENCES TrinhDo(MaTD),
    FOREIGN KEY (MaCM) REFERENCES ChuyenMon(MaCM);

ALTER TABLE Bao
ADD FOREIGN KEY (MaChucNang) REFERENCES ChucNang(MaChucNang);

ALTER TABLE Bao_TheLoai
ADD FOREIGN KEY (MaBao) REFERENCES Bao(MaBao),
    FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai);

ALTER TABLE KhachHang
ADD FOREIGN KEY (MaLVHD) REFERENCES LinhVucHoatDong(MaLVHD);

ALTER TABLE BangGia
ADD FOREIGN KEY (MaBao) REFERENCES Bao(MaBao),
    FOREIGN KEY (MaQC) REFERENCES TTQuangCao(MaQC);

ALTER TABLE KhachGuiBai
ADD FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaTheLoai) REFERENCES TheLoai(MaTheLoai),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV);

ALTER TABLE Khach_QuangCao
ADD FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
    FOREIGN KEY (MaBao) REFERENCES Bao(MaBao),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV),
    FOREIGN KEY (MaQC) REFERENCES TTQuangCao(MaQC);


--THÊM DỮ LIỆU
-- Trình độ
INSERT INTO TrinhDo VALUES 
('TD01', N'Cử nhân'),
('TD02', N'Thạc sĩ'),
('TD03', N'Tiến sĩ');

-- Chức năng
INSERT INTO ChucNang VALUES 
('CN01', N'Tạp chí'),
('CN02', N'Báo điện tử'),
('CN03', N'Báo in');

-- Chức vụ
INSERT INTO ChucVu VALUES 
('CV01', N'Trưởng phòng'),
('CV02', N'Phó phòng'),
('CV03', N'Nhân viên');

-- Chuyên môn
INSERT INTO ChuyenMon VALUES 
('CM01', N'Báo chí'),
('CM02', N'Marketing'),
('CM03', N'Công nghệ thông tin');

-- Phòng ban
INSERT INTO PhongBan VALUES 
('PB01', N'Phòng biên tập', '0241234567'),
('PB02', N'Phòng quảng cáo', '0246543210'),
('PB03', N'Phòng tài chính' , '024567890');

-- Nhân viên
INSERT INTO NhanVien VALUES 
('NV01', N'Nguyễn Văn An', 'PB01', 'CV01', 'TD01', 'CM01', N'Hà Nội', '1990-05-10', N'Nam', '0123456789', '0912345678', 'an.nguyen@example.com'),
('NV02', N'Trần Thị Bình', 'PB02', 'CV02', 'TD02', 'CM02', N'TP. HCM', '1992-07-15', N'Nữ', '0234567890', '0934567890', 'binh.tran@example.com');

-- Thể loại
INSERT INTO TheLoai VALUES 
('TL01', N'Thời sự'),
('TL02', N'Giải trí'),
('TL03', N'Kinh tế');

-- Báo
INSERT INTO Bao VALUES 
('B01', N'Báo Tuổi Trẻ', N'TP. HCM', 'CN03', '028123456'),
('B02', N'Báo Thanh Niên', N'Hà Nội', 'CN01', '024654321');

-- Báo - Thể loại
INSERT INTO Bao_TheLoai VALUES 
('B01', 'TL01'),
('B01', 'TL03'),
('B02', 'TL02');

-- Lĩnh vực hoạt động
INSERT INTO LinhVucHoatDong VALUES 
('LV01', N'Bất động sản'),
('LV02', N'Giáo dục'),
('LV03', N'Thương mại điện tử');

-- Khách hàng
INSERT INTO KhachHang VALUES 
('KH01', N'Công ty A', N'Hà Nội', '0249876543', '0911111111', 'congtya@example.com', 'LV01'),
('KH02', N'Trường Đại học B', N'TP. HCM', '0282222222', '0922222222', 'dhb@example.com', 'LV02');

-- Thông tin quảng cáo
INSERT INTO TTQuangCao VALUES 
('QC01', N'Banner đầu trang'),
('QC02', N'Quảng cáo giữa bài'),
('QC03', N'Pop-up');

-- Bảng giá
INSERT INTO BangGia VALUES 
('B01', 'QC01', 1500000),
('B01', 'QC02', 1000000),
('B02', 'QC03', 800000);

-- Khách gửi bài
INSERT INTO KhachGuiBai VALUES 
('LG01', 'KH01', 'TL03', 'NV01', N'Bí quyết đầu tư nhà đất', N'Nội dung bài viết...', '2025-04-15', 500000),
('LG02', 'KH02', 'TL02', 'NV02', N'Hoạt động sinh viên mùa hè', N'Nội dung sinh viên...', '2025-04-18', 300000);

-- Khách - Quảng cáo
INSERT INTO Khach_QuangCao VALUES 
('QC_L1', 'KH01', 'B01', 'NV01', 'QC01', N'Quảng cáo dự án A', '2025-04-10', '2025-04-20', 15000000),
('QC_L2', 'KH02', 'B02', 'NV02', 'QC03', N'Quảng cáo tuyển sinh', '2025-04-12', '2025-04-30', 20000000);


-- Phòng ban thêm
INSERT INTO PhongBan VALUES 
('PB04', N'Phòng IT', '0248901234'),
('PB05', N'Phòng hành chính', '0245678123');

-- Thể loại thêm
INSERT INTO TheLoai VALUES
('TL04', N'Sức khỏe'),
('TL05', N'Công nghệ'),
('TL06', N'Thể thao'),
('TL07', N'Văn hóa'),
('TL08', N'Giáo dục');

-- Báo thêm
INSERT INTO Bao VALUES 
('B03', N'Báo Lao Động', N'Đà Nẵng', 'CN02', '0236123456'),
('B04', N'Báo Người Lao Động', N'Cần Thơ', 'CN03', '0292456123'),
('B05', N'Báo VietNamNet', N'Hà Nội', 'CN01', '0249988776');

-- Lĩnh vực hoạt động thêm
INSERT INTO LinhVucHoatDong VALUES 
('LV04', N'Công nghệ thông tin'),
('LV05', N'Du lịch'),
('LV06', N'Y tế'),
('LV07', N'Vận tải'),
('LV08', N'Giải trí'),
('LV09', N'Nông nghiệp');

-- Thông tin quảng cáo thêm
INSERT INTO TTQuangCao VALUES 
('QC04', N'Video quảng cáo'),
('QC05', N'Bài PR'),
('QC06', N'Quảng cáo Sidebar'),
('QC07', N'Quảng cáo Footer');

-- Bảng giá thêm
INSERT INTO BangGia VALUES 
('B03', 'QC01', 1800000),
('B03', 'QC04', 2000000),
('B04', 'QC02', 1100000),
('B05', 'QC07', 900000);

-- Khách hàng thêm
INSERT INTO KhachHang VALUES 
('KH03', N'Công ty Công nghệ C', N'Đà Nẵng', '0236234567', '0933333333', 'congtyc@example.com', 'LV04'),
('KH04', N'Công ty Du lịch D', N'Hải Phòng', '0222456789', '0944444444', 'dulichd@example.com', 'LV05'),
('KH05', N'Bệnh viện E', N'Đà Nẵng', '0236987412', '0955555555', 'benhvienE@example.com', 'LV06'),
('KH06', N'Công ty Vận tải F', N'TP.HCM', '0287777888', '0966666666', 'vantaiF@example.com', 'LV07'),
('KH07', N'Công ty Giải trí G', N'Cần Thơ', '0292654321', '0977777777', 'giaitriG@example.com', 'LV08'),
('KH08', N'Nông trại H', N'Đắk Lắk', '0262987654', '0988888888', 'nongtraiH@example.com', 'LV09');

-- Nhân viên thêm
INSERT INTO NhanVien VALUES 
('NV03', N'Lê Văn Cường', 'PB01', 'CV03', 'TD01', 'CM01', N'Đà Nẵng', '1988-03-22', N'Nam', '0345678912', '0945678912', 'cuong.le@example.com'),
('NV04', N'Phạm Thị Dung', 'PB02', 'CV02', 'TD02', 'CM03', N'Hải Phòng', '1995-11-08', N'Nữ', '0456789123', '0956789123', 'dung.pham@example.com'),
('NV05', N'Ngô Văn Hậu', 'PB03', 'CV03', 'TD01', 'CM02', N'Đà Nẵng', '1990-02-02', N'Nam', '0543210987', '0967891234', 'hau.ngo@example.com'),
('NV06', N'Đào Thị Kim', 'PB04', 'CV03', 'TD02', 'CM03', N'Hải Phòng', '1985-10-10', N'Nữ', '0678901234', '0978901234', 'kim.dao@example.com'),
('NV07', N'Huỳnh Văn Nam', 'PB05', 'CV01', 'TD03', 'CM01', N'Cần Thơ', '1987-06-06', N'Nam', '0789456123', '0989456123', 'nam.huynh@example.com');

-- Khách gửi bài thêm
INSERT INTO KhachGuiBai VALUES 
('LG03', 'KH03', 'TL05', 'NV03', N'Công nghệ Blockchain', N'Nội dung về blockchain...', '2025-04-19', 600000),
('LG04', 'KH04', 'TL08', 'NV04', N'Khám phá vùng đất mới', N'Bài về du lịch...', '2025-04-20', 550000),
('LG05', 'KH05', 'TL04', 'NV05', N'Bảo vệ sức khỏe mùa hè', N'Bài về y tế...', '2025-04-21', 450000),
('LG06', 'KH06', 'TL06', 'NV06', N'Bóng đá học đường', N'Bài thể thao...', '2025-04-22', 400000),
('LG07', 'KH07', 'TL07', 'NV07', N'Văn hóa dân gian Việt Nam', N'Nội dung văn hóa...', '2025-04-23', 500000);

-- Khách - Quảng cáo thêm
INSERT INTO Khach_QuangCao VALUES 
('QC_L3', 'KH03', 'B03', 'NV03', 'QC04', N'Video giới thiệu công ty C', '2025-04-15', '2025-05-15', 25000000),
('QC_L4', 'KH04', 'B04', 'NV04', 'QC05', N'Bài PR về công ty D', '2025-04-18', '2025-04-28', 18000000),
('QC_L5', 'KH05', 'B05', 'NV05', 'QC06', N'Quảng cáo bệnh viện E', '2025-04-20', '2025-05-20', 22000000),
('QC_L6', 'KH06', 'B03', 'NV06', 'QC07', N'Quảng cáo dịch vụ vận tải', '2025-04-22', '2025-05-22', 21000000),
('QC_L7', 'KH07', 'B04', 'NV07', 'QC01', N'Giải trí trực tuyến', '2025-04-24', '2025-05-24', 23000000);
