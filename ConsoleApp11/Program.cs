using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instance
            Employee employee = new Employee();
            employee.Name = "Tural";
            employee.Surname = "Taghiyev";
            employee.Position = "Offshore Data Processor";
            employee.DailySalary = 500;
            //Console.WriteLine($"Name - {employee.Name}");
            //Console.WriteLine($"Surname - {employee.Surname}");
            //Console.WriteLine($"Position - {employee.Position}");
            //Console.WriteLine($"DailySalary - {employee.DailySalary}");
            employee.MonthlySalaryCalculator(employee.DailySalary);
        }
    }
}
