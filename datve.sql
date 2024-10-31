-- Tạo bảng cho admin
CREATE TABLE admin
(
    id           INT PRIMARY KEY IDENTITY(1,1),
    ten_dang_nhap VARCHAR(255) NOT NULL UNIQUE,
    mat_khau     VARCHAR(255) NOT NULL,
    ngay_tao     DATETIME DEFAULT GETDATE()
);
-- Tạo bảng cho người dùng
CREATE TABLE nguoi_dung
(
    id           INT PRIMARY KEY IDENTITY(1,1),
    ten_dang_nhap VARCHAR(255) NOT NULL UNIQUE,
    mat_khau     VARCHAR(255) NOT NULL,
    email        VARCHAR(255) NOT NULL UNIQUE,
    ho_ten       VARCHAR(255),
    so_dien_thoai VARCHAR(20),
    ngay_tao     DATETIME DEFAULT GETDATE()
);

-- Tạo bảng cho địa điểm du lịch
CREATE TABLE dia_diem_du_lich
(
    id          INT PRIMARY KEY IDENTITY(1,1),
    ten         VARCHAR(255) NOT NULL,
    mo_ta       TEXT,
    vi_tri      VARCHAR(255),
    url_hinh_anh VARCHAR(255)
);

-- Tạo bảng cho dịch vụ du lịch
CREATE TABLE dich_vu_du_lich
(
    id             INT PRIMARY KEY IDENTITY(1,1),
    ten            VARCHAR(255) NOT NULL,
    mo_ta          TEXT,
    dia_diem_id    INT,
    FOREIGN KEY (dia_diem_id) REFERENCES dia_diem_du_lich(id)
);

-- Tạo bảng cho công ty vận tải
CREATE TABLE cong_ty_van_tai
(
    id           INT PRIMARY KEY IDENTITY(1,1),
    ten          VARCHAR(255) NOT NULL,
    thong_tin_lien_he VARCHAR(255)
);

-- Tạo bảng cho công ty du lịch
CREATE TABLE cong_ty_du_lich
(
    id           INT PRIMARY KEY IDENTITY(1,1),
    ten          VARCHAR(255) NOT NULL,
    thong_tin_lien_he VARCHAR(255)
);

-- Tạo bảng cho tuyến đường (xe buýt, tàu, chuyến bay)
CREATE TABLE tuyen_duong
(
    id             INT PRIMARY KEY IDENTITY(1,1),
    loai           NVARCHAR(10) NOT NULL CHECK (loai IN ('xe buýt', 'tàu', 'chuyến bay')),
    cong_ty_id     INT,
    diem_bat_dau   VARCHAR(255),
    diem_ket_thuc  VARCHAR(255),
    thoi_gian_khoi_hanh DATETIME,
    thoi_gian_den  DATETIME,
    gia            DECIMAL(10, 2),
    FOREIGN KEY (cong_ty_id) REFERENCES cong_ty_van_tai(id)
);

-- Tạo bảng cho đặt vé
CREATE TABLE dat_ve
(
    id           INT PRIMARY KEY IDENTITY(1,1),
    ten          VARCHAR(255) NOT NULL,
    thong_tin_lien_he VARCHAR(255),
    tuyen_duong_id INT,
    ngay_dat     DATETIME DEFAULT GETDATE(),
    nguoi_dung_id INT,
    FOREIGN KEY (tuyen_duong_id) REFERENCES tuyen_duong(id),
    FOREIGN KEY (nguoi_dung_id) REFERENCES nguoi_dung(id)
);