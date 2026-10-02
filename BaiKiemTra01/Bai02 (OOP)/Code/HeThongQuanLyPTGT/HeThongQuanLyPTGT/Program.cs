using System;
using System.Collections.Generic;
using System.Linq;

abstract class PhuongTien
{
    private string _maPT;
    private string _tenHang;
    private int _namSanXuat;
    private decimal _giaGoc;

    public string MaPT
    {
        get { return _maPT; }
        set { _maPT = string.IsNullOrWhiteSpace(value) ? "PT000" : value; }
    }

    public string TenHang
    {
        get { return _tenHang; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Tên hãng không được để trống!");
            _tenHang = value;
        }
    }

    public int NamSanXuat
    {
        get { return _namSanXuat; }
        set
        {
            int namHienTai = DateTime.Now.Year;
            if (value < 1900 || value > namHienTai)
                throw new ArgumentException("Năm sản xuất không hợp lệ!");
            _namSanXuat = value;
        }
    }

    public decimal GiaGoc
    {
        get { return _giaGoc; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Giá gốc phải lớn hơn 0!");
            _giaGoc = value;
        }
    }

    public PhuongTien(string maPT, string tenHang, int namSanXuat, decimal giaGoc)
    {
        MaPT = maPT;
        TenHang = tenHang;
        NamSanXuat = namSanXuat;
        GiaGoc = giaGoc;
    }

    public abstract decimal TinhGiaLanBanh();

    public virtual string GetInfo()
    {
        return $"Mã phương tiện : {MaPT}\n" +
               $"Hãng xe        : {TenHang}\n" +
               $"Năm sản xuất   : {NamSanXuat}\n" +
               $"Giá gốc        : {GiaGoc:N0} VNĐ";
    }
}

class OTo : PhuongTien
{
    private int _soChoNgoi;
    private double _dungTichDongCo;

    public int SoChoNgoi
    {
        get { return _soChoNgoi; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Số chỗ ngồi phải lớn hơn 0!");
            _soChoNgoi = value;
        }
    }

    public double DungTichDongCo
    {
        get { return _dungTichDongCo; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Dung tích động cơ phải lớn hơn 0!");
            _dungTichDongCo = value;
        }
    }

    public OTo(string maPT, string tenHang, int namSanXuat, decimal giaGoc,
        int soChoNgoi, double dungTichDongCo)
        : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        SoChoNgoi = soChoNgoi;
        DungTichDongCo = dungTichDongCo;
    }

    public override decimal TinhGiaLanBanh()
    {
        if (SoChoNgoi <= 9)
            return GiaGoc + GiaGoc * 0.12m + GiaGoc * 0.30m;

        return GiaGoc + GiaGoc * 0.10m;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + "\n" +
               $"Số chỗ ngồi    : {SoChoNgoi}\n" +
               $"Động cơ        : {DungTichDongCo} L";
    }
}

class XeMay : PhuongTien
{
    private int _dungTichXylanh;

    public int DungTichXylanh
    {
        get { return _dungTichXylanh; }
        set
        {
            if (value <= 0)
                throw new ArgumentException("Dung tích xylanh phải lớn hơn 0!");
            _dungTichXylanh = value;
        }
    }

    public XeMay(string maPT, string tenHang, int namSanXuat, decimal giaGoc,
        int dungTichXylanh)
        : base(maPT, tenHang, namSanXuat, giaGoc)
    {
        DungTichXylanh = dungTichXylanh;
    }

    public override decimal TinhGiaLanBanh()
    {
        if (DungTichXylanh < 175)
            return GiaGoc + GiaGoc * 0.02m;

        return GiaGoc + GiaGoc * 0.05m;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + "\n" +
               $"Dung tích       : {DungTichXylanh} cc";
    }
}

class QuanLyPhuongTien
{
    private readonly List<PhuongTien> danhSach = new List<PhuongTien>();

    public void AddPhuongTien(PhuongTien pt)
    {
        danhSach.Add(pt);
    }

    public void DisplayAll()
    {
        Console.WriteLine("\n========== DANH SÁCH PHƯƠNG TIỆN ==========");

        if (danhSach.Count == 0)
        {
            Console.WriteLine("Hiện chưa có phương tiện nào trong danh sách.");
            return;
        }

        int stt = 1;
        foreach (PhuongTien pt in danhSach)
        {
            Console.WriteLine($"\n[{stt}] {LayTenLoai(pt)}");
            Console.WriteLine(pt.GetInfo());
            Console.WriteLine($"Giá lăn bánh   : {pt.TinhGiaLanBanh():N0} VNĐ");
            Console.WriteLine(new string('-', 44));
            stt++;
        }

        Console.WriteLine($"Tổng số phương tiện: {danhSach.Count}");
    }

    private static string LayTenLoai(PhuongTien pt)
    {
        return pt is OTo ? "Ô TÔ" : "XE MÁY";
    }

    public PhuongTien FindMaxGiaLanBanh()
    {
        if (danhSach.Count == 0)
            return null;

        return danhSach.OrderByDescending(pt => pt.TinhGiaLanBanh()).First();
    }

