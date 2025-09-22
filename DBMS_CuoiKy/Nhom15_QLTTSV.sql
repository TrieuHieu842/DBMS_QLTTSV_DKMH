USE QLSV_DoAn
GO

=============Bảng tài khoản===============================
CREATE TABLE TaiKhoan (
    TenDN NVARCHAR(50) PRIMARY KEY,
    MatKhau NVARCHAR(100) NOT NULL, 
    VaiTro NVARCHAR(20) NOT NULL CHECK (VaiTro IN ('Admin','GiangVien','SinhVien')),
    MaDinhDanh NVARCHAR(20) NOT NULL          -- Mã định danh (MaSV, MaGV, hoặc MaAdmin)
);
GO

INSERT INTO TaiKhoan (TenDN, MatKhau, VaiTro, MaDinhDanh) VALUES
-- Admin
('admin', '123', 'Admin', 'AD01'),

-- Giảng viên
('gv01', '123', 'GiangVien', 'GV01'),
('gv02', '123', 'GiangVien', 'GV02'),
('gv03', '123', 'GiangVien', 'GV03'),
('gv04', '123', 'GiangVien', 'GV04'),
('sv001', '123', 'SinhVien', '23110001'),
('sv002', '123', 'SinhVien', '23110002'),
('sv003', '123', 'SinhVien', '23133001'),
('sv004', '123', 'SinhVien', '23133002'),
('sv005', '123', 'SinhVien', '23162001'),
('sv006', '123', 'SinhVien', '23162002'),
('sv007', '123', 'SinhVien', '24162001'),
('sv008', '123', 'SinhVien', '24162002'),
('sv009', '123', 'SinhVien', '24110001'),
('sv010', '123', 'SinhVien', '24110002');
GO

/* ============================================
   1) BANG TRUNG TAM: SINHVIEN
   ============================================ */
CREATE TABLE dbo.SinhVien (
    MaSV      VARCHAR(10)    NOT NULL,
    HoTen     NVARCHAR(100)  NOT NULL,
	NgaySinh  DATE           NULL,
    GioiTinh  NVARCHAR(5)    NULL,  -- Nam/Nu
    Lop       VARCHAR(10)    NULL,
    Nganh     NVARCHAR(50)   NULL,
    Khoa      NVARCHAR(50)   NULL,
    DiaChi    NVARCHAR(200)  NULL,
    SDT       VARCHAR(15)    NULL,
    CONSTRAINT PK_SinhVien PRIMARY KEY (MaSV),
    CONSTRAINT CK_SV_GioiTinh CHECK (GioiTinh IN (N'Nam', N'Nu')),
    CONSTRAINT CK_SV_SDT CHECK (SDT IS NULL OR SDT LIKE '[0-9+ -]%')
);
GO


/* ============================================
   DU LIEU MAU CHO 15 SINH VIEN
   ============================================ */
