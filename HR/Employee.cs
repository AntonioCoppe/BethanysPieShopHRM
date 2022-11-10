using System;

namespace BethanysPieShopHRM.HR
{
    public class Employee
    {
        private string? firstName;
        private string? lastName;

        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;

        public static double taxRate = 0.2;

        public string FirstName
        {
            get { 
                if (firstName == null)
                {
                    throw new ArgumentNullException(nameof(firstName));
                }
                return firstName; }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get {
                if (lastName == null)
                {
                    throw new ArgumentNullException(nameof(lastName));
                }
                 return lastName; }
            set
            {
                lastName = value;
            }
        }

        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                hourlyRate = value;
            }
        }

        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            set
            {
                numberOfHoursWorked = value;
            }
        }

        public double Wage
        {
            get { return wage; }
            set
            {
                wage = value;
            }
        }

        public Employee(string first, string last, double rate)
        {
            FirstName = first;
            LastName = last;
            HourlyRate = rate;
        }

        public int PerformWork(int hours)
        {
            NumberOfHoursWorked += hours;
            return NumberOfHoursWorked;
        }

        public double ReceiveWage(out int hoursWorked)
        {
            double wageBeforeTax = HourlyRate * NumberOfHoursWorked;
            double tax = wageBeforeTax * taxRate;
            Wage = wageBeforeTax - tax;
            
            Console.WriteLine($"The wage for {NumberOfHoursWorked} hours of work is {Wage}.");

            NumberOfHoursWorked = 0;
            hoursWorked = NumberOfHoursWorked;

            return Wage;
        }
    }
}
