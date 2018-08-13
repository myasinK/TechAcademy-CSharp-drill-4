using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousIncomeComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("====================================");

            Console.WriteLine("Person 1");
            Console.WriteLine("Enter hourly rate: ");
            double wageRate_1 = Convert.ToDouble( Console.ReadLine() );
            Console.WriteLine("Enter worked hours/week : ");
            double hrsPerWeek_1 = Convert.ToDouble(Console.ReadLine());
            double income_1 = wageRate_1 * hrsPerWeek_1 * 52; // assuming person 1 worked 52 hours in a year

            Console.WriteLine("Person 2");
            Console.WriteLine("Enter hourly rate: ");
            double wageRate_2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter worked hours/week : ");
            double hrsPerWeek_2 = Convert.ToDouble(Console.ReadLine());
            double income_2 = wageRate_2 * hrsPerWeek_2 * 52; // assuming person 1 worked 52 hours in a year

            Console.WriteLine("Annual salary of Person 1: \n" + income_1);
            Console.WriteLine("Annual salary of Person 2: \n" + income_2);


            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(income_1 > income_2);
            Console.ReadLine();
        }
    }
}