INSERT INTO dbo.SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Lop, Nganh, Khoa, DiaChi, SDT)
VALUES
('23110001', N'Nguyen Van A',  '2004-01-15', N'Nam', 'CTK45A', N'Cong nghe thong tin', N'CNTT', N'Ha Noi',     '0912345678'),
('23110002', N'Tran Thi B',    '2004-02-20', N'Nu',  'CTK45A', N'Cong nghe thong tin', N'CNTT', N'Ha Noi',     '0912345679'),
('23133001', N'Le Van C',      '2003-12-10', N'Nam', 'CTK45B', N'Ky thuat du lieu',    N'CNTT', N'Hai Phong',  '0912345680'),
('23133002', N'Pham Thi D',    '2004-03-05', N'Nu',  'CTK45B', N'Ky thuat du lieu',    N'CNTT', N'Hai Phong',  '0912345681'),
('23162001', N'Hoang Van E',   '2004-04-12', N'Nam', 'CTK45C', N'An toan thong tin',   N'CNTT', N'Ha Nam',     '0912345682'),
('23162002', N'Ngo Thi F',     '2004-05-22', N'Nu',  'CTK45C', N'An toan thong tin',   N'CNTT', N'Ha Nam',     '0912345683'),
('24162001', N'Dang Van G',    '2005-06-18', N'Nam', 'CTK46A', N'An toan thong tin',   N'CNTT', N'Ninh Binh',  '0912345684'),
('24162002', N'Vu Thi H',      '2005-07-25', N'Nu',  'CTK46A', N'An toan thong tin',   N'CNTT', N'Ninh Binh',  '0912345685'),
('24110001', N'Bui Van I',     '2005-08-30', N'Nam', 'CTK46B', N'Cong nghe thong tin', N'CNTT', N'Thai Binh',  '0912345686'),
('24110002', N'Nguyen Thi K',  '2005-09-12', N'Nu',  'CTK46B', N'Cong nghe thong tin', N'CNTT', N'Thai Binh',  '0912345687'),
('25110001', N'Luong Van L',   '2006-01-10', N'Nam', 'CTK47A', N'Cong nghe thong tin', N'CNTT', N'Ha Tinh',    '0912345688'),
('25110002', N'Phan Thi M',    '2006-02-11', N'Nu',  'CTK47A', N'Cong nghe thong tin', N'CNTT', N'Ha Tinh',    '0912345689'),
('25133001', N'Ta Van N',      '2006-03-14', N'Nam', 'CTK47B', N'Ky thuat du lieu',    N'CNTT', N'Nam Dinh',   '0912345690'),
('25133002', N'Do Thi O',      '2006-04-17', N'Nu',  'CTK47B', N'Ky thuat du lieu',    N'CNTT', N'Nam Dinh',   '0912345691'),
('25133003', N'Ha Van P',      '2006-05-20', N'Nam', 'CTK47C', N'Ky thuat du lieu',    N'CNTT', N'Thanh Hoa',  '0912345692');
GO

USE QLSV_DoAn
GO

-- Tao bang MonHoc
CREATE TABLE MonHoc (
    MaMH VARCHAR(10) PRIMARY KEY,
    TenMH NVARCHAR(100) NOT NULL,
    SoTinChi INT NOT NULL
);
GO

INSERT INTO MonHoc (MaMH, TenMH, SoTinChi)
VALUES
('MH001', N'Co so du lieu', 3),
('MH002', N'Lap trinh C#', 3),
('MH003', N'Mang may tinh', 3),
('MH004', N'He dieu hanh', 2),
('MH005', N'Cau truc du lieu', 3),
('MH006', N'Tri tue nhan tao', 3),
('MH007', N'An toan thong tin', 2),
('MH008', N'Lap trinh web', 3),
('MH009', N'Ky thuat phan mem', 3),
('MH010', N'Phan tich du lieu', 3);
GO

-- Tao bang HocPhan
CREATE TABLE HocPhan (
    MaHP VARCHAR(10) PRIMARY KEY,
    MaMH VARCHAR(10) NOT NULL,
    HocKy INT NOT NULL,
    NamHoc VARCHAR(9) NOT NULL,
    GiangVien NVARCHAR(100),
    ThoiKhoaBieu NVARCHAR(50),
    PhongHoc NVARCHAR(20),
    FOREIGN KEY (MaMH) REFERENCES MonHoc(MaMH)
);
GO

INSERT INTO HocPhan (MaHP, MaMH, HocKy, NamHoc, GiangVien, ThoiKhoaBieu, PhongHoc)
VALUES
('HP001', 'MH001', 1, '2024-2025', N'Nguyen Van Thay', N'T2-7h30', N'P101'),
('HP002', 'MH002', 1, '2024-2025', N'Tran Thi Co', N'T3-9h30', N'P102'),
('HP003', 'MH003', 1, '2024-2025', N'Le Van Day', N'T4-13h00', N'P103'),
('HP004', 'MH004', 1, '2024-2025', N'Pham Thi Hoc', N'T5-7h30', N'P104'),
('HP005', 'MH005', 2, '2024-2025', N'Hoang Van Su', N'T2-15h00', N'P201'),
('HP006', 'MH006', 2, '2024-2025', N'Ngo Thi Day', N'T3-7h30', N'P202'),
('HP007', 'MH007', 2, '2024-2025', N'Dang Van Giao', N'T4-9h30', N'P203'),
('HP008', 'MH008', 2, '2024-2025', N'Vu Thi Co', N'T5-13h00', N'P204'),
('HP009', 'MH009', 2, '2024-2025', N'Bui Van Thay', N'T6-7h30', N'P205'),
('HP010', 'MH010', 2, '2024-2025', N'Nguyen Van Day', N'T6-9h30', N'P206');
GO

