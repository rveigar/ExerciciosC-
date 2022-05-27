using System;

namespace fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("digite um número inteiro positivo para calcular o fatorial: ");
            
            var n = int.Parse( Console.ReadLine());
            var res = fatorial(n);
            System.Console.WriteLine(res);
        }

        static int fatorial(int n)
        {
            if (n == 1)
            {
                return 1;
            } return (n * fatorial(n-1));
            
            
        }
    }
}
