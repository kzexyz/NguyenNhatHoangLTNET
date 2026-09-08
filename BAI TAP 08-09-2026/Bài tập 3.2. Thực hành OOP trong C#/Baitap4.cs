using System;
using System.Text;

namespace PaymentGatewayDemo
{
    public interface IPayable
    {
        bool ProcessPayment(decimal amount);
    }

    public interface IRefundable
    {
        bool ProcessRefund(decimal amount, string reason);
    }

    public abstract class PaymentGateway
    {
        public string TransactionId { get; init; }
        public DateTime CreationDate { get; init; }
        public string Status { get; protected set; }

        protected PaymentGateway(string transactionId)
        {
            TransactionId = transactionId;
            CreationDate = DateTime.Now;
            Status = "Pending";
        }

        public abstract void ValidateConnection();

        public virtual void LogTransaction(string message)
        {
            Console.WriteLine($"[{TransactionId}] {message}");
        }
    }

    public class MomoPayment : PaymentGateway, IPayable, IRefundable
    {
        public string PhoneNumber { get; set; }

        public MomoPayment(string transactionId, string phoneNumber)
            : base(transactionId)
        {
            PhoneNumber = phoneNumber;
        }

        public override void ValidateConnection()
        {
            Console.WriteLine("Đang kiểm tra kết nối API MoMo...");
            Console.WriteLine("Kết nối API MoMo thành công.");
        }

        public bool ProcessPayment(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Số tiền thanh toán phải lớn hơn 0.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(PhoneNumber))
            {
                Console.WriteLine("Số điện thoại không hợp lệ.");
                return false;
            }

            Status = "Success";
            LogTransaction($"Thanh toán thành công {amount:N0} VNĐ.");
            return true;
        }

        public bool ProcessRefund(decimal amount, string reason)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Số tiền hoàn phải lớn hơn 0.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(reason))
            {
                Console.WriteLine("Lý do hoàn tiền không được để trống.");
                return false;
            }

            Status = "Refunded";
            LogTransaction($"Hoàn tiền thành công {amount:N0} VNĐ.");
            Console.WriteLine($"Lý do hoàn tiền: {reason}");
            return true;
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
                Console.WriteLine("===== NHẬP THÔNG TIN GIAO DỊCH =====");

                Console.Write("Nhập mã giao dịch: ");
                string transactionId = Console.ReadLine();

                Console.Write("Nhập số điện thoại MoMo: ");
                string phoneNumber = Console.ReadLine();

                MomoPayment momo = new MomoPayment(transactionId, phoneNumber);

                Console.WriteLine();
                Console.WriteLine("===== THÔNG TIN GIAO DỊCH =====");
                Console.WriteLine($"Mã giao dịch: {momo.TransactionId}");
                Console.WriteLine($"Ngày tạo: {momo.CreationDate:dd/MM/yyyy HH:mm:ss}");
                Console.WriteLine($"Trạng thái: {momo.Status}");

                Console.WriteLine();
                Console.WriteLine("===== KIỂM TRA KẾT NỐI =====");
                momo.ValidateConnection();

                Console.WriteLine();
                Console.WriteLine("===== THANH TOÁN =====");

                Console.Write("Nhập số tiền thanh toán: ");
                decimal paymentAmount = decimal.Parse(Console.ReadLine());

                IPayable payable = momo;
                bool paymentResult = payable.ProcessPayment(paymentAmount);

                Console.WriteLine();
                Console.WriteLine($"Kết quả thanh toán: {(paymentResult ? "Thành công" : "Thất bại")}");
                Console.WriteLine($"Trạng thái hiện tại: {momo.Status}");

                Console.WriteLine();
                Console.Write("Bạn có muốn hoàn tiền? (y/n): ");
                string answer = Console.ReadLine();

                if (answer.ToLower() == "y")
                {
                    Console.WriteLine();
                    Console.WriteLine("===== HOÀN TIỀN =====");

                    Console.Write("Nhập số tiền hoàn: ");
                    decimal refundAmount = decimal.Parse(Console.ReadLine());

                    Console.Write("Nhập lý do hoàn tiền: ");
                    string reason = Console.ReadLine();

                    IRefundable refundable = momo;
                    bool refundResult = refundable.ProcessRefund(refundAmount, reason);

                    Console.WriteLine();
                    Console.WriteLine($"Kết quả hoàn tiền: {(refundResult ? "Thành công" : "Thất bại")}");
                    Console.WriteLine($"Trạng thái hiện tại: {momo.Status}");
                }

                Console.WriteLine();
                Console.WriteLine("===== KẾT THÚC GIAO DỊCH =====");
                momo.LogTransaction("Kết thúc giao dịch.");
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Lỗi: Dữ liệu nhập vào không đúng định dạng.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine();
                Console.WriteLine($"Lỗi: {ex.Message}");
            }

            Console.ReadKey();
        }
    }
}