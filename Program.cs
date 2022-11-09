using System;

namespace BethanysPieShop
{
    class Program
    {
        static void Main(string[] args)
        {
           int monthlyWage = 2000;
           int months = 12;
           int bonus = 1000;

           int yearlyWage = CalculateYearlyWage(monthlyWage, months, bonus);
           Console.WriteLine($"Yearly wage(int): {yearlyWage}");

           double monthlyWageDouble = 2000;
           double monthsDouble = 12;
           double bonusDouble = 1000;

           double yearlyWageDouble = CalculateYearlyWage(monthlyWageDouble, monthsDouble, bonusDouble);
           Console.WriteLine($"Yearly wage(double): {yearlyWageDouble}");
        }
        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            if (numberOfMonthsWorked == 12)
            {
                return monthlyWage * (numberOfMonthsWorked + 1);
            }
            //Console.WriteLine($"Your yearly wage is {monthlyWage * numberOfMonthsWorked}");
            return monthlyWage * numberOfMonthsWorked;
        }
        // public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        // {
        //     //Console.WriteLine($"Your yearly wage is {monthlyWage * numberOfMonthsWorked}");
        //     return monthlyWage * numberOfMonthsWorked + bonus;
        // }
        private static void UsingExpressionBodiedSyntax()
        {
            int monthlyWage1 = 2000;
            int months1 = 12;
            int bonus;// notice: no initial value

            int YearlyWageForEmployee1 = CalculateYearlyWageWithOut(monthlyWage1, months1, out bonus);
            Console.WriteLine($"Yearly wage for employee 1(Bethany): {YearlyWageForEmployee1}");
        }
        // very concise way to write single line methods
        public static int CalculateYearlyWageExpressionBodied(int monthlyWage, int numberOfMonthsWorked) => monthlyWage * numberOfMonthsWorked;
        private static void UsingOutParameters()
        {
            int monthlyWage1 = 2000;
            int months1 = 12;
            int bonus;// notice: no initial value

            int YearlyWageForEmployee1 = CalculateYearlyWageWithOut(monthlyWage1, months1, out bonus);
            Console.WriteLine($"Yearly wage for employee 1(Bethany): {YearlyWageForEmployee1}");
            Console.WriteLine($"Bethany received a bomnus of {bonus}");
        }

        public static int CalculateYearlyWageWithOut(int monthlyWage, int numberOfMonthsWorked, out int bonus)
        {
            bonus = new Random().Next(1000);
            if (bonus <500){
                bonus *=2;
                Console.WriteLine("Bonus doubled!");
            }
            Console.WriteLine($"The yearly wage is {monthlyWage * numberOfMonthsWorked+bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked, int bonus)
        {
            if (monthlyWage < 2000){
                bonus*=2;
            }
            Console.WriteLine($"Your yearly wage is {monthlyWage * numberOfMonthsWorked + bonus}");
            Console.WriteLine($"The employee got a bonus of {bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            //Console.WriteLine($"Your yearly wage is {monthlyWage * numberOfMonthsWorked}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }

        private static void UsingParams()
        {
            int monthlyWage1 = 1000, monthlyWage2 = 2000, monthlyWage3 = 3000, monthlyWage4 = 4000;

            int average = CalculateAverageWage(monthlyWage1, monthlyWage2, monthlyWage3, monthlyWage4);
            Console.WriteLine($"The average wage is {average}");
        }
        //Optional parameter gives the possibility to omit parameters
        private static int CalculateAverageWage(int wage1, params int[] wages)
        {
            int total = 0;
            for (int i=0;i< wages.Length; i++){
                total += wages[i];
            }
            return total/ wages.Length;
        }

    }
}