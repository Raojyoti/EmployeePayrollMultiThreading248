using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class EmployeeDetails
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public char Gender { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }
        public string Department { get; set; }
        public double BasicPay { get; set; }
        public double Deductions { get; set; }
        public double TaxablePay { get; set; }
        public double IncomeTax { get; set; }
        public double NetPay { get; set; }
        public EmployeeDetails(int Id, string Name, float Salary, char Gender, string Address, long PhoneNumber, string Department, double BasicPay, double Deductions, double TaxablePay, double IncomeTax, double NetPay) 
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
            this.Gender = Gender;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.Department = Department;
            this.BasicPay = BasicPay;
            this.Deductions = Deductions;
            this.TaxablePay = TaxablePay;
            this.IncomeTax = IncomeTax;
            this.NetPay = NetPay;
        }
    }
}
