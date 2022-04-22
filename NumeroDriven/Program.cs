using System;

namespace NumeroDriven
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(NumeroDriven(1220703123));
        }

        public static string NumeroDriven(int numero)
        {
            for (int i = 0; i < 1000; i++)
            {
                int num = (int) Math.Pow(5,i) - 2;
                Console.WriteLine($"valor de i= {i} num= {num}");
                if (num == numero)
                {
                    return ("Numero Driven");
                }
            }
            return ("Não é desse tipo");
        }

    }
}
