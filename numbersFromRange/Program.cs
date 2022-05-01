using System;
using System.Collections.Generic;
using System.Linq;

namespace numbersFromRange
{
    class Program
    {
        static void Main(string[] args)
        //Given an array of integers, write a query that returns list of numbers greater than 30 and less than 100.

        {
            List<int> Numbers = new List<int> { 30, 54, 3, 14, 25, 82, 1, 100, 23, 95 };
            var SelectedNumbers = Numbers.Where(x => x > 30).Where(x => x < 100);

            foreach (var s in SelectedNumbers)
            {
                Console.Write($"{s} "); // 54 82 95
            }
            

        }
    }
}