-- Tao bang DangKyHocPhan
CREATE TABLE DangKyHocPhan (
    MaSV VARCHAR(10) NOT NULL,
    MaHP VARCHAR(10) NOT NULL,
    NgayDangKy DATE NOT NULL,
    PRIMARY KEY (MaSV, MaHP),
    FOREIGN KEY (MaSV) REFERENCES SinhVien(MaSV),
    FOREIGN KEY (MaHP) REFERENCES HocPhan(MaHP)
);
GO

INSERT INTO DangKyHocPhan (MaSV, MaHP, NgayDangKy)
VALUES
('23110001', 'HP001', '2025-08-01'),
('23110002', 'HP001', '2025-08-02'),
('23133001', 'HP002', '2025-08-02'),
('23133002', 'HP002', '2025-08-03'),
('23162001', 'HP003', '2025-08-04'),
('23162002', 'HP004', '2025-08-04'),
('24162001', 'HP005', '2025-08-05'),
('24162002', 'HP006', '2025-08-06'),
('24110001', 'HP007', '2025-08-06'),
('24110002', 'HP008', '2025-08-07'),
('25110001', 'HP009', '2025-08-08'),
('25110002', 'HP010', '2025-08-08'),
('25133001', 'HP001', '2025-08-09'),
('25133002', 'HP002', '2025-08-10'),
('25133003', 'HP003', '2025-08-10');
GO
======================================================
Chức vụ khác
USE QLSV_DoAn
Go

CREATE TABLE ChucVuKhac
(
	MaDinhDanh NVARCHAR(20) PRIMARY KEY,
	HoTen NVARCHAR(50)
)

INSERT INTO ChucVuKhac(MaDinhDanh, HoTen) VALUES
('AD01',N'TRIEU PHUC HIEU'),
('GV01', N'Nguyen Van Thay'),
('GV02', N'Tran Thi Co'),
('GV03', N'Le Van Day'),
('GV04', N'Pham Thi Hoc'),
('GV05', N'Hoang Van Su'),
('GV06', N'Ngo Thi Day'),
('GV07', N'Dang Van Giao'),
('GV08', N'Vu Thi Co'),
('GV09', N'Bui Van Thay'),
('GV10', N'Nguyen Van Day');


USE QLSV_DoAn;
GO

/* ============================================================
   1. QUẢN LÝ ĐĂNG NHẬP & TÀI KHOẢN
   ============================================================ */
-- Đăng nhập
CREATE OR ALTER PROCEDURE SP_LOGIN
    @username NVARCHAR(50),
    @password NVARCHAR(50)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TenDN=@username AND MatKhau=@password)
    BEGIN
        DECLARE @vaitro NVARCHAR(20);
        SELECT @vaitro = VaiTro FROM TaiKhoan WHERE TenDN=@username;

        IF @vaitro='SinhVien'
        BEGIN
            SELECT tk.VaiTro, tk.MaDinhDanh, sv.HoTen 
            FROM TaiKhoan tk
            INNER JOIN SinhVien sv ON tk.MaDinhDanh=sv.MaSV
            WHERE tk.TenDN=@username;
        END
        ELSE
        BEGIN
            SELECT tk.VaiTro, tk.MaDinhDanh, tk.VaiTro AS HoTen
            FROM TaiKhoan tk
            WHERE tk.TenDN=@username;
        END
    END
    ELSE
    BEGIN
        RAISERROR(N'Tên đăng nhập hoặc mật khẩu không đúng!',16,1);
    END
