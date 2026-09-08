using System;
using System.Collections.Generic;
using System.Text;

namespace OrderProcessing
{
    public class DiscountCalculator
    {
        public decimal ApplyDiscount(decimal totalAmount)
        {
            return totalAmount * 0.95m;
        }

        public decimal ApplyDiscount(decimal totalAmount, double percentage)
        {
            if (percentage < 0 || percentage > 100)
                throw new ArgumentException("Phần trăm giảm giá phải từ 0 đến 100.");

            decimal discount = totalAmount * (decimal)percentage / 100;
            return totalAmount - discount;
        }

        public decimal ApplyDiscount(decimal totalAmount, decimal fixedVoucher, decimal minimumOrder)
        {
            if (fixedVoucher < 0)
                throw new ArgumentException("Giá trị voucher không được âm.");

            if (totalAmount >= minimumOrder)
                return totalAmount - fixedVoucher;

            return totalAmount;
        }
    }

    public class DeliveryService
    {
        public string OrderId { get; set; }
        public double DistanceKm { get; set; }

        public DeliveryService(string orderId, double distanceKm)
        {
            OrderId = orderId;
            DistanceKm = distanceKm;
        }

        public virtual decimal CalculateShippingFee()
        {
            return (decimal)DistanceKm * 5000m;
        }
    }

    public class ExpressDelivery : DeliveryService
    {
        public ExpressDelivery(string orderId, double distanceKm)
            : base(orderId, distanceKm)
        {
        }

        public override decimal CalculateShippingFee()
        {
            decimal basicFee = base.CalculateShippingFee();
            return basicFee * 1.5m + 20_000m;
        }
    }

    public class EcoDelivery : DeliveryService
    {
        public EcoDelivery(string orderId, double distanceKm)
            : base(orderId, distanceKm)
        {
        }

        public override decimal CalculateShippingFee()
        {
            decimal basicFee = base.CalculateShippingFee();

            if (DistanceKm > 10)
                return basicFee * 0.9m;

            return basicFee;
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
                DiscountCalculator calculator = new DiscountCalculator();

                Console.WriteLine("===== METHOD OVERLOADING =====");
                Console.Write("Nhập tổng giá trị đơn hàng: ");
                decimal totalAmount = decimal.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("Giảm giá mặc định 5%");

                decimal result1 = calculator.ApplyDiscount(totalAmount);
                Console.WriteLine($"Số tiền sau giảm: {result1:N0} VNĐ");

                Console.WriteLine();
                Console.Write("Nhập phần trăm muốn giảm: ");
                double percentage = double.Parse(Console.ReadLine());

                decimal result2 = calculator.ApplyDiscount(totalAmount, percentage);
                Console.WriteLine($"Số tiền sau giảm {percentage}%: {result2:N0} VNĐ");

                Console.WriteLine();
                Console.Write("Nhập giá trị voucher: ");
                decimal voucher = decimal.Parse(Console.ReadLine());

                Console.Write("Nhập giá trị đơn hàng tối thiểu: ");
                decimal minimumOrder = decimal.Parse(Console.ReadLine());

                decimal result3 = calculator.ApplyDiscount(
                    totalAmount,
                    voucher,
                    minimumOrder
                );

                Console.WriteLine($"Số tiền sau khi áp dụng voucher: {result3:N0} VNĐ");

                Console.WriteLine();
                Console.WriteLine("===== RUNTIME POLYMORPHISM =====");

                Console.Write("Nhập mã đơn hàng Express: ");
                string expressOrderId = Console.ReadLine();

                Console.Write("Nhập quãng đường Express (km): ");
                double expressDistance = double.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Nhập mã đơn hàng Eco: ");
                string ecoOrderId = Console.ReadLine();

                Console.Write("Nhập quãng đường Eco (km): ");
                double ecoDistance = double.Parse(Console.ReadLine());

                List<DeliveryService> deliveries = new List<DeliveryService>
                {
                    new ExpressDelivery(expressOrderId, expressDistance),
                    new EcoDelivery(ecoOrderId, ecoDistance)
                };

                Console.WriteLine();

                foreach (DeliveryService delivery in deliveries)
                {
                    Console.WriteLine("----- THÔNG TIN GIAO HÀNG -----");
                    Console.WriteLine($"Mã đơn hàng: {delivery.OrderId}");
                    Console.WriteLine($"Quãng đường: {delivery.DistanceKm} km");
                    Console.WriteLine($"Loại giao hàng: {delivery.GetType().Name}");
                    Console.WriteLine($"Phí vận chuyển: {delivery.CalculateShippingFee():N0} VNĐ");
                    Console.WriteLine();
                }
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