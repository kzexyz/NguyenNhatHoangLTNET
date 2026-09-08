using System;
using System.Text;

namespace BankAccountDemo
{
    public class BankAccount
    {
        private static long _nextAccountNumber = 1000000001;
        private const decimal MinimumBalance = 50_000m;
        private decimal _balance;
        private string _accountHolder;

        public long AccountNumber { get; init; }

        public string AccountHolder
        {
            get { return _accountHolder; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Tên chủ tài khoản không được để trống.");

                _accountHolder = value;
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }

        public BankAccount(string accountHolder, decimal initialBalance)
        {
            if (initialBalance < MinimumBalance)
                throw new ArgumentException($"Số dư ban đầu phải ít nhất {MinimumBalance:N0} VNĐ.");

            AccountNumber = _nextAccountNumber++;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Số tiền nạp phải lớn hơn 0.");

            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount <= 0)
                return false;

            if (Balance - amount < MinimumBalance)
                return false;

            Balance -= amount;
            return true;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Số TK: {AccountNumber}");
            Console.WriteLine($"Chủ TK: {AccountHolder}");
            Console.WriteLine($"Số dư: {Balance:N0} VNĐ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            try
            {
                Console.WriteLine("===== NHẬP TÀI KHOẢN 1 =====");
                Console.Write("Tên chủ tài khoản: ");
                string name1 = Console.ReadLine();

                Console.Write("Số dư ban đầu: ");
                decimal balance1 = decimal.Parse(Console.ReadLine());

                BankAccount account1 = new BankAccount(name1, balance1);

                Console.WriteLine();
                Console.WriteLine("===== NHẬP TÀI KHOẢN 2 =====");
                Console.Write("Tên chủ tài khoản: ");
                string name2 = Console.ReadLine();

                Console.Write("Số dư ban đầu: ");
                decimal balance2 = decimal.Parse(Console.ReadLine());

                BankAccount account2 = new BankAccount(name2, balance2);

                Console.WriteLine();
                Console.WriteLine("===== THÔNG TIN 2 TÀI KHOẢN =====");

                Console.WriteLine();
                Console.WriteLine("Tài khoản 1:");
                account1.DisplayInfo();

                Console.WriteLine();
                Console.WriteLine("Tài khoản 2:");
                account2.DisplayInfo();

                Console.WriteLine();
                Console.WriteLine("===== NẠP TIỀN =====");

                Console.Write("Nhập số tiền nạp: ");
                decimal depositAmount = decimal.Parse(Console.ReadLine());

                account1.Deposit(depositAmount);

                Console.WriteLine($"Nạp thành công {depositAmount:N0} VNĐ.");
                Console.WriteLine($"Số dư mới: {account1.Balance:N0} VNĐ");

                Console.WriteLine();
                Console.WriteLine("===== RÚT TIỀN =====");

                Console.Write("Nhập số tiền rút: ");
                decimal withdrawAmount = decimal.Parse(Console.ReadLine());

                if (account1.Withdraw(withdrawAmount))
                {
                    Console.WriteLine($"Rút thành công {withdrawAmount:N0} VNĐ.");
                    Console.WriteLine($"Số dư còn lại: {account1.Balance:N0} VNĐ");
                }
                else
                {
                    Console.WriteLine("Rút tiền thất bại. Số dư phải còn ít nhất 50.000 VNĐ.");
                }

                Console.WriteLine();
                Console.WriteLine("===== KIỂM TRA TÀI KHOẢN KHÔNG HỢP LỆ =====");

                Console.Write("Tên chủ tài khoản: ");
                string name3 = Console.ReadLine();

                Console.Write("Số dư ban đầu: ");
                decimal balance3 = decimal.Parse(Console.ReadLine());

                BankAccount account3 = new BankAccount(name3, balance3);

                Console.WriteLine("Tạo tài khoản thành công.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Lỗi: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Lỗi: Dữ liệu nhập vào không đúng định dạng.");
            }

            Console.ReadKey();
        }
    }
}