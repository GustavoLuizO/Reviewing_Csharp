using Exercise.ENUMS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Class
{
    public class Worker
    {
        public string Name { get; set; }
        public WorkerLevel WorkLevel { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public List<HourContract> Contract { get; set; } = new List<HourContract>(); 
        
        public Worker(string name, WorkerLevel workLevel, double baseSalary, string departament)
        {
            Name = name;
            WorkLevel = workLevel;
            BaseSalary = baseSalary;
            Departament = new Departament(departament);
        }

        public void AddContract(HourContract contract)
        {
            Contract.Add(contract);
        }
        
        public void RemoveContract(HourContract contract)
        {
            Contract.Remove(contract);
        }
        
        public double Income(int year, int mounth)
        {
            double salary = 0;
            foreach (var item in Contract)
            {
                if (item.Date.Year == year && item.Date.Month == mounth)
                {
                    salary += item.TotalValue();
                }
            }

            return salary + BaseSalary; 
        }
    }
}
