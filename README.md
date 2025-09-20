# 📘 HỆ THỐNG ĐĂNG KÝ MÔN HỌC - ĐỒ ÁN QUẢN LÝ THÔNG TIN SINH VIÊN CNTT
# Môn học: Hệ quản trị Cơ sở dữ liệu (DBMS)

## 📌 Giới thiệu
Đây là module chính của đồ án **Hệ thống quản lý thông tin sinh viên CNTT**, tập trung vào **chức năng Đăng ký môn học**.  
Hệ thống hỗ trợ sinh viên đăng ký học phần một cách nhanh chóng, đồng thời giúp giảng viên/nhà trường quản lý được số lượng sinh viên đăng ký.

## 📌 Chức năng chính
Module này quản lý toàn bộ quy trình **Đăng ký môn học** cho sinh viên CNTT, bao gồm:
- Đăng nhập hệ thống theo tài khoản và vai trò.
- Tra cứu học phần theo học kỳ, năm học, hoặc tên môn.
- Sinh viên thực hiện đăng ký và hủy đăng ký học phần.
- Giảng viên và quản trị có thể xem danh sách sinh viên trong lớp.
- Ràng buộc điều kiện đăng ký (sĩ số, số tín chỉ tối đa, trùng lịch).
- Quản lý CRUD học phần (thêm, sửa, xóa).

---

## ⚙️ Stored Procedures
- **SP_LOGIN**: Xác thực tài khoản, trả về thông tin sinh viên hoặc giảng viên.
- **sp_LayDSHP**: Lấy danh sách học phần theo học kỳ và năm học.
- **sp_DKMH**: Đăng ký môn học cho sinh viên.
- **sp_HuyDangKy**: Hủy đăng ký học phần.
- **sp_TraCuuHocPhan**: Tìm kiếm học phần theo mã HP, tên môn, học kỳ.
- **sp_XemSinhVienTrongLop**: Hiển thị danh sách sinh viên trong một học phần.
- **sp_LayDSHPGV**: Lấy danh sách học phần mà giảng viên phụ trách.
- **sp_LayAllDSHP**: Truy vấn tất cả học phần trong hệ thống.
- **sp_LayDSHPDaDK**: Lấy danh sách học phần mà sinh viên đã đăng ký.
- **sp_ThemHocPhan / sp_SuaHocPhan / sp_XoaHocPhan**: Quản lý CRUD học phần.
- **sp_ThongKeHP**: Thống kê số lượng sinh viên đăng ký theo học phần.
- **sp_datDieuKien**: Kiểm tra điều kiện đăng ký (tín chỉ tối đa, trùng lịch).

---

## ⚡ Trigger
- **trg_GioiHanSiSo**: Giới hạn số lượng sinh viên đăng ký (ví dụ tối đa 5).
- **tg_XoaHocPhan**: Khi xóa học phần thì tự động xóa đăng ký liên quan (cascade).

---

## 🧩 Function
- **fn_TongTinChi(MaSV, HocKy, NamHoc)**: Tính tổng số tín chỉ sinh viên đã đăng ký trong kỳ.
- **fn_TrungLich(MaSV, MaHP)**: Kiểm tra học phần đăng ký có bị trùng lịch hay không.

---

## 📊 Quy trình hoạt động
1. **Sinh viên đăng nhập** bằng tài khoản hệ thống.
2. **Tra cứu học phần** theo học kỳ, năm học.
3. **Đăng ký học phần** → Hệ thống kiểm tra:
   - Sĩ số lớp chưa vượt quá giới hạn.
   - Không trùng lịch học.
   - Không vượt quá số tín chỉ tối đa (25 tín chỉ/kỳ).
4. **Hủy đăng ký** nếu sinh viên không muốn tham gia học phần.
5. **Giảng viên/Admin** có thể xem danh sách sinh viên trong lớp hoặc thống kê số lượng đăng ký.

---

## 👨‍💻 Công nghệ sử dụng
- **SQL Server**: quản lý CSDL.
- **C# WinForms**: giao diện đăng ký môn học.
- **Stored Procedure + Trigger + Function**: xử lý logic nghiệp vụ tại database.

---

📢 *“Đăng ký môn học dễ dàng – Học đúng kế hoạch, định hướng rõ ràng”*
