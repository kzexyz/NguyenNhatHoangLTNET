# BÀI 1 - PHẦN LÝ THUYẾT

## Câu 1: Sự khác nhau giữa Value Types và Reference Types

**Value Types** là kiểu dữ liệu lưu trực tiếp giá trị. Khi gán biến này cho biến khác thì giá trị được sao chép riêng, nên thay đổi biến mới không ảnh hưởng đến biến cũ.

Ví dụ các kiểu: `int`, `double`, `bool`, `char`, `struct`, `enum`.

```csharp
int a = 10;
int b = a;
b = 20;

Console.WriteLine(a); // 10
```

**Reference Types** là kiểu dữ liệu lưu tham chiếu đến đối tượng trong bộ nhớ. Khi gán biến này cho biến khác thì hai biến có thể cùng tham chiếu đến một đối tượng.

Ví dụ các kiểu: `class`, `string`, `array`, `interface`, `delegate`.

```csharp
Person p1 = new Person();
Person p2 = p1;
```

Nếu thay đổi dữ liệu thông qua `p2` thì dữ liệu mà `p1` tham chiếu đến cũng thay đổi.

---

## Câu 2: Init-only Properties trong C# 9/10

Thuộc tính có `set` cho phép thay đổi giá trị cả sau khi đối tượng đã được tạo.

Thuộc tính có `init` chỉ cho phép gán giá trị khi khởi tạo đối tượng. Sau khi khởi tạo xong thì không thể thay đổi lại.

Ví dụ:

```csharp
class SinhVien
{
    public string HoTen { get; init; }
}

SinhVien sv = new SinhVien
{
    HoTen = "Nguyen Nhat Hoang"
};
```

`init` phù hợp với những dữ liệu chỉ cần gán một lần, ví dụ mã sinh viên, mã sản phẩm hoặc mã đơn hàng.

---

## Câu 3: Phân biệt `virtual` và `override`

`virtual` được khai báo ở lớp cha để cho phép lớp con có thể ghi đè phương thức đó.

`override` được khai báo ở lớp con để viết lại nội dung của phương thức `virtual` ở lớp cha.

Ví dụ:

```csharp
class PhuongTien
{
    public virtual void HienThi()
    {
        Console.WriteLine("Phuong tien");
    }
}

class OTo : PhuongTien
{
    public override void HienThi()
    {
        Console.WriteLine("O to");
    }
}
```

Khi sử dụng đối tượng lớp con thông qua biến lớp cha, phương thức được gọi sẽ phụ thuộc vào đối tượng thực tế. Đây là tính đa hình.

---

## Câu 4: Vì sao `static` không thể truy cập trực tiếp thành phần instance?

Thành phần `static` thuộc về lớp, còn thành phần instance thuộc về từng đối tượng được tạo bằng `new`.

Vì một lớp có thể có nhiều đối tượng khác nhau nên phương thức `static` không biết phải truy cập dữ liệu của đối tượng nào.

Ví dụ:

```csharp
class SinhVien
{
    public string HoTen;

    public static void HienThi()
    {
        // Không thể truy cập trực tiếp HoTen
    }
}
```

Muốn truy cập `HoTen` thì phải thông qua một đối tượng cụ thể:

```csharp
SinhVien sv = new SinhVien();
sv.HoTen = "Nguyen Nhat Hoang";

Console.WriteLine(sv.HoTen);
```