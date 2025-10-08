# 🎓 HỆ THỐNG QUẢN LÝ THÔNG TIN SINH VIÊN KHOA CNTT  
### 📘 MODULE: ĐĂNG KÝ MÔN HỌC  
**Môn học:** Hệ quản trị Cơ sở dữ liệu (DBMS)  
**Sinh viên thực hiện:** Triệu Phúc Hiếu – MSSV 23110217  
**Trường:** Đại học Sư phạm Kỹ thuật TP. Hồ Chí Minh – Khoa CNTT  

---

## 🧭 Giới thiệu
Đồ án “**Quản lý thông tin sinh viên khoa CNTT**” là hệ thống quản lý và đăng ký học phần được thiết kế để hỗ trợ sinh viên, giảng viên và quản trị viên.  
Mục tiêu là **tự động hóa quy trình đăng ký môn học**, đảm bảo dữ liệu **an toàn, nhất quán và chính xác**, đồng thời tích hợp các ràng buộc nghiệp vụ như **trùng lịch, giới hạn sĩ số và tín chỉ tối đa**.

---

## ⚙️ Chức năng chính
### 👨‍🎓 Sinh viên:
- Đăng nhập hệ thống.  
- Tra cứu học phần theo học kỳ, năm học, tên môn học.  
- Đăng ký và hủy đăng ký học phần.  
- Xem danh sách học phần đã đăng ký và tổng tín chỉ.

### 👨‍🏫 Giảng viên:
- Xem danh sách sinh viên trong lớp học phần.  
- Thống kê số học phần đang giảng dạy.  

### 🧑‍💼 Quản trị viên:
- Quản lý (Thêm/Sửa/Xóa) học phần, tài khoản.  
- Thống kê số lượng sinh viên đăng ký.  
- Tự động tạo và phân quyền login/user SQL.

---

## 🧩 Thành phần cơ sở dữ liệu
### 🔸 Các bảng chính:
- **SinhVien(MaSV, HoTen, NgaySinh, GioiTinh, Lop, Nganh, Khoa, SDT)**  
- **TaiKhoan(TenDN, MatKhau, VaiTro, MaDinhDanh)**  
- **MonHoc(MaMH, TenMH, SoTinChi)**  
- **HocPhan(MaHP, MaMH, HocKy, NamHoc, GiangVien, ThoiKhoaBieu, PhongHoc)**  
- **DangKyHocPhan(MaSV, MaHP, NgayDangKy)**  
- **ChucVuKhac(MaDinhDanh, HoTen)**  

---

## 🧠 Các đối tượng trong CSDL

### 🔹 **Triggers**
| STT | Tên Trigger | Chức năng |
|-----|--------------|-----------|
| 1 | **tg_XoaHocPhan** | Xóa học phần và đồng thời xóa các đăng ký liên quan. |
| 2 | **tg_KtraTrungPhong** | Kiểm tra trùng phòng học khi thêm học phần. |
| 3 | **trg_GioiHanSiSo** | Giới hạn sĩ số lớp học phần (tối đa 5 sinh viên). |
| 4 | **tg_CheckTrungLich** | Kiểm tra trùng lịch giảng dạy của giảng viên. |
| 5 | **tg_TaoTaiKhoanPQ** | Tự động tạo login/user SQL khi thêm tài khoản mới. |
| 6 | **trg_AutoDeleteUser** | Tự động xóa login/user khi tài khoản bị xóa. |

---

### 🔹 **Stored Procedures (Thủ tục lưu trữ)**
| STT | Tên Procedure | Chức năng |
|-----|----------------|-----------|
| 1 | **SP_LOGIN** | Xác thực người dùng, trả về vai trò và thông tin cá nhân. |
| 2 | **sp_ThemHocPhan** | Thêm học phần mới. |
| 3 | **sp_SuaHocPhan** | Sửa thông tin học phần. |
| 4 | **sp_datDieuKien** | Kiểm tra điều kiện đăng ký học phần. |
| 5 | **sp_LayDSHPGV** | Lấy danh sách học phần mà giảng viên phụ trách. |
| 6 | **sp_XoaTaiKhoan** | Xóa tài khoản người dùng. |
| 7 | **SP_CreateAndMapUser** | Tạo login, user SQL và gán role tương ứng. |
| 8 | **sp_XoaHocPhan** | Xóa học phần (có transaction). |
| 9 | **sp_DKMH** | Đăng ký học phần (có kiểm tra điều kiện). |
| 10 | **sp_HuyDangKy** | Hủy đăng ký học phần. |
| 11 | **sp_ThemTaiKhoan** | Thêm tài khoản người dùng mới. |

