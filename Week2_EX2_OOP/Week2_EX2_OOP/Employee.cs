using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_EX2_OOP
{
    class Employee : Person
    {
        private int salary;

        public Employee()
        {
        }

        public Employee(string name, string address, int salary): base(name, address) 
        {
            this.salary = salary;
        }

        public void setSalary(int salary)
        {
            this.salary = salary;
        }

        public int getSalary() 
        { 
            return salary;
        }

        public override void display()
        {
            Console.WriteLine($"Employee: {getName()}, Address: {getAddress()}, Salary: {salary}");
        }
    }
}
