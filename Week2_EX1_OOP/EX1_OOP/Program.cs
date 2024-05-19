using System;
using System.Text.RegularExpressions;
namespace EX1_OOP
{
    class Program
    {
        static List<Employee> empList = new List<Employee>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("===========Employee Management===========");
                Console.WriteLine("1, Add employee.");
                Console.WriteLine("2, Delete employee.");
                Console.WriteLine("3, Edit employee.");
                Console.WriteLine("4, Find employee have highest salary in part-time and full-time.");
                Console.WriteLine("5, Find employee by name.");
                Console.WriteLine("6, Exit.");
                int choice = checkInteger(1, 6, "Please enter your choice: ");
                switch (choice)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break; 
                        
                }
            }
        }

        public static void addEmployee()
        {
            try
            {
                string name = checkInputString("Input name of the employee: ");
                int paymentPerHour = checkInteger(15000, 55000, "Input payment this employee will have: ");
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

            }
        }

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