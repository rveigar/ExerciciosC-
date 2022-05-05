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
            int num3=0;
            for (int i = 0; i < 20; i++)
            {
                num1 = randNum.Next(1,100);
                num2 = randNum.Next(1,100);
                num3 = randNum.Next(1,100);

                System.Console.WriteLine($"{num1}\t+\t{num2}\t+\t{num3} \t =  " + (num1+num2+num3));
            }
                
        }
    }
}