END;
GO

-- Tạo user DB từ bảng TaiKhoan
CREATE OR ALTER PROCEDURE SP_CreateAndMapUser
    @TenDN NVARCHAR(50)
AS
BEGIN
    DECLARE @MatKhau NVARCHAR(100), @VaiTro NVARCHAR(20);

    SELECT @MatKhau=MatKhau, @VaiTro=VaiTro
    FROM TaiKhoan
    WHERE TenDN=@TenDN;

    -- Tạo login nếu chưa có
    IF NOT EXISTS (SELECT 1 FROM sys.server_principals WHERE name=@TenDN)
        EXEC('CREATE LOGIN ['+@TenDN+'] WITH PASSWORD='''+@MatKhau+'''');

    -- Tạo user nếu chưa có
    IF NOT EXISTS (SELECT 1 FROM sys.database_principals WHERE name=@TenDN)
        EXEC('CREATE USER ['+@TenDN+'] FOR LOGIN ['+@TenDN+']');

    -- Gán Role
    IF @VaiTro='Admin'
        EXEC('ALTER ROLE AdminRole ADD MEMBER ['+@TenDN+']');
    ELSE IF @VaiTro='GiangVien'
        EXEC('ALTER ROLE GiangVienRole ADD MEMBER ['+@TenDN+']');
    ELSE IF @VaiTro='SinhVien'
        EXEC('ALTER ROLE SinhVienRole ADD MEMBER ['+@TenDN+']');
END;
GO

/* ============================================================
   2. QUẢN LÝ HỌC PHẦN
   ============================================================ */
-- Thêm học phần
CREATE OR ALTER PROCEDURE sp_ThemHocPhan
    @MaHP NVARCHAR(10),
    @MaMH NVARCHAR(10),
    @HocKy INT,
    @NamHoc NVARCHAR(20),
    @GiangVien NVARCHAR(100),
    @ThoiKhoaBieu NVARCHAR(50),
    @PhongHoc NVARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM HocPhan WHERE MaHP=@MaHP)
    BEGIN
        RAISERROR(N'Mã học phần đã tồn tại!',16,1);
        RETURN;
    END;

    INSERT INTO HocPhan(MaHP,MaMH,HocKy,NamHoc,GiangVien,ThoiKhoaBieu,PhongHoc)
    VALUES (@MaHP,@MaMH,@HocKy,@NamHoc,@GiangVien,@ThoiKhoaBieu,@PhongHoc);
END;
GO

-- Sửa học phần
CREATE OR ALTER PROCEDURE sp_SuaHocPhan
    @MaHP NVARCHAR(10),
    @MaMH NVARCHAR(10),
    @HocKy INT,
    @NamHoc NVARCHAR(20),
    @GiangVien NVARCHAR(100),
    @ThoiKhoaBieu NVARCHAR(50),
    @PhongHoc NVARCHAR(50)
AS
BEGIN
    IF NOT EXISTS (SELECT 1 FROM HocPhan WHERE MaHP=@MaHP)
    BEGIN
        RAISERROR(N'Mã học phần không tồn tại!',16,1);
        RETURN;
    END;

    UPDATE HocPhan
    SET MaMH=@MaMH, HocKy=@HocKy, NamHoc=@NamHoc,
        GiangVien=@GiangVien, ThoiKhoaBieu=@ThoiKhoaBieu, PhongHoc=@PhongHoc
    WHERE MaHP=@MaHP;
END;
GO

-- Xóa học phần (kèm xóa DKHP liên quan)
CREATE OR ALTER TRIGGER tg_XoaHocPhan
ON HocPhan
INSTEAD OF DELETE
AS
BEGIN
    DELETE dk
    FROM DangKyHocPhan dk
    INNER JOIN deleted d ON dk.MaHP=d.MaHP;

    DELETE hp
    FROM HocPhan hp
    INNER JOIN deleted d ON hp.MaHP=d.MaHP;
END;
GO

-- Xem danh sách học phần theo kỳ
CREATE OR ALTER PROCEDURE sp_LayDSHP
    @HocKy NVARCHAR(10),
    @NamHoc NVARCHAR(10)
AS
BEGIN
    SELECT hp.MaHP,mh.TenMH,hp.NamHoc,hp.HocKy,mh.SoTinChi,
           hp.GiangVien,hp.ThoiKhoaBieu,hp.PhongHoc
    FROM HocPhan hp
    JOIN MonHoc mh ON hp.MaMH=mh.MaMH
    WHERE hp.HocKy=@HocKy AND hp.NamHoc=@NamHoc
    ORDER BY mh.TenMH;
END;
GO

-- Lấy tất cả học phần
CREATE OR ALTER PROCEDURE sp_LayAllDSHP
AS
BEGIN
    SELECT * FROM HocPhan;
END;
GO

-- Tra cứu học phần
CREATE OR ALTER PROCEDURE sp_TraCuuHocPhan
    @MaHP NVARCHAR(50)=NULL,
    @TenHP NVARCHAR(100)=NULL,
    @HocKy NVARCHAR(20)=NULL
AS
BEGIN
    SELECT hp.MaHP,mh.TenMH,mh.SoTinChi,hp.HocKy,hp.NamHoc,
           hp.GiangVien,hp.ThoiKhoaBieu,hp.PhongHoc
    FROM HocPhan hp
    JOIN MonHoc mh ON hp.MaMH=mh.MaMH
    WHERE (@MaHP IS NULL OR hp.MaHP LIKE '%'+@MaHP+'%')
      AND (@TenHP IS NULL OR mh.TenMH LIKE N'%'+@TenHP+N'%')
      AND (@HocKy IS NULL OR hp.HocKy=@HocKy);
END;
GO

-- Trigger kiểm tra phòng học bị trùng
CREATE OR ALTER TRIGGER tg_KtraTrungPhong
ON HocPhan
AFTER INSERT
AS
BEGIN
    IF EXISTS (
        SELECT 1
        FROM HocPhan h
        JOIN INSERTED i 
            ON h.PhongHoc = i.PhongHoc
           AND h.ThoiKhoaBieu = i.ThoiKhoaBieu
    )
    BEGIN
        RAISERROR (N'Phòng học đã bị trùng lịch học phần khác!', 16, 1);
        ROLLBACK TRANSACTION;
    END
END;
GO

/* ============================================================
   3. ĐĂNG KÝ HỌC PHẦN
   ============================================================ */
-- Hàm tính tổng tín chỉ
CREATE OR ALTER FUNCTION fn_TongTinChi
(
    @MaSV NVARCHAR(20),
    @HocKy NVARCHAR(10),
    @NamHoc NVARCHAR(10)
)
RETURNS INT
AS
BEGIN
    DECLARE @Tong INT;
    SELECT @Tong=SUM(MH.SoTinChi)
    FROM DangKyHocPhan DK
    JOIN HocPhan HP ON DK.MaHP=HP.MaHP
    JOIN MonHoc MH ON HP.MaMH=MH.MaMH
    WHERE DK.MaSV=@MaSV AND HP.HocKy=@HocKy AND HP.NamHoc=@NamHoc;

    RETURN ISNULL(@Tong,0);
END;
GO

-- Hàm kiểm tra trùng lịch
CREATE OR ALTER FUNCTION fn_TrungLich
(
    @MaSV NVARCHAR(20),
    @MaHP NVARCHAR(20)
)
RETURNS BIT
AS
BEGIN
    DECLARE @Trung BIT=0;

    IF EXISTS (
        SELECT 1
        FROM DangKyHocPhan DK
        JOIN HocPhan HP1 ON DK.MaHP=HP1.MaHP
        JOIN HocPhan HP2 ON HP2.MaHP=@MaHP
        WHERE DK.MaSV=@MaSV AND HP1.ThoiKhoaBieu=HP2.ThoiKhoaBieu
    )
        SET @Trung=1;

    RETURN @Trung;
END;
GO

-- Kiểm tra điều kiện đăng ký
CREATE OR ALTER PROCEDURE sp_datDieuKien
    @MaSV NVARCHAR(20),
    @MaHP NVARCHAR(20),
    @NamHoc NVARCHAR(10),
    @HocKy NVARCHAR(10),
    @KetQua NVARCHAR(100) OUTPUT
AS
BEGIN
    DECLARE @SoTinChi INT;
    SELECT @SoTinChi=MH.SoTinChi
    FROM HocPhan HP JOIN MonHoc MH ON HP.MaMH=MH.MaMH
    WHERE HP.MaHP=@MaHP;

    IF dbo.fn_TrungLich(@MaSV,@MaHP)=1
    BEGIN
        SET @KetQua=N'Không đủ điều kiện: Bị trùng lịch'; RETURN;
    END;

    IF dbo.fn_TongTinChi(@MaSV,@HocKy,@NamHoc)+@SoTinChi>25
    BEGIN
        SET @KetQua=N'Không đủ điều kiện: Vượt quá số tín chỉ tối đa'; RETURN;
    END;

    SET @KetQua=N'Đủ điều kiện';
END;
GO

-- Đăng ký học phần
CREATE OR ALTER PROCEDURE sp_DKMH
    @MaSV NVARCHAR(20),
    @MaHP NVARCHAR(20),
    @HocKy NVARCHAR(10),
    @NamHoc NVARCHAR(10)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN;

        DECLARE @KetQua NVARCHAR(100);
        EXEC sp_datDieuKien @MaSV,@MaHP,@NamHoc,@HocKy,@KetQua OUTPUT;

        IF @KetQua<>N'Đủ điều kiện'
        BEGIN
            RAISERROR(@KetQua,16,1);
            ROLLBACK TRAN; RETURN;
        END;

        INSERT INTO DangKyHocPhan(MaSV,MaHP,NgayDangKy)
        VALUES(@MaSV,@MaHP,GETDATE());

        COMMIT TRAN;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT>0 ROLLBACK TRAN;
        RAISERROR(ERROR_MESSAGE(),16,1);
    END CATCH
END;
GO

-- Hủy đăng ký
CREATE OR ALTER PROCEDURE sp_HuyDangKy
    @MaSV NVARCHAR(20),
    @MaHP NVARCHAR(20)
AS
BEGIN
    DELETE FROM DangKyHocPhan WHERE MaSV=@MaSV AND MaHP=@MaHP;
END;
GO

-- Trigger giới hạn sĩ số (VD: tối đa 5 SV/lớp)
CREATE OR ALTER TRIGGER trg_GioiHanSiSo
ON DangKyHocPhan
AFTER INSERT
AS
BEGIN
    DECLARE @MaHP NVARCHAR(20);
    SELECT @MaHP=MaHP FROM INSERTED;

    IF (SELECT COUNT(*) FROM DangKyHocPhan WHERE MaHP=@MaHP)>5
    BEGIN
        ROLLBACK TRAN;
        RAISERROR(N'Lớp đã đủ sĩ số, không thể đăng ký thêm!',16,1);
    END
END;
GO

-- DSHP đã đăng ký của SV
CREATE OR ALTER PROCEDURE sp_LayDSHPDaDK
    @MaSV NVARCHAR(20)
AS
BEGIN
    SELECT dk.MaHP,mh.TenMH,mh.SoTinChi,hp.GiangVien,
           dk.NgayDangKy,hp.HocKy,hp.NamHoc
    FROM DangKyHocPhan dk
    JOIN HocPhan hp ON dk.MaHP=hp.MaHP
    JOIN MonHoc mh ON hp.MaMH=mh.MaMH
    WHERE dk.MaSV=@MaSV;
END;
GO

/* ============================================================
   4. QUẢN LÝ GIẢNG VIÊN & SINH VIÊN
   ============================================================ */
-- Xem SV trong lớp
CREATE OR ALTER PROCEDURE sp_XemSinhVienTrongLop
    @MaHP NVARCHAR(20)
AS
BEGIN
    SELECT SV.MaSV,SV.HoTen,SV.Lop,SV.Khoa,SV.SDT
    FROM DangKyHocPhan DK
    JOIN SinhVien SV ON DK.MaSV=SV.MaSV
    WHERE DK.MaHP=@MaHP;
END;
GO

-- DS học phần giảng viên phụ trách
CREATE OR ALTER PROCEDURE sp_LayDSHPGV
    @MaGV NVARCHAR(20)
AS
BEGIN
    SELECT hp.MaHP
    FROM HocPhan hp
    JOIN ChucVuKhac cvk ON hp.GiangVien=cvk.HoTen
    WHERE cvk.MaDinhDanh=@MaGV;
END;
GO

/* ============================================================
   5. THỐNG KÊ
   ============================================================ */
CREATE OR ALTER PROCEDURE sp_ThongKeHP
AS
BEGIN
    SELECT hp.MaHP,mh.TenMH,COUNT(dk.MaSV) AS SoLuongSV
    FROM HocPhan hp
    LEFT JOIN DangKyHocPhan dk ON hp.MaHP=dk.MaHP
    JOIN MonHoc mh ON hp.MaMH=mh.MaMH
    GROUP BY hp.MaHP,mh.TenMH;
END;
GO

/* ============================================================
   6. PHÂN QUYỀN & ROLE
   ============================================================ */
CREATE ROLE AdminRole;
CREATE ROLE GiangVienRole;
CREATE ROLE SinhVienRole;

-- Admin toàn quyền
GRANT CONTROL ON DATABASE::QLSV_DoAn TO AdminRole;

-- Giảng viên
GRANT SELECT ON MonHoc TO GiangVienRole;
GRANT SELECT ON DangKyHocPhan TO GiangVienRole;
GRANT SELECT ON SinhVien TO GiangVienRole;

-- Sinh viên
GRANT SELECT ON MonHoc TO SinhVienRole;
GRANT SELECT ON HocPhan TO SinhVienRole;
GRANT SELECT ON SinhVien TO SinhVienRole;
GRANT INSERT,DELETE ON DangKyHocPhan TO SinhVienRole;
GO

/* ============================================================
   7. VIEWS
   ============================================================ */
-- Chi tiết tài khoản
CREATE OR ALTER VIEW v_ChiTietTaiKhoan AS
SELECT tk.TenDN, tk.VaiTro, tk.MaDinhDanh,
       sv.HoTen AS HoTenSV,
       cv.HoTen AS HoTenChucVu
FROM TaiKhoan tk
LEFT JOIN SinhVien sv ON tk.MaDinhDanh = sv.MaSV
LEFT JOIN ChucVuKhac cv ON tk.MaDinhDanh = cv.MaDinhDanh;
GO

-- DS sinh viên đã ĐK học phần
CREATE OR ALTER VIEW v_SinhVienDKMH AS
SELECT sv.MaSV, sv.HoTen, hp.MaHP, mh.TenMH, hp.HocKy, hp.NamHoc, hp.GiangVien
FROM DangKyHocPhan dk
JOIN SinhVien sv ON dk.MaSV = sv.MaSV
JOIN HocPhan hp ON dk.MaHP = hp.MaHP
JOIN MonHoc mh ON hp.MaMH = mh.MaMH;
GO

-- Thống kê sĩ số học phần
CREATE OR ALTER VIEW v_HocPhanSLSV AS
SELECT hp.MaHP, mh.TenMH, hp.HocKy, hp.NamHoc, hp.GiangVien, COUNT(dk.MaSV) AS SoLuongSV
FROM HocPhan hp
JOIN MonHoc mh ON hp.MaMH = mh.MaMH
LEFT JOIN DangKyHocPhan dk ON hp.MaHP = dk.MaHP
GROUP BY hp.MaHP, mh.TenMH, hp.HocKy, hp.NamHoc, hp.GiangVien;
GO

