using System;
using System.Collections.Generic;

namespace somaAteMeta
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            somaAteMeta (18,79);
        }
        static int somaAteMeta(int inicio, int meta)
        {
            int soma=0;
            List<int> arr = new List<int>();
            for (int i = inicio ;  soma+i <= meta ;  i++)
            {
                //System.Console.WriteLine($"valor de soma Antes = {soma}");
                //System.Console.WriteLine($"valor de i= {i}");
                soma = soma+i;
                arr.Add(i);
                //System.Console.WriteLine($"    valor de soma Depois= {soma}");
                System.Console.WriteLine($"        valor de soma + i = {soma+i}");
            }
            System.Console.WriteLine($"Valor de arr= {String.Join(",",arr)}");
            System.Console.WriteLine($"Valor de soma= {soma}");
            
            return soma;
        }
    }
}
