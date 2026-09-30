Một ứng dụng Console Application được viết bằng C# để giải quyết các bài toán về cấu trúc dữ liệu mảng (Arrays, Jagged Arrays, Multidimensional Arrays) và thuật toán cơ bản. Dự án này được phát triển như một phần của học phần Cơ sở lập trình tại Trường Đại học Kinh tế TP.HCM (UEH)

## 👨‍💻 Thông tin sinh viên
* **Họ và tên:** Võ Thanh Viễn
* **Ngành học:** Kỹ thuật phần mềm (Software Engineering)
* **Nền tảng:** .NET Console Application (C#)

## 🚀 Tính năng và Cấu trúc dự án

Dự án được tổ chức thành một menu tương tác qua Console, bao gồm 3 nhóm bài tập chính:

### Bài tập 1: Mảng lởm chởm cơ bản (Jagged Arrays)
* Khởi tạo mảng lởm chởm (Jagged array) bằng các giá trị định sẵn.
* Duyệt và hiển thị mảng dưới dạng ma trận không đồng đều.

### Bài tập 2: Mảng ngẫu nhiên & Thuật toán
* Phát sinh mảng lởm chởm với kích thước hàng/cột và giá trị hoàn toàn ngẫu nhiên (hoặc do người dùng nhập).
* **Thuật toán tích hợp:**
  * Tìm phần tử lớn nhất (Max) của từng dòng và của toàn bộ mảng.
  * Sắp xếp các phần tử theo thứ tự tăng dần trên từng dòng.
  * Lọc và hiển thị các số nguyên tố có trong mảng.
  * Tìm kiếm vị trí (hàng, cột) của một số nguyên `X` bất kỳ do người dùng nhập vào.

### Bài tập 3: Quản lý nhân sự Công ty X (Mảng 3 chiều)
* Giả lập hệ thống lưu trữ dữ liệu nhân viên bằng cấu trúc mảng 3 chiều `string[][,]`.
* Mỗi nhân viên lưu trữ 3 trường thông tin: `ID`, `Họ Tên`, và `Số lượng nhiệm vụ (Tasks)`.
* **Chức năng quản lý:**
  1. In danh sách toàn bộ nhân viên theo từng phòng ban.
  2. Tìm kiếm thông tin chi tiết của nhân viên thông qua mã `ID`.
  3. Lọc và vinh danh nhân viên xuất sắc nhất (hoàn thành nhiều Tasks nhất).

## 🛠️ Hướng dẫn cài đặt và chạy dự án

1. **Yêu cầu hệ thống:**
   * Máy tính đã cài đặt [Visual Studio](https://visualstudio.microsoft.com/) hoặc [.NET SDK](https://dotnet.microsoft.com/download).
2. **Cách chạy trên Visual Studio:**
   * Mở file solution `Lab_Tests.sln`.
   * Ở cột `Solution Explorer`, nhấp chuột phải vào project **Problem Solving** và chọn **Set as Startup Project**.
   * Nhấn `F5` hoặc nút **Start (Play)** để biên dịch và chạy chương trình.
3. **Cách sử dụng:**
   * Khi console hiện lên, nhập số tương ứng (1, 2, 3) để chọn bài tập muốn chấm/chạy thử và nhấn Enter.
   * Nhập `0` để thoát chương trình.

## 📝 Ghi chú
* Mã nguồn tuân thủ các quy tắc đặt tên (naming conventions) và sử dụng kiến thức cơ sở lập trình thuần túy (vòng lặp, rẽ nhánh, không lạm dụng các thư viện LINQ hay cấu trúc List khi không được phép).
* Hệ thống đã xử lý lỗi cơ bản (bắt lỗi nhập liệu, xử lý mảng rỗng).
