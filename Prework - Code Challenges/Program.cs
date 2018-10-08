using System;

namespace Prework___Code_Challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            First();
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

    }
}