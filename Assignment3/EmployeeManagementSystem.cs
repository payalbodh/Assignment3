using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public interface IPrintable
    {
        void DisplayDetails();
    }
    public abstract class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }
        public float GrossSalary { get; set; }

        public abstract float CalculateSalary();

    }
    public class Manager : Employee, IPrintable
    {
        public override float CalculateSalary()
        {
            float PetrolAllowance = 0.08f * Salary;
            float FoodAllowance = 0.13f * Salary;
            float OtherAllowance = 0.03f * Salary;
            GrossSalary = PetrolAllowance + FoodAllowance + OtherAllowance + Salary;
            return GrossSalary;
        }
        public void DisplayDetails()
        {
            var NetSalary = CalculateSalary();
            Console.WriteLine("Salary of Employee:" + NetSalary);
        }
    }
    public class MarketingExecutive : Employee, IPrintable
    {
        public float Kilometer { get; set; }
        public override float CalculateSalary()
        {
            float TourAllowance = 5 * Kilometer;
            GrossSalary = TourAllowance + 1000 + Salary;
            return GrossSalary;
        }
        public void DisplayDetails()
        {
            var NetSalary = CalculateSalary();
            Console.WriteLine("Salary of Employee:" + NetSalary);
        }

    }
}
