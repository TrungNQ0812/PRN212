using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_OOP
{
    public class PartTimeEmployee : Employee
    {
        private int workingHours;

        public PartTimeEmployee(string name, int paymentPerHours, int workingHours) : base(name, paymentPerHours) 
        {
            this.workingHours = workingHours;
        }

        public override int calculateSalary()
        {
            return workingHours * getPaymentPerHours();
        }

        public override string ToString()
        {
            return $"Part-Time Employee: {getName()}, Payment Per Hour: {getPaymentPerHours()}" +
                $", Working hour: {workingHours}, Salary: {calculateSalary()} ";
        }
    }
}
