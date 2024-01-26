using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7 };

            int middleElements = list.Count / 2;

            if (list.Count / 2 == 0)
            {
                Console.WriteLine($"Middle elements are {list[middleElements - 1]} and {list[middleElements]}");
            }
            else
            {
                Console.WriteLine($"Middle element is {list[middleElements]}");
            }


            // Task 2
            List<int> List = new List<int> { 3, 56, 78, 55, 4, 97 };

            int largestNumber = List[0];
            foreach (int i in List )
            {
                if (i > largestNumber)
                {
                    largestNumber = i;
                }
            }
            Console.WriteLine($"Largest number in the list is {largestNumber}");
        }
    }
}
