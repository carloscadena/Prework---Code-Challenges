using System;

namespace Prework___Code_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            First();
            Second();
            int[] perfect = new int[3] { 1, 2, 3 };
            int[] imperfect = new int[3] { 2, 3, 4 };
            Third(perfect);
            Third(imperfect);
            int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
            Four(myArray);

        }

        public static void First()
        {
            int[] nums = new int[5];
            int picked = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("Pick a number between 1 and 10:");
                string numInput = Console.ReadLine();
                if (Int32.TryParse(numInput, out picked) && int.Parse(numInput) > 0 && int.Parse(numInput) <= 10)
                {
                    nums[i] = int.Parse(numInput);
                }
                else
                {
                    Console.Write("That won't work. Try again.\n");
                    i = i - 1;
                }
            }
            Console.WriteLine($"Your list is [{nums[0]}, {nums[1]}, {nums[2]}, {nums[3]}, {nums[4]}]");
            Console.WriteLine("Please pick one of the numbers from your list: ");
            int newInput = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == newInput)
                {
                    counter += 1;
                }
            }
            Console.WriteLine($"The score for this number is {newInput * counter}");
        }

        public static void Second()
        {
            Console.Write("Input a year and I will tell you if it's a leap year: ");
            int year = int.Parse(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else if (year % 100 == 0 && !(year % 400 == 0))
            {
                Console.WriteLine($"{year} is NOT a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"{year} is a leap year");
            }
            else
            {
                Console.WriteLine($"{year} is NOT a leap year");
            }

        }
        public static void Third(int[] numList)
        {
            int added = 0;
            int multiplied = 1;
            Console.WriteLine("\nIs this list a perfect sequence?");
            for (int i = 0; i < numList.Length; i++)
            {
                Console.Write($"{numList[i]} ");
                added += numList[i];
                multiplied *= numList[i];
            }
            if (added == multiplied)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

        }
        public static void Four(int[,] numList)
        {
            Console.WriteLine("My Array: { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } }");
            int[] rows = new int[numList.GetLength(0)];
            for (int i = 0; i < numList.GetLength(0); i++)
            {
                for (int j = 0; j < numList.GetLength(1); j++)
                {
                    rows[i] += numList[i, j];
                }
            }
            Console.WriteLine($"Sum of each row: {string.Join(", ", rows)}");

        }

    }
}