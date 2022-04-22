using System;

namespace contaLetras
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine(contaLetras("minha terra é redonda", 'r'));
        }
        public static string contaLetras (string texto, char letra)
        {
            int cont=0;
            foreach (char c in texto)
            {
                //Console.WriteLine($"valor de c= {c} letra= {letra}");
                if (c == letra)
                {
                    cont += 1;
                     //Console.WriteLine($"valor de cont= {cont}");
                } 
            }
            return ($"Letra {letra} ocorre {cont} vezes em {texto}");
        }
    }
}
