using System;
using System.Linq;
using System.Collections.Generic;

namespace removeDuplicateCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            
        // The Simple way of Implementation:

            Console.Write("Enter a String : ");
            string inputString = Console.ReadLine();
            string resultString = string.Empty;

            for (int i = 0; i < inputString.Length; i++)
            {
                if (!resultString.Contains(inputString[i]))
                {
                    resultString += inputString[i];
                }
            }
            Console.WriteLine(resultString);
            Console.WriteLine("");
            Console.ReadKey();


        // Using HashSet to Remove Duplicate Characters:

            Console.Write("Enter a String : ");
            string inputString1 = Console.ReadLine();
            string resultString1 = string.Empty;

            var unique = new HashSet<char>(inputString1);
            foreach (char c in unique)
            {
                resultString1 += c;
            }
            Console.WriteLine("After Removing Duplicates : " + resultString1);
            Console.WriteLine("");


            Console.ReadKey(); 

        // Using LINQ to Remove Duplicate Characters From a String:

            Console.Write("Enter a String : ");
            string inputString2 = Console.ReadLine();
            
            var uniqueCharArray = inputString2.ToCharArray().Distinct().ToArray();
            var resultString2 = new string(uniqueCharArray);
            Console.WriteLine("After Removing Duplicates : " + resultString2);
            Console.WriteLine("");

            Console.ReadKey();


        }
    }
}
