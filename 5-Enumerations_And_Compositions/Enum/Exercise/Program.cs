using Exercise.Class;
using Exercise.ENUMS;
using System;

namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name : ");
            string departement = Console.ReadLine();
            Console.Write("Entre worker data\n");
            Console.Write("Name :");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/Pleno/Senior) : ");
            string level = Console.ReadLine();
            WorkerLevel levelWork = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), level);
            Console.Write("BaseSalary : ");
            double baseSalary = Convert.ToDouble(Console.ReadLine());
            Worker worke = new Worker(name: name, workLevel: levelWork, baseSalary: baseSalary, departament: departement);
            
            Console.Write("How many contracts to this worker");
            int amountContract = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < amountContract; i++)
            {
                Console.Write("Enter #" + (i+1) + " contract data :\n");
                Console.Write("Date(DD/MM/YYYY) : ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value : ");
                double value = Convert.ToDouble(Console.ReadLine());
                Console.Write("Duration(hours) : ");
                int hours = Convert.ToInt32(Console.ReadLine());
                
                HourContract hourContract = new HourContract(date: date, valueHour: value, hours: hours);
                
                worke.AddContract(hourContract);
            }

            Console.Write("Enter month and to calculate income (MM/YYYY) : ");
            DateTime dateCalculaterIncome = DateTime.Parse(Console.ReadLine());
            Console.Write("Name :" + worke.Name + "\nDepartment: " + worke.Departament.Name + "\nIncome for " + dateCalculaterIncome.Month + "/" + dateCalculaterIncome.Year + ": " + worke.Income(year: dateCalculaterIncome.Year, mounth: dateCalculaterIncome.Month).ToString("0.00"));
        }
    }
}
