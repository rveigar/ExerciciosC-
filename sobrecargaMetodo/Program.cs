using System;

namespace sobrecargaMetodo
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular calc=new Calcular();
            //var res=calc.Soma(10,20,30);
            System.Console.WriteLine($"valor de res= {calc.Soma(10,20,30)}");

            var res=calc.Soma(10.1,20.2,30.3,40 );
            System.Console.WriteLine($"valor de res= {res}");

            
        }
    }

    class Calcular
    {
        public int Soma(params int[]n )
        {
            int res=0;
            for (int i = 0; i <n.Length; i++)
            {
                res += n[i];
            }
            return res;
        }

         public double Soma(params double[]n )
        {
            double res=0;
            for (int i = 0; i <n.Length; i++)
            {
                res += n[i];
            }
            return res;
        }
    }
}
