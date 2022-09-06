using System;
using Course.Entities;
using Course.Entities.Enums;
using Course;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string name_dept= Console.ReadLine();
            Console.WriteLine("Enter the Worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level: [Junior / Midlevel / Senior]: "); 
            WorkLevel level = (WorkLevel)Enum.Parse(typeof(WorkLevel),(Console.ReadLine()));   
            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine());
            Department dept = new Department(name_dept);
            Worker worker = new Worker(name, level, salary, dept);

            Console.Write("How Many Contracts? : ");
            int n = int.Parse(Console.ReadLine());
           
         
                for (int i = 0; i < n; i++)
            {

                Console.WriteLine("Enter de Contract #" + i+1 + ": ");
                Console.Write("Date(DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine());
                Console.Write("Duration(hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contrato = new HourContract(data, valueperhour, duration);
                worker.AddContract(contrato);

            }

            Console.WriteLine("Enter the month and year to calculate the income(MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3,4));

            Console.WriteLine("---------------------");
            double ganho = worker.Income(month, year);
            Console.WriteLine(worker);
            Console.WriteLine("Ganho Total: R$" + ganho.ToString("F2"));

        }
    }
}
