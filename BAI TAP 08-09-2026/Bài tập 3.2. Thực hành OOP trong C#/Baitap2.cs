using System;
using System.Text;

namespace EmployeeHierarchy
{
    public class Person
    {
        public string Id { get; init; }
        public string FullName { get; set; }
        public int BirthYear { get; set; }

        public Person(string id, string fullName, int birthYear)
        {
            Id = id;
            FullName = fullName;
            BirthYear = birthYear;
        }

        public int GetAge(int currentYear)
        {
            return currentYear - BirthYear;
        }
    }

    public class Employee : Person
    {
        public decimal BaseSalary { get; set; }

        public Employee(string id, string fullName, int birthYear, decimal baseSalary)
            : base(id, fullName, birthYear)
        {
            BaseSalary = baseSalary;
        }

        public virtual decimal CalculateIncome()
        {
            return BaseSalary;
        }
    }

    public sealed class Manager : Employee
    {
        public decimal ResponsibilityAllowance { get; set; }

        public Manager(string id, string fullName, int birthYear, decimal baseSalary, decimal allowance)
            : base(id, fullName, birthYear, baseSalary)
        {
            ResponsibilityAllowance = allowance;
        }

        public override decimal CalculateIncome()
        {
            return BaseSalary + ResponsibilityAllowance;
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
                Console.WriteLine("===== NHẬP THÔNG TIN NHÂN VIÊN =====");

                Console.Write("Nhập ID: ");
                string employeeId = Console.ReadLine();

                Console.Write("Nhập họ tên: ");
                string employeeName = Console.ReadLine();

                Console.Write("Nhập năm sinh: ");
                int employeeBirthYear = int.Parse(Console.ReadLine());

                Console.Write("Nhập lương cơ bản: ");
                decimal employeeSalary = decimal.Parse(Console.ReadLine());

                Employee employee = new Employee(
                    employeeId,
                    employeeName,
                    employeeBirthYear,
                    employeeSalary
                );

                Console.WriteLine();
                Console.WriteLine("===== NHẬP THÔNG TIN QUẢN LÝ =====");

                Console.Write("Nhập ID: ");
                string managerId = Console.ReadLine();

                Console.Write("Nhập họ tên: ");
                string managerName = Console.ReadLine();

                Console.Write("Nhập năm sinh: ");
                int managerBirthYear = int.Parse(Console.ReadLine());

                Console.Write("Nhập lương cơ bản: ");
                decimal managerSalary = decimal.Parse(Console.ReadLine());

                Console.Write("Nhập phụ cấp trách nhiệm: ");
                decimal allowance = decimal.Parse(Console.ReadLine());

                Manager manager = new Manager(
                    managerId,
                    managerName,
                    managerBirthYear,
                    managerSalary,
                    allowance
                );

                Console.WriteLine();
                Console.Write("Nhập năm hiện tại: ");
                int currentYear = int.Parse(Console.ReadLine());

                Console.WriteLine();
                Console.WriteLine("===== PHIẾU LƯƠNG NHÂN VIÊN =====");
                Console.WriteLine($"ID: {employee.Id}");
                Console.WriteLine($"Tên: {employee.FullName}");
                Console.WriteLine($"Tuổi: {employee.GetAge(currentYear)}");
                Console.WriteLine($"Lương cơ bản: {employee.BaseSalary:N0} VNĐ");
                Console.WriteLine($"Thu nhập thực lĩnh: {employee.CalculateIncome():N0} VNĐ");

                Console.WriteLine();
                Console.WriteLine("===== PHIẾU LƯƠNG QUẢN LÝ =====");
                Console.WriteLine($"ID: {manager.Id}");
                Console.WriteLine($"Tên: {manager.FullName}");
                Console.WriteLine($"Tuổi: {manager.GetAge(currentYear)}");
                Console.WriteLine($"Lương cơ bản: {manager.BaseSalary:N0} VNĐ");
                Console.WriteLine($"Phụ cấp trách nhiệm: {manager.ResponsibilityAllowance:N0} VNĐ");
                Console.WriteLine($"Thu nhập thực lĩnh: {manager.CalculateIncome():N0} VNĐ");
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