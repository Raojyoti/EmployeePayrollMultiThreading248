using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollMultiThreading
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            List<EmployeeDetails> employeeDetails = new List<EmployeeDetails>();
            employeeDetails.Add(new EmployeeDetails(Id: 1, Name: "Jyoti", Salary: 850000, Gender: 'F', Address: "Noida", PhoneNumber: 7815879856, Department: "Software Developer", BasicPay: 785000, Deductions: 1500, TaxablePay: 1000, IncomeTax: 2000, NetPay: 1500));
            employeeDetails.Add(new EmployeeDetails(Id: 2, Name: "Wayne", Salary: 750000, Gender: 'F', Address: "Delhi", PhoneNumber: 8815879856, Department: "Account", BasicPay: 705000, Deductions: 2500, TaxablePay: 1500, IncomeTax: 2500, NetPay: 2500));
            employeeDetails.Add(new EmployeeDetails(Id: 3, Name: "Peter", Salary: 650000, Gender: 'M', Address: "Agra", PhoneNumber: 9815879856, Department: "HR", BasicPay: 715000, Deductions: 3500, TaxablePay: 1200, IncomeTax: 2100, NetPay: 3500));
            employeeDetails.Add(new EmployeeDetails(Id: 4, Name: "Parker", Salary: 550000, Gender: 'M', Address: "Khurja", PhoneNumber: 8815879856, Department: "IT", BasicPay: 725000, Deductions: 4500, TaxablePay: 1300, IncomeTax: 2200, NetPay: 4500));
            employeeDetails.Add(new EmployeeDetails(Id: 5, Name: "Tony", Salary: 450000, Gender: 'M', Address: "Noida", PhoneNumber: 7815879856, Department: "Sales", BasicPay: 785900, Deductions: 1570, TaxablePay: 1400, IncomeTax: 2600, NetPay: 5500));
            employeeDetails.Add(new EmployeeDetails(Id: 6, Name: "Stark", Salary: 850000, Gender: 'M', Address: "Greater Noida", PhoneNumber: 7365879856, Department: "Marketing", BasicPay: 785000, Deductions: 1300, TaxablePay: 1900, IncomeTax: 2700, NetPay: 6500));
            employeeDetails.Add(new EmployeeDetails(Id: 7, Name: "Brucer", Salary: 470000, Gender: 'M', Address: "Delhi", PhoneNumber: 9915879856, Department: "Production", BasicPay: 775000, Deductions: 1590, TaxablePay: 2000, IncomeTax: 3000, NetPay: 7500));
            employeeDetails.Add(new EmployeeDetails(Id: 8, Name: "Banner", Salary: 660000, Gender: 'M', Address: "Noida", PhoneNumber: 9615879856, Department: "HR", BasicPay: 735000, Deductions: 1560, TaxablePay: 2100, IncomeTax: 3000, NetPay: 1500));
            employeeDetails.Add(new EmployeeDetails(Id: 9, Name: "Clark", Salary: 860000, Gender: 'M', Address: "Mumbai", PhoneNumber: 7235879856, Department: "Tester", BasicPay: 785050, Deductions: 1509, TaxablePay: 2400, IncomeTax: 3100, NetPay: 2500));
            employeeDetails.Add(new EmployeeDetails(Id: 10, Name: "Kent", Salary: 770000, Gender: 'F', Address: "Agra", PhoneNumber: 7818879856, Department: "IT", BasicPay: 785250, Deductions: 1507, TaxablePay: 2300, IncomeTax: 3200, NetPay: 2600));

            EmployeePayRollOperations employeePayRoll = new EmployeePayRollOperations();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Employee Payroll MultiThreading");
                Console.WriteLine("Please select given options:---\n--------------------------------");
                Console.WriteLine("1.Add mutliple employee to payrollDB witout thread\n" +
                    "10.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.Clear();
                        DateTime startdateTime = DateTime.Now;
                        employeePayRoll.AddEmployeeToPayroll(employeeDetails);
                        DateTime stopdateTime = DateTime.Now;
                        Console.WriteLine("Duation without thread" + (stopdateTime - startdateTime));
                        Console.WriteLine("\nPress any key to continue...... ");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 10:
                        Console.Clear();
                        Console.ReadLine();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Select only give options");
                        break;
                }
            }
        }
    }
}
