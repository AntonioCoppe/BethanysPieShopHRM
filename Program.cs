using System;
using System.Collections.Generic;
using BethanysPieShopHRM.HR;
using BethanysPieShopHRM.Accounting;

namespace BethanysPieShopHRM.HR
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.ForegroundColor = ConsoleColor.Green;
            // Console.WriteLine("***********************************");
            // Console.WriteLine("* Bethany's Pie Shop Employee App *");
            // Console.WriteLine("***********************************");
            // Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Creating a lot of Employees");
            Console.WriteLine("***************************\n");
            List <Employee> employees = new List<Employee>();
            for (int i = 0; i < 1000000; i++)
            {
               Employee randomEmployee = new Employee(Guid.NewGuid().ToString(),Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), new DateTime(1979,1,16), EmployeeType.StoreManager,null);
                employees.Add(Employee.randomEmployee);
            }
            employees.Clear();
            employees = null;
            //Calling the Garbage Collector
            GC.Collect();

            Console.ReadLine();
        //     string? userSelection;

        //     do
        //     {
        //         Console.ForegroundColor = ConsoleColor.Blue;

        //         Console.WriteLine("********************");
        //         Console.WriteLine("* Select an action *");
        //         Console.WriteLine("********************");
        //         Console.ForegroundColor = ConsoleColor.White;

        //         Console.WriteLine("1: Register employee");
        //         Console.WriteLine("2: Register work hours for employee");
        //         Console.WriteLine("3: Pay employee");
        //         Console.WriteLine("9: Quit application");

        //         userSelection = Console.ReadLine();

        //         switch (userSelection)
        //         {
        //             case "1": RegisterEmployee();
        //                 break;
        //             case "2": RegisterWork();
        //                 break;
        //             case "3": PayEmployee();
        //                 break;
        //             case "9": break;
        //             default:
        //                 Console.WriteLine("Invalid selection. Please try again.");
        //                 break;
        //         }
        //     }
        //     while (userSelection != "9");

        //     Console.WriteLine("Thanks for using the application");
        //     Console.Read();

        // }
        // private static void RegisterEmployee()
        // {
        //     Console.WriteLine("Creating an employee");
        //     Console.Write("Enter the first name: ");
        //     string? firstName = Console.ReadLine();
            
        //     Console.Write("Enter the last name: ");
        //     string? lastName = Console.ReadLine();

        //     Console.Write("Enter the hourly rate: ");
        //     string? hourlyRate = Console.ReadLine();
        //     double rate = double.Parse(hourlyRate);//we will assume here that input is in the correct format

        //     Employee employee = new Employee(firstName, lastName, rate);
        //     employees.Add(employee);
            
        //     Console.WriteLine("Employee created!\n\n");
        // }

        // private static void RegisterWork()
        // {
        //     Console.WriteLine("Select an employee");

        //     for (int i = 1; i <= employees.Count; i++)
        //     {
        //         Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
        //     }

        //     int selection = int.Parse(Console.ReadLine());//we will assume here that a valid ID is selected

        //     Console.Write("Enter the number of hours worked: ");
        //     int hours = int.Parse(Console.ReadLine());//we will assume here that a valid amount was entered

        //     Employee selectedEmployee = employees[selection - 1];
        //     int numberOfHoursWorked = selectedEmployee.PerformWork(hours);
        //     Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has now worked {numberOfHoursWorked} hours in total.\n\n");
        // }

        // private static void PayEmployee()
        // {
        //     Console.WriteLine("Select an employee");

        //     for (int i = 1; i <= employees.Count; i++)
        //     {
        //         Console.WriteLine($"{i}. {employees[i - 1].FirstName} {employees[i - 1].LastName}");
        //     }

        //     var selection = int.Parse(Console.ReadLine());//we will assume here that a valid ID is selected

        //     Employee selectedEmployee = employees[selection - 1];
        //     int hoursWorked;
        //     double receivedWage = selectedEmployee.ReceiveWage(out hoursWorked);
            
        //     Console.WriteLine($"{selectedEmployee.FirstName} {selectedEmployee.LastName} has received a wage of {receivedWage}. The hours worked is reset to {hoursWorked}.\n\n");
        }
    }
}
