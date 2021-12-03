using System;

namespace ConsoleApp11
{
    internal class Employee
    {
        public string Name;
        public string Surname;
        public string Position;
        public int DailySalary;
        public void MonthlySalaryCalculator(int DailySalary)

        {
            int MonthlySalary = DailySalary * 30;
            Console.WriteLine($"MonthlySalary - {MonthlySalary}");
        }
    }
}
