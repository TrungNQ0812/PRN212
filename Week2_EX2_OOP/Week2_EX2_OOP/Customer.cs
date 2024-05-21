using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_EX2_OOP
{
    class Customer: Person
    {
        public int balance;

        public Customer() { }

        public Customer(string name, string address, int balance) : base(name,address)
        { 
            this.balance = balance;
        }

        public int getBalance() { return balance; }
        public void setBalance(int balance)
        {
            this.balance=balance;
        }

        public override void display()
        {
            Console.WriteLine($"Customer: {getName()}, Address: {getAddress()}, Balance: {balance}");
        }
    }
}
