using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Names = { "Kim", "John", "Lonnie", "Diana", "Patricia", "Derrick", "Tim", "Brian", "Shawn", "Tina", "Richard", "Nicole", "Paula", "Karen", "Stephen", "Jacob", "Sonya", "David", "JJ", "Crystal" };
            string[] Hometown = { "New York", "Detroit", "Dallas", "Phoenix", "Miami", "Los Angeles", "Seattle", "Kansas City", "Oklahoma City", "Atlanta", "Cleveland", "Houston", "Boston", "San Diego", "Chicago", "Green Bay", "Newark", "Virginia Beach", "Philadelphia", "Austin" };
            string[] Food = { "Pizza", "Burgers", "Pasta", "Chips", "Lasanga", "Turkey", "Macaroni & Cheese", "Ribs", "Salmon", "Ice Cream", "Cake", "Cereal", "Seafood", "Funnel Cake", "Pancakes", "Chili", "PB&J", "Brisket", "Snickers", "Nachos" };
            //second bool that will be used for while loop at the bottom
            bool answer = true;
            while (answer)
            {

                Console.WriteLine("Welcome to our C# class");
                //Console.WriteLine("Which student would you like to know more about: (enter a number between 1-20) ");
                //printing list to the screen
                foreach (string elements in Names)
                    //printing user number selection
                    Console.WriteLine(elements);
                //Console Clear prevents list from showing
                Console.Clear();
                Console.Write("Enter a number between 1-20 to learn more about a student: ");
                int number = 0;
                //while loop validates user input..if input is not a number or not within 1-20 range it will ask user for info again
                while (!int.TryParse(Console.ReadLine(), out number) || number < 1 || number > 20)
                {
                    Console.Write("Please enter a valid number: ");

                }

                Console.Clear();
                //prints the student name and students number after user makes number selection
                Console.WriteLine($"Student {number} is {Names[number - 1]}");

                Console.WriteLine($"Would you like to know their hometown or favorite food (Enter hometown or food:)");
                string likeToKnow = (Console.ReadLine().ToLower());
                if (likeToKnow == "hometown")
                {
                    //if user enters hometown prints student name and their corresponding hometown
                    Console.WriteLine(Hometown[number - 1]);
                }
                else if (likeToKnow == "food")
                    //if user enters food prints student name and their corresponding food
                    Console.WriteLine(Food[number - 1]);
                else
                {
                    //if user enters anything but hometown or food they get this message
                    Console.WriteLine("Invalid option");
                }

                //setting the bool value from above to the new method continue
                answer = Continue();
            }


        }

        private static bool Continue()
        {
            Console.WriteLine("Would you like to know more: ");
            string input = Console.ReadLine().ToLower();

            while (true)
            {
                if (input == "y")
                {
                    return true;
                }
                else if (input == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid option: Please enter y to continue or n to quit: ");
                    input = Console.ReadLine().ToLower();
                }
            }

        }
    }
}
