using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1_OOP
{
    public abstract class Employee : IEmployee
    {
        private string name;
        private int paymentPerHour;


        public Employee()
        {
        }

        public Employee(String name, int paymentPerHour)
        {
            this.name = name;
            this.paymentPerHour = paymentPerHour;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public void setPaymentPerHours(int paymentPerHours)
        {
            this.paymentPerHour = paymentPerHours;
        }

        public int getPaymentPerHours()
        {
            return paymentPerHour;
        }

        public abstract int calculateSalary();

        public override string ToString()
        {
            return $"Name: {name}, Payment per hour: {paymentPerHour}";
        }
    }
}
