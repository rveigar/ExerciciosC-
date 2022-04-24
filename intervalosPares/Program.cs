using System;

namespace intervalosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(intervaloPares(1,20,4));
        }
    
        static string intervaloPares(int inicio, int fim, int quantidade) 
        {
            int quant=0;
            int[] lista;
            lista = new int[quantidade];
            for (int i=inicio; i<=fim && quant < quantidade; i++)
            {
                if (i%2 == 0)
                {
                    //Console.WriteLine($"i= {i} é par");
                    lista[quant]=i;
                    quant +=1;

                }
            }
             return String.Join(",",lista);
        }
    }

     

}