    public List<PhuongTien> SearchByName(string keyword)
    {
        if (keyword == null)
            keyword = string.Empty;

        return danhSach
            .Where(pt => pt.TenHang.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
            .ToList();
    }
}

class Program
{
    static readonly QuanLyPhuongTien ql = new QuanLyPhuongTien();

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        int chon;
        do
        {
            HienThiMenu();
            Console.Write("Chọn chức năng: ");

            if (!int.TryParse(Console.ReadLine(), out chon))
            {
                Console.WriteLine("[!] Vui lòng nhập một số từ 0 đến 5.");
                continue;
            }

            try
            {
                switch (chon)
                {
                    case 1:
                        ThemOTo();
                        break;
                    case 2:
                        ThemXeMay();
                        break;
                    case 3:
                        ql.DisplayAll();
                        break;
                    case 4:
                        TimGiaCaoNhat();
                        break;
                    case 5:
                        TimTheoHang();
                        break;
                    case 0:
                        Console.WriteLine("\nĐã kết thúc chương trình.");
                        break;
                    default:
                        Console.WriteLine("[!] Lựa chọn không hợp lệ.");
                        break;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"\n[LOI] {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("\n[LOI] Dữ liệu số nhập vào không đúng định dạng.");
            }

        } while (chon != 0);
    }

    static void HienThiMenu()
    {
        Console.WriteLine("\n============================================");
        Console.WriteLine("        HỆ THỐNG QUẢN LÝ PHƯƠNG TIỆN");
        Console.WriteLine("============================================");
        Console.WriteLine("[1] Thêm ô tô");
        Console.WriteLine("[2] Thêm xe máy");
        Console.WriteLine("[3] Xem danh sách phương tiện");
        Console.WriteLine("[4] Phương tiện có giá lăn bánh cao nhất");
        Console.WriteLine("[5] Tìm kiếm theo hãng");
        Console.WriteLine("[0] Thoát");
        Console.WriteLine("--------------------------------------------");
    }

    static void ThemOTo()
    {
        Console.WriteLine("\n--- NHẬP THÔNG TIN Ô TÔ ---");

        Console.Write("Mã phương tiện : ");
        string ma = Console.ReadLine();

        Console.Write("Hãng xe        : ");
        string hang = Console.ReadLine();

        Console.Write("Năm sản xuất   : ");
        int nam = int.Parse(Console.ReadLine());

        Console.Write("Giá gốc        : ");
        decimal gia = decimal.Parse(Console.ReadLine());

        Console.Write("Số chỗ ngồi    : ");
        int soCho = int.Parse(Console.ReadLine());

        Console.Write("Động cơ (L)    : ");
        double dungTich = double.Parse(Console.ReadLine());

        OTo oto = new OTo(ma, hang, nam, gia, soCho, dungTich);
        ql.AddPhuongTien(oto);

        Console.WriteLine("\n[OK] Đã thêm ô tô vào danh sách.");
        Console.WriteLine($"Giá lăn bánh dự kiến: {oto.TinhGiaLanBanh():N0} VNĐ");
    }

    static void ThemXeMay()
    {
        Console.WriteLine("\n--- NHẬP THÔNG TIN XE MÁY ---");

        Console.Write("Mã phương tiện : ");
        string ma = Console.ReadLine();

        Console.Write("Hãng xe        : ");
        string hang = Console.ReadLine();

        Console.Write("Năm sản xuất   : ");
        int nam = int.Parse(Console.ReadLine());

        Console.Write("Giá gốc        : ");
        decimal gia = decimal.Parse(Console.ReadLine());

        Console.Write("Dung tích (cc) : ");
        int xylanh = int.Parse(Console.ReadLine());

        XeMay xeMay = new XeMay(ma, hang, nam, gia, xylanh);
        ql.AddPhuongTien(xeMay);

        Console.WriteLine("\n[OK] Đã thêm xe máy vào danh sách.");
        Console.WriteLine($"Giá lăn bánh dự kiến: {xeMay.TinhGiaLanBanh():N0} VNĐ");
    }

    static void TimGiaCaoNhat()
    {
        PhuongTien pt = ql.FindMaxGiaLanBanh();

        Console.WriteLine("\n===== PHƯƠNG TIỆN CÓ GIÁ LĂN BÁNH CAO NHẤT =====");

        if (pt == null)
        {
            Console.WriteLine("Danh sách phương tiện đang trống.");
            return;
        }

        Console.WriteLine($"Loại           : {(pt is OTo ? "Ô tô" : "Xe máy")}");
        Console.WriteLine(pt.GetInfo());
        Console.WriteLine($"Giá lăn bánh   : {pt.TinhGiaLanBanh():N0} VNĐ");
    }

    static void TimTheoHang()
    {
        Console.Write("\nNhập tên hãng cần tìm: ");
        string keyword = Console.ReadLine();

        List<PhuongTien> ketQua = ql.SearchByName(keyword);

        Console.WriteLine("\n========== KẾT QUẢ TÌM KIẾM ==========");

        if (ketQua.Count == 0)
        {
            Console.WriteLine("Không tìm thấy phương tiện phù hợp.");
            return;
        }

        int stt = 1;
        foreach (PhuongTien pt in ketQua)
        {
            Console.WriteLine($"\nKết quả #{stt}");
            Console.WriteLine(pt.GetInfo());
            Console.WriteLine($"Giá lăn bánh   : {pt.TinhGiaLanBanh():N0} VNĐ");
            Console.WriteLine(new string('-', 40));
            stt++;
        }
    }
}