---

### 🔹 **Functions (Hàm trả về bảng và giá trị)**

#### 🧮 Hàm trả về **bảng**
| STT | Tên Function | Mô tả |
|-----|----------------|------|
| 1 | **fn_LayDSHPDaDK** | Lấy danh sách học phần sinh viên đã đăng ký. |
| 2 | **fn_XemSinhVienTrongLop** | Xem danh sách sinh viên trong một học phần. |
| 3 | **fn_LayDSHP** | Lấy danh sách học phần theo học kỳ và năm học. |
| 4 | **fn_TraCuuHocPhan** | Tra cứu học phần theo mã, tên hoặc học kỳ. |
| 5 | **fn_LayAllDSHP** | Lấy tất cả học phần trong hệ thống. |

#### 🔢 Hàm trả về **giá trị**
| STT | Tên Function | Mô tả |
|-----|----------------|------|
| 1 | **fn_TongSoTinChiSV** | Tính tổng số tín chỉ sinh viên đã đăng ký trong kỳ. |
| 2 | **fn_TrungLich** | Kiểm tra trùng lịch giữa các học phần đã đăng ký. |
| 3 | **fn_DemSoHPGV** | Đếm số học phần giảng viên dạy trong kỳ. |
| 4 | **fn_SoLuongSVDangKy** | Đếm số lượng sinh viên đã đăng ký học phần. |
| 5 | **fn_KiemTraDaDangKy** | Kiểm tra sinh viên đã đăng ký học phần hay chưa. |

---

### 🔹 **Transactions (Giao dịch trong hệ thống)**
| STT | Tên Transaction / Procedure | Mô tả |
|-----|------------------------------|--------|
| 1 | **SP_CreateAndMapUser** | Tạo login, user và gán role. |
| 2 | **sp_XoaHocPhan** | Xóa học phần kèm các đăng ký liên quan. |
| 3 | **sp_DKMH** | Đăng ký học phần (có kiểm tra điều kiện). |
| 4 | **sp_HuyDangKy** | Hủy đăng ký học phần. |
| 5 | **sp_ThemTaiKhoan** | Thêm tài khoản mới (và phân quyền tự động). |

---

### 🔹 **Login & User**
| STT | Tên | Chức năng |
|-----|------|-----------|
| 1 | **SP_LOGIN** | Xác thực người dùng khi đăng nhập hệ thống. |
| 2 | **SP_CreateAndMapUser** | Tạo login/user SQL và phân quyền (Admin, Giảng viên, Sinh viên). |

---

## 📊 Quy trình hoạt động
1. **Sinh viên đăng nhập** → kiểm tra tài khoản qua `SP_LOGIN`.  
2. **Tra cứu học phần** → lấy dữ liệu từ `fn_LayDSHP` hoặc `fn_TraCuuHocPhan`.  
3. **Đăng ký học phần** → thực hiện `sp_DKMH`, kiểm tra:
   - Không trùng lịch (`fn_TrungLich`).  
   - Không vượt quá tín chỉ tối đa (`fn_TongSoTinChiSV`).  
   - Chưa đủ sĩ số (`trg_GioiHanSiSo`).  
4. **Hủy đăng ký** → gọi `sp_HuyDangKy`.  
5. **Giảng viên** xem danh sách sinh viên bằng `fn_XemSinhVienTrongLop`.  
6. **Admin** có thể thêm, sửa, xóa học phần hoặc tài khoản bằng `sp_ThemHocPhan`, `sp_SuaHocPhan`, `sp_XoaTaiKhoan`...

---

## 💻 Công nghệ sử dụng
- **SQL Server 2012+** – Quản lý dữ liệu và logic nghiệp vụ.  
- **C# WinForms (.NET Framework)** – Giao diện người dùng.  
- **Stored Procedures, Trigger, Function, Transaction** – Xử lý toàn bộ logic trong database.  

---

## 🚀 Hướng phát triển
- Triển khai hệ thống trên nền **Web** hoặc **ASP.NET MVC**.  
- Tích hợp **module quản lý điểm** và **lịch học**.  
- Bổ sung **tự động gửi thông báo đăng ký thành công** qua email.  
- Áp dụng **Entity Framework hoặc ORM** để mở rộng linh hoạt.  

---

📢 *“Đăng ký môn học dễ dàng – Học đúng kế hoạch, định hướng rõ ràng”*
