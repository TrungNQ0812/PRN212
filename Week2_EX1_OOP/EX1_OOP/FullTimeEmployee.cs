using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EX1_OOP
{
    public class FullTimeEmployee : Employee
    {
        public FullTimeEmployee()
        {
           
        }

        public FullTimeEmployee(string name, int PaymentPerHour) : base(name, PaymentPerHour)
        {

        }

        public override int calculateSalary()
        {
            return 8 * getPaymentPerHours();
        }

        public override string ToString()
        {
            return $"Full-Time Employee: {getName()}" +
                $", Payment Per Hour: {getPaymentPerHours()}, Salary: {calculateSalary()}";
        }
    }
}
