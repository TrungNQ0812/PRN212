using System;
using System.Text.RegularExpressions;
using System.Transactions;
namespace EX1_OOP
{
    class Program
    {
        static List<Employee> empList = new List<Employee>();
        static void Main(string[] args)
        {
            while (true)
            {
                // Display menu options to the user
                Console.WriteLine("===========Employee Management===========");
                Console.WriteLine("1, Add employee.");
                Console.WriteLine("2, Delete employee.");
                Console.WriteLine("3, Edit employee.");
                Console.WriteLine("4, Find employee have highest salary in part-time and full-time.");
                Console.WriteLine("5, Find employee by name.");
                Console.WriteLine("6, Exit.");

                // Get user choice with validation
                int choice = checkInteger(1, 6, "Please enter your choice: ");

                // Execute appropriate method based on user choice
                switch (choice)
                {
                    case 1:
                        addEmployee();
                        break;
                    case 2:
                        deleteEmployee();
                        break;
                    case 3:
                        editEmployee();
                        break;
                    case 4:
                        findTheHighestSalary();
                        break;
                    case 5:
                        searchByName("Enter name you want to search: ");
                        break;
                    case 6:
                        return; 
                        
                }
            }
        }

        // Add new employee
        public static void addEmployee()
        {
            try
            {
                string name = checkInputString("Input name of the employee: ");
                int paymentPerHour = checkInteger(15000, 55000, "Input payment this employee will have: ");

                // Ensure the employee doesn't already exist in the list
                foreach (Employee emp in empList)
                {
                    if (name.Equals(emp.getName()) && paymentPerHour.Equals(emp.getPaymentPerHours()))
                    {
                        Console.WriteLine("This employee has exist! Please add new employee!");
                        name = checkInputString("Input name of the employee: ");
                        paymentPerHour = checkInteger(15000, 55000, "Input payment this employee will have: ");
                    }
                }

                // Determine type of employee and add to list
                int employeeType = checkInteger(1, 2, "What type of employee: ");

                if (employeeType == 1)
                {
                    empList.Add(new FullTimeEmployee(name, paymentPerHour));
                }else if (employeeType == 2)
                {
                    Console.WriteLine("Enter the working hours: ");
                    int workingHours = int.Parse(Console.ReadLine());
                    empList.Add(new PartTimeEmployee(name, paymentPerHour, workingHours));
                }
                else
                {
                    Console.WriteLine("Employee's type is invalid.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot add employee successfully!");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to delete an existing employee
        public static void deleteEmployee()
        {
            try
            {
                string name = Console.ReadLine();
                foreach (Employee finder in empList)
                {
                    if (finder.getName().Equals(name))
                    {
                        empList.Remove(finder);
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
            }catch(Exception ex)
            {
                Console.WriteLine("Cannot find this employee!");
            }
        }

        // Method to edit an existing employee's details
        public static void editEmployee()
        {
            try
            {
                string name = checkInputString("Enter the name of the employee to edit: ");
                bool found = false; // Flag to check if employee is found

                foreach (Employee finder in empList)
                {
                    if (finder.getName().Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        finder.setName(checkInputString("Enter new name: "));
                        finder.setPaymentPerHours(checkInteger(15000, 55000, "Enter new payment per hour: "));
                        found = true; // Set flag to true if employee is found
                        Console.WriteLine("Employee information updated successfully.");
                        break; // Exit loop after updating employee info
                    }
                }

                if (!found)
                {
                    Console.WriteLine("Cannot find this employee!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot adjust information!");
                Console.WriteLine(ex.Message);
            }
        }

        // Method to find the employees with the highest salaries for full-time and part-time
        public static void findTheHighestSalary() 
        {
            Employee highestFullTime = null;
            Employee highestPartTime = null;

            // Iterate through the employee list to find the highest salary employees
            foreach (var employee in empList)
            {
                if (employee is FullTimeEmployee)
                {
                    if (highestFullTime == null || employee.calculateSalary() > highestFullTime.calculateSalary())
                    {
                        highestFullTime = employee;
                    }
                }
                else if (employee is PartTimeEmployee)
                {
                    if (highestPartTime == null || employee.calculateSalary() > highestPartTime.calculateSalary())
                    {
                        highestPartTime = employee;
                    }
                }
            }

            // Display the results
            if (highestFullTime != null)
            {
                Console.WriteLine($"The highest salary full-time employee is: {highestFullTime.getName()} with a salary of {highestFullTime.calculateSalary()}");
            }
            else
            {
                Console.WriteLine("Cannot find the highest salary full-time employee!");
            }

            if (highestPartTime != null)
            {
                Console.WriteLine($"The highest salary part-time employee is: {highestPartTime.getName()} with a salary of {highestPartTime.calculateSalary()}");
            }
            else
            {
                Console.WriteLine("Cannot find the highest salary part-time employee!");
            }
        }

        // Method to search for employees by name
        public static List<Employee> searchByName(string msg)
        {
            Console.WriteLine(msg);
            string searchName = Console.ReadLine();
            List<Employee> result = new List<Employee>();

            // Iterate through the employee list to find matches by name
            foreach (Employee finder in empList)
            {
                if (finder.getName().Contains(searchName, StringComparison.OrdinalIgnoreCase))
                {
                    result.Add(finder);
                }
            }

            // Display the results
            if (result.Count == 0)
            {
                Console.WriteLine("No employees found with that name.");
            }
            else
            {
                Console.WriteLine("Search Results:");
                foreach (var emp in result)
                {
                    Console.WriteLine(emp);
                }
            }

            return result;

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
                }catch (Exception e)
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
                }catch (Exception e)
                {
                    Console.WriteLine($"Invalid value, please input number in range {min} to {max}");
                }
            }
        }

    }
}