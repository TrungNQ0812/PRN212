using System;
using System.ComponentModel.Design;

namespace Week2_EX2_OOP
{
    class Program()
    {
        static List<Customer> customers = new List<Customer>();
        static List<Employee> employees = new List<Employee>();


        public static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("===================Menu===================");
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Add Customer");
                Console.WriteLine("3. Display Employees");
                Console.WriteLine("4. Display Customers");
                Console.WriteLine("5. Find Employee with highest salary");
                Console.WriteLine("6. Find Customer with lowest balance");
                Console.WriteLine("7. Find Employee by name");
                Console.WriteLine("8. Exit");

                // Get user choice with validation
                int choice = checkInteger(1, 8, "Please enter your choice: ");

                // Execute appropriate method based on user choice
                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        break;
                    case 2:
                        AddCustomer();
                        break;
                    case 3:
                        DisplayEmployees();
                        break;
                    case 4:
                        DisplayCustomers();
                        break;
                    case 5:
                        FindEmployeeWithHighestSalary();
                        break;
                    case 6:
                        FindCustomerWithLowestBalance();
                        break;
                    case 7:
                        FindEmployeeByName();
                        break;
                    case 8:
                        return;

                }
            }
        }

        // Method to add an employee
        static void AddEmployee()
        {
            try
            {
                string name = checkInputString("Enter name: ");
                string address = checkInputString("Enter address: ");
                int salary = checkInteger(0, int.MaxValue, "Enter salary: ");
                employees.Add(new Employee(name, address, salary));
                Console.WriteLine("Employee added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding employee: " + ex.Message);
            }
        }

        // Method to add a customer
        static void AddCustomer()
        {
            try
            {
                string name = checkInputString("Enter name: ");
                string address = checkInputString("Enter address: ");
                int balance = checkInteger(0, int.MaxValue, "Enter balance: ");
                customers.Add(new Customer(name, address, balance));
                Console.WriteLine("Customer added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding customer: " + ex.Message);
            }
        }

        // Method to display all employees
        static void DisplayEmployees()
        {
            foreach (var emp in employees)
            {
                emp.display();
            }
        }

        // Method to display all customers
        static void DisplayCustomers()
        {
            foreach (var cust in customers)
            {
                cust.display();
            }
        }

        // Method to find employee with highest salary
        static void FindEmployeeWithHighestSalary()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees available.");
                return;
            }

            var highestSalaryEmployee = employees.OrderByDescending(emp => emp.getSalary()).First();
            Console.WriteLine("Employee with the highest salary:");
            highestSalaryEmployee.display();
        }

        // Method to find customer with lowest balance
        static void FindCustomerWithLowestBalance()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customers available.");
                return;
            }

            var lowestBalanceCustomer = customers.OrderBy(cust => cust.getBalance()).First();
            Console.WriteLine("Customer with the lowest balance:");
            lowestBalanceCustomer.display();
        }

        // Method to find employee by name
        static void FindEmployeeByName()
        {
            string name = checkInputString("Enter name to search: ");
            var matchingEmployees = employees.Where(emp => emp.getName().Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (matchingEmployees.Count == 0)
            {
                Console.WriteLine("No employees found with that name.");
            }
            else
            {
                Console.WriteLine("Employees found:");
                foreach (var emp in matchingEmployees)
                {
                    emp.display();
                }
            }
        }

        // Method to check and get a valid string input
        public static string checkInputString(string msg)
        {
            string input;
            while (true)
            {
                Console.WriteLine(msg);
                try
                {
                    input = Console.ReadLine();
                    if (input.Trim().Length == 0)
                    {
                        throw new Exception();
                    }
                    return input;
                }
                catch (Exception e)
                {

                }
            }
        }

        // Method to check and get a valid integer input within a specified range
        public static int checkInteger(int min, int max, string msg)
        {
            int input;
            while (true)
            {
                Console.WriteLine(msg);
                try
                {
                    input = int.Parse(Console.ReadLine());
                    if (input < min || input > max)
                    {
                        throw new Exception();
                    }
                    return input;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Invalid value, please input number in range {min} to {max}");
                }
            }
        }
    }
}