using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1026
{
    public class Employee
    {
        protected string name { get; set; }
        protected double monthlySalary { set; get; }
        public Employee(string name,double monthlySalary)
        {
            this.name = name;
            this.monthlySalary = monthlySalary;
        }
        public virtual double GetAnnualIncome(double x)
        {
            double salary = monthlySalary * 12 + x;
            return salary;
        }
    }
    public class Manager:Employee
    {
        public Manager(string name, double monthlySalary)
            : base(name, monthlySalary)
        { }
        public override double GetAnnualIncome(double x)
        {
            return base.GetAnnualIncome(x) * (1 + 0.15);
        }
    }
    class Ques1
    {
        static void Main()
        {
            Employee emp = new Employee("john", 5000);
            Console.WriteLine("Employee");
            Console.WriteLine(emp.GetAnnualIncome(500));

            Manager man = new Manager("Mary", 9000);
            Console.WriteLine("Manager");
            Console.WriteLine(man.GetAnnualIncome(800));
        }
    }
}
