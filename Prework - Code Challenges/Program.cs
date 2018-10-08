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
            Console.WriteLine("Hello again");
            int[] nums = new int[5];
            int picked = 0;
            for(int i = 0; i < nums.Length; i++)
            {
                Console.Write("Pick a number between 1 and 10:");
                string numInput = Console.ReadLine();
                if(Int32.TryParse(numInput, out picked) && int.Parse(numInput) > 0 && int.Parse(numInput) <= 10)
                {
                    nums[i] = int.Parse(numInput);
                }
                else
                {
                    Console.Write("That won't work. Try again.\n");
                    i = i - 1;
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i]);
            }
        }
        
    }
}
