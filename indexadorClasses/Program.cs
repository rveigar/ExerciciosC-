using System;

namespace indexadorClasses
{
    class Program 
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro();
            c1[0] = 50;
            System.Console.WriteLine($"Valor de velMax[0] = {c1[0]}");
        }
    }

    class Carro
    {
        private int[] velMax = new int[5] {1, 2, 3, 4,5};
        public int this[int i]
        {
            get { return (int)velMax[i]; }
            set { this.velMax[i] = value; }
        }
    }    

}
