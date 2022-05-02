using System;

namespace soroban
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int num1=0;
            int num2=0;
            for (int i = 0; i < 6; i++)
            {
                num1 = randNum.Next(10,199);
                num2 = randNum.Next(10,199);

                System.Console.WriteLine($"{num1}\t+ {num2} =\t" + (num1+num2));
            }
                
        }
    }
}
