# BÀI THỰC HÀNH 5 - WINDOWS FORMS

## Bài 5.1 - Form đăng ký tài khoản và bắt lỗi giao diện

Form đăng ký tài khoản sử dụng các control cơ bản như TextBox, DateTimePicker, RadioButton, CheckBox và ErrorProvider.

Các chức năng chính:
- Nhập tên đăng nhập, mật khẩu và xác nhận mật khẩu.
- Chọn ngày sinh và giới tính.
- Kiểm tra người dùng phải từ 18 tuổi trở lên.
- Kiểm tra mật khẩu xác nhận phải trùng khớp.
- Yêu cầu đồng ý với Điều khoản dịch vụ.
- Hiển thị thông báo khi đăng ký thành công.
- Nút Làm mới để xóa dữ liệu đã nhập.

![Bài 5.1](images/Bai1.png)

---

## Bài 5.2 - Bảng tính tiền dịch vụ và chiết khấu đơn hàng

Chương trình sử dụng ComboBox và ListBox để quản lý các dịch vụ.

Các chức năng chính:
- Chọn loại dịch vụ bằng ComboBox.
- Hiển thị danh sách dịch vụ tương ứng.
- Thêm dịch vụ vào danh sách đã chọn.
- Xóa một dịch vụ hoặc xóa toàn bộ danh sách đã chọn.
- Tự động tính tổng tiền.
- Tính tỷ lệ chiết khấu và thành tiền thanh toán.

![Bài 5.2](images/Bai2.png)

---

## Bài 5.3 - Quản lý danh sách sản phẩm trong bộ nhớ

Chương trình quản lý sản phẩm bằng List<Product> và hiển thị dữ liệu trên DataGridView.

Các chức năng chính:
- Thêm sản phẩm mới.
- Sửa thông tin sản phẩm.
- Xóa sản phẩm có xác nhận.
- Tìm kiếm sản phẩm theo tên.
- Click vào một dòng trên DataGridView để đưa dữ liệu lên các ô nhập liệu.
- Click vào vùng trống để bỏ chọn và nhập sản phẩm mới.

Thông tin sản phẩm gồm:
- Mã sản phẩm.
- Tên sản phẩm.
- Đơn giá.
- Số lượng.
- Danh mục.

![Bài 5.3](images/Bai3.png)

---

## Bài 5.4 - Trình quản lý tập tin dạng TreeView và ListView

Chương trình sử dụng TreeView để hiển thị dữ liệu phân cấp và ListView để hiển thị danh sách nhân viên.

Các chức năng chính:
- Hiển thị cấu trúc Công ty, Phòng ban và Nhóm bằng TreeView.
- Click vào một phòng ban hoặc nhóm để hiển thị danh sách nhân viên tương ứng.
- ListView hiển thị các thông tin:
  - Mã nhân viên.
  - Họ tên.
  - Chức vụ.
  - Ngày vào làm.
- Có thể chuyển đổi giữa các chế độ xem:
  - Details.
  - SmallIcon.
  - LargeIcon.
  - Tile.

![Bài 5.4](images/Bai4.png)