\# BÀI 1 - PHẦN LÝ THUYẾT



\## Câu 1: Trình bày sự khác nhau giữa Value Types và Reference Types trong C#



\- \*\*Value Types (Kiểu giá trị)\*\* lưu trực tiếp giá trị của biến trong vùng nhớ.

\- Khi gán một biến Value Type cho một biến khác, giá trị sẽ được sao chép sang biến mới. Vì vậy, thay đổi biến mới không làm ảnh hưởng đến biến ban đầu.

\- Một số kiểu Value Type thường gặp: `int`, `double`, `float`, `bool`, `char`, `struct`, `enum`.



Ví dụ:



```csharp

int a = 10;

int b = a;



b = 20;



Console.WriteLine(a); // 10

Console.WriteLine(b); // 20

```



\- \*\*Reference Types (Kiểu tham chiếu)\*\* lưu tham chiếu đến đối tượng trong bộ nhớ.

\- Khi gán một biến Reference Type cho biến khác, hai biến có thể cùng tham chiếu đến một đối tượng. Vì vậy, thay đổi dữ liệu thông qua một biến có thể ảnh hưởng đến biến còn lại.

\- Một số kiểu Reference Type thường gặp: `class`, `string`, `array`, `interface`, `delegate`.



Ví dụ:



```csharp

class Person

{

&#x20;   public string Name { get; set; }

}



Person p1 = new Person();

p1.Name = "Hoang";



Person p2 = p1;

p2.Name = "Nhat Hoang";



Console.WriteLine(p1.Name); // Nhat Hoang

```



\---



\## Câu 2: Tính năng Init-only Properties (`init`) trong C# 9/10 khác gì so với thuộc tính có `set` thông thường? Nêu trường hợp sử dụng thực tế



\- Thuộc tính có `set` thông thường cho phép thay đổi giá trị của thuộc tính sau khi đối tượng đã được khởi tạo.

\- Thuộc tính có `init` chỉ cho phép gán giá trị trong lúc khởi tạo đối tượng. Sau khi đối tượng đã được tạo xong thì không thể thay đổi giá trị đó nữa.



Ví dụ với `set`:



```csharp

class SinhVien

{

&#x20;   public string HoTen { get; set; }

}



SinhVien sv = new SinhVien();

sv.HoTen = "Nguyen Nhat Hoang";



sv.HoTen = "Ten moi";

```



Giá trị của `HoTen` vẫn có thể thay đổi sau khi đối tượng đã được tạo.



Ví dụ với `init`:



```csharp

class SinhVien

{

&#x20;   public string HoTen { get; init; }

}



SinhVien sv = new SinhVien

{

&#x20;   HoTen = "Nguyen Nhat Hoang"

};

```



Sau khi đã khởi tạo, nếu viết:



```csharp

sv.HoTen = "Ten moi";

```



thì chương trình sẽ báo lỗi biên dịch.



\- `init` thường được sử dụng khi muốn dữ liệu của đối tượng được thiết lập một lần khi khởi tạo và không bị thay đổi về sau.

\- Ví dụ thực tế: mã sinh viên, mã đơn hàng, mã sản phẩm hoặc dữ liệu cấu hình cần giữ cố định sau khi tạo đối tượng.



\---



\## Câu 3: Phân biệt sự khác nhau giữa phương thức `virtual` ở lớp cha và phương thức `override` ở lớp con khi triển khai tính Đa hình (Polymorphism)



\- `virtual` được khai báo ở lớp cha để cho phép lớp con có thể ghi đè lại phương thức đó.

\- `override` được sử dụng ở lớp con để viết lại cách hoạt động của phương thức đã được khai báo là `virtual` ở lớp cha.



Ví dụ:



```csharp

class PhuongTien

{

&#x20;   public virtual void HienThiThongTin()

&#x20;   {

&#x20;       Console.WriteLine("Thong tin phuong tien");

&#x20;   }

}

```



Lớp con:



```csharp

class OTo : PhuongTien

{

&#x20;   public override void HienThiThongTin()

&#x20;   {

&#x20;       Console.WriteLine("Thong tin o to");

&#x20;   }

}

```



Khi sử dụng:



```csharp

PhuongTien pt = new OTo();

pt.HienThiThongTin();

```



Kết quả:



```text

Thong tin o to

```



Mặc dù biến `pt` có kiểu `PhuongTien`, đối tượng thực tế được tạo là `OTo`, nên phương thức của lớp `OTo` được gọi.



Đây chính là tính đa hình trong lập trình hướng đối tượng.



\---



\## Câu 4: Tại sao một thành phần được khai báo là `static` trong lớp lại không thể truy xuất trực tiếp một thành phần thể hiện (Object Instance) được tạo bằng từ khóa `new`?



\- Thành phần `static` thuộc về lớp, không thuộc về một đối tượng cụ thể.

\- Thành phần instance thuộc về từng đối tượng được tạo ra bằng từ khóa `new`.

\- Một lớp có thể tạo ra nhiều đối tượng khác nhau, mỗi đối tượng có giá trị thuộc tính riêng.



Ví dụ:



```csharp

class SinhVien

{

&#x20;   public string HoTen;



&#x20;   public static void HienThi()

&#x20;   {

&#x20;       // Console.WriteLine(HoTen);

&#x20;   }

}

```



Trong phương thức `static HienThi()`, không thể truy cập trực tiếp `HoTen` vì chương trình không biết phải lấy `HoTen` của đối tượng nào.



Muốn truy cập thành phần instance thì phải thông qua một đối tượng cụ thể:



```csharp

SinhVien sv = new SinhVien();

sv.HoTen = "Nguyen Nhat Hoang";



Console.WriteLine(sv.HoTen);

```



Vì vậy, thành phần `static` chỉ có thể truy cập trực tiếp các thành phần `static` khác. Nếu muốn truy cập thành phần instance thì cần có một đối tượng cụ thể được tạo bằng từ khóa `new`.

