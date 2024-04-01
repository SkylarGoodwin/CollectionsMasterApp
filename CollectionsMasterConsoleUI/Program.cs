using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //Done: Create an integer Array of size 50
            int[] nums = new int[50];

            //Done: Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(nums);

            //Done: Print the first number of the array
            Console.WriteLine(nums[0]);
            //Done: Print the last number of the array            
            Console.WriteLine(nums[^1]);
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(nums);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */
            Array.Reverse(nums);
            NumberPrinter(nums);

            ReverseArray(nums);

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(nums);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Array.Sort(nums);
            Console.WriteLine("Sorted numbers:");
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            
            var numList = new List<int>();
            //TODO: Print the capacity of the list to the console
            
            Console.WriteLine(numList.Count);
            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            
            
            Populater(numList);
            //TODO: Print the new capacity
            Console.WriteLine(numList.Count);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            int userNumber;
            bool isANumner;

            //Remember: What if the user types "abc" accident your app should handle that!
            do
            {
                Console.WriteLine("What number will you search for in the number list?");
                isANumner = int.TryParse(Console.ReadLine(), out userNumber);
            }while (isANumner == false);

            NumberChecker(numList, userNumber);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(numList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            OddKiller(numList); 
            Console.WriteLine("Evens Only!!");
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            numList.Sort();
            NumberPrinter(numList);
            Console.WriteLine("Sorted Evens!!");
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            var numArray = numList.ToArray();

            //TODO: Clear the list
            numList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            for (int i =0; i < numbers.Length; i++)
            {
                if(numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
            NumberPrinter(numbers);
        }

        private static void OddKiller(List<int> numberList)
        {
            for (var i = numberList.Count - 1; i >= 0; i--)
            {
                if (numberList[i] % 2 != 0)

                    numberList.Remove(numberList[i]);
            }
            NumberPrinter(numberList);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
           if(numberList.Contains(searchNumber))
            {
                Console.WriteLine($" Yes, the list contains {searchNumber}.");
            }
            else Console.WriteLine($" No, {searchNumber} is not withen the list.");
        }

        private static void Populater(List<int> numberList)
        {
            while (numberList.Count < 50)
            { 
            Random rng = new Random();
             numberList.Add ( rng.Next(0, 50));
            }

        }

        private static void Populater(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Random rng = new Random();
                numbers[i] = rng.Next(0, 50);
            }


        }        

        private static void ReverseArray(int[] array)
        {
            Array.Reverse(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerableT
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
