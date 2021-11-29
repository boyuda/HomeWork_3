using System;
using System.Linq;

namespace Task_3
{
    class Program
    {
        //Drop args
        static void Main(string[] args)
        {
            var total = 0;

            Console.WriteLine("Please enter number of elements in a numeric array: ");
            var input = int.Parse(Console.ReadLine());

            var numericArray = new int[input];

            //Taking input then converting and adding to an array
            Console.WriteLine($"Please enter {numericArray.Length} elements one by one: ");
            for (int i = 0; i < input; i++)
            {
                //typo, should be elementOfArray (single n)
                var elemenntOfArray = Convert.ToInt32(Console.ReadLine());
                numericArray[i] = elemenntOfArray;
            }

            Console.WriteLine("Array with elements: [{0}]", string.Join(",", numericArray));

            //Finding lowest and Largest numbers positions
            var lowestNumber = Array.IndexOf(numericArray, numericArray.Min());
            var largestNumber = Array.LastIndexOf(numericArray, numericArray.Max());

            //Adding conditional statements to count the sum of the elements
            if (lowestNumber < largestNumber)
            {
                for (int i = lowestNumber; i <= largestNumber; i++)
                {
                    total += numericArray[i];
                }
            }
            else if (lowestNumber > largestNumber)
            {
                for (int i = lowestNumber; i >= largestNumber; i--)
                {
                    total += numericArray[i];
                }
            }
            else if (numericArray.Length == 2)
            {
                total = numericArray[lowestNumber] + numericArray[largestNumber];
            }

            Console.WriteLine("The sum of the required elements = " + total);
        }
    }
}
