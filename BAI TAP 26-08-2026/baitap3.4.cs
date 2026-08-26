using System;

class Program
{
    static void Main(string[] args)
    {
        int choice;

        do
        {
            Console.Clear();

            Console.WriteLine("===== MENU =====");
            Console.WriteLine("1. Chay Bai tap 1");
            Console.WriteLine("2. Chay Bai tap 2");
            Console.WriteLine("3. Chay Bai tap 3");
            Console.WriteLine("0. Thoat");

            Console.Write("Nhap lua chon: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Chay Bai 1");
                    break;

                case 2:
                    Console.WriteLine("Chay Bai 2");
                    break;

                case 3:
                    Console.WriteLine("Chay Bai 3");
                    break;

                case 0:
                    Console.WriteLine("Thoat chuong trinh");
                    break;

                default:
                    Console.WriteLine("Lua chon khong hop le!");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Nhan phim bat ky de tiep tuc...");
            Console.ReadKey();

        } while (choice != 0);
    }
}