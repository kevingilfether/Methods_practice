using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //I can use a method in here.

            Console.WriteLine("Please enter a name");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter the best food ever!");
            string food = Console.ReadLine();

            FavoriteFood(name, food);

            RetirementCalculator(900);
            
            double[] wages = new double[2];
            wages[0] = WageCalculator(160, 20);
            wages[1] = WageCalculator(160, 40);

            foreach (double wage in wages)
            {
                Console.WriteLine(wage);
            }
            
        }
        //Methods are reuasable bits of code 
        //Methods do one thing and do them really well
        //Methods get written out here, outside of main, 
        //but on the same level (and typically after)
        //Methods only return one value
        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;

            return sum;
        }
        public static void FavoriteFood(string name, string favoriteFood)
        {
            Console.WriteLine(name + "'s favorite food is " + favoriteFood);
        }
        public static void RetirementCalculator(int userAge)
        {
            //using math method to find one line solution,
            // finding greater of two ints
            int yearsToGo = Math.Max(0, 65 - userAge);
            Console.WriteLine("The user will retire in {0} years", yearsToGo);
        }
        public static double WageCalculator(double hoursWorked, double hourlyWage)
        {
            double monthlyWage = hoursWorked * hourlyWage;
            return monthlyWage;
        }


    }
}
