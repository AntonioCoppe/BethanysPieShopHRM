using System;
using System.Text;

namespace BethanysPieShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bethany";
            string lastName = "Smith";

            //string noValueString = null;
            string s;

            s = firstName;

            //var username = "Bethany Smith";

            string fullName = firstName + " " + lastName;
            string employeeIdentification = string.Concat(firstName, lastName);

            string empID = firstName.ToLower() + lastName.ToLower();

            int length = empID.Length;

            if (fullName.Contains("Beth") || fullName.Contains("beth") )
            {
                Console.WriteLine("Bethany is in the name");
            } 
             string subString = fullName.Substring(1, 3);
             Console.WriteLine("Characther from index 1 to 3: " + subString);

             string nameUsingInterpolation = $"My name is {firstName} {lastName}";

            string greeting = $"Hello {firstName}";
            Console.WriteLine(greeting);

            string displayName = $"Welcome \n {firstName} \t {lastName}";
            Console.WriteLine(displayName);

            string invalidFilePath = "C:\\data\\employeekuist.xlsx";
            string marketingTagLine = "Bethany's pies are the best pies in the world";

            Console.WriteLine(marketingTagLine.Replace("pies", "cakes"));
            Console.WriteLine(invalidFilePath);

            Console.WriteLine("Are both names equal? " + firstName.Equals(lastName));
            Console.WriteLine("Are both names equal? " + (firstName == fullName));

            //String immutability
            string name = "Bethany";
            string anotherName = name;

            name += " Smith";

            Console.WriteLine(name);
            Console.WriteLine(anotherName);

            string lowerCaseName = name.ToLower();
            string indexes = string.Empty;

            for (int i = 0; i < 2500; i++)
            {
                indexes += i.ToString();
            }

            StringBuilder builder = new StringBuilder();
            builder.Append("Last name: ");
            builder.Append(lastName);
            builder.Append("First name: ");
            builder.Append(firstName);
            string result = builder.ToString();
            Console.WriteLine(result);

            //parsing strings
            string wage = Console.ReadLine();
            int wageValue;

            if(int.TryParse(wage, out wageValue))
            {
                Console.WriteLine("Wage value: " + wageValue);
            }
            else
            {
                Console.WriteLine("Invalid wage value");
            }
            
        }
    }
}