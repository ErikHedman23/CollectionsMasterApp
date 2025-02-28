﻿using System;
using System.Collections.Generic;
using System.Globalization;

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
            //TODO: Create an integer Array of size 50
            var randomNumber = new int[50];
            Populater(randomNumber);
            
            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50


            //TODO: Print the first number of the array
            Console.WriteLine($"The first index in the array 'randomNumber' is {randomNumber[0]}");
            //TODO: Print the last number of the array            
            Console.WriteLine($"The Last index int the array 'randomNumber' is {randomNumber[randomNumber.Length - 1]}");
            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(randomNumber);
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            ReverseArray(randomNumber);

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            ThreeKiller(randomNumber);

            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");
            ArraySorter(randomNumber);
            

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List
            var randomList = new List<int>();

            //TODO: Print the capacity of the list to the console
           Console.WriteLine("Capacity: " + randomList.Capacity);

            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this
            
            Populater(randomList);

            //TODO: Print the new capacity
            Console.WriteLine("Capacity: " + randomList.Capacity);

            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            
            Console.WriteLine("What number will you search for in the number list?");
            var userInput = Console.ReadLine();
            var isInt = int.TryParse(userInput, out int userNumber);
            

            while (!isInt)
               
            {
                Console.WriteLine("What number will you search for in the number list?  You did not enter a number...");
                 userInput = Console.ReadLine();
                 isInt = int.TryParse(userInput, out userNumber);
            }
                NumberChecker(randomList, userNumber);
            
            
            
                 
                
            
            
            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            NumberPrinter(randomList);
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            OddKiller(randomList);
            
            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");
            randomList.Sort();
            OddKiller(randomList);
            
            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable
            randomList.Clear();

            //TODO: Clear the list
            

            #endregion
        }
        public static void ArraySorter(int[] numbers)
        {
            Array.Sort(numbers);
            NumberPrinter(numbers);
        }

        private static void ThreeKiller(int[] numbers)
        {
           for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0)
                {
                    numbers[i] = 0;
                }
            }
                NumberPrinter(numbers);
            
        }

        private static void OddKiller(List<int> numberList)
        {
            var evens = new List<int>();
            for (int i = 0; i < 50; i++)
            {
                if (numberList[i] % 2 == 0)
                {
                    evens.Add(numberList[i]);
                    
                }
            }
            
            NumberPrinter(evens);
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
             
            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine($"We found {searchNumber}");
            }
            else
            {
                Console.WriteLine("We did not find that number");
            }

            
            


        }

        private static void Populater(List<int> numberList)
        {
            Random rng = new Random();
            for(int i = 0; i < 50; i++)
            {
                numberList.Add( rng.Next(1, 50));
            }
            NumberPrinter(numberList);
        }

        private static void Populater(int[] numbers)
        {
            Random rng = new Random();
            
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 50);
            }
            
        }        

        private static void ReverseArray(int[] array)
        {

            Array.Reverse(array);
            NumberPrinter(array);
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
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
