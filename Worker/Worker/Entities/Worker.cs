using System;
using System.Collections.Generic;
using System.Text;
using Course.Entities.Enums;


namespace Course.Entities
{
    class Worker
    {
        public String Name { get; set; }

        public WorkLevel Level { get; set; }

        public double BaseSalary { get; set; }

        public Department Department {get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;

            Console.WriteLine(department.ToString());
        }



        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Income(int month,int year)
        {
            double sum = BaseSalary;

            foreach (HourContract contrato in Contracts)
            {
                if (contrato.Date.Year == year && contrato.Date.Month == month ) {

                    sum += contrato.totalValue();                         
                }
            }
            return sum;
        }

        public override string ToString()
        {
            return "Nome: " + Name + "\n" +
                    "Work Level: " + Level + "\n" +
                    "Base Salary: " + BaseSalary.ToString("F2") + "\n" +
                    "Department: " + Department.Name;
        
        }

    }
}
