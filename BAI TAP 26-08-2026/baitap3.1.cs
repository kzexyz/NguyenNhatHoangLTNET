using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap so thu nhat a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap so thu hai b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Nhap phep toan (+, -, *, /, %): ");
        char op = Convert.ToChar(Console.ReadLine());

        switch (op)
        {
            case '+':
                Console.WriteLine("Ket qua: " + (a + b));
                break;

            case '-':
                Console.WriteLine("Ket qua: " + (a - b));
                break;

            case '*':
                Console.WriteLine("Ket qua: " + (a * b));
                break;

            case '/':
                if (b == 0)
                {
                    Console.WriteLine("Loi: Khong the chia cho 0!");
                }
                else
                {
                    Console.WriteLine("Ket qua: " + (a / b));
                }
                break;

            case '%':
                if (b == 0)
                {
                    Console.WriteLine("Loi: Khong the chia cho 0!");
                }
                else
                {
                    Console.WriteLine("Ket qua: " + (a % b));
                }
                break;

            default:
                Console.WriteLine("Phep toan khong hop le!");
                break;
        }
    }
}