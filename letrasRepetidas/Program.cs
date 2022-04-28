using System;
using System.Linq;
using System.Collections.Generic;


namespace letrasRepetidas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //letrasRepetidas2("socorro");
            teste2("socorro");
        }



	 public static void teste2(string texto)
        {
            // acrescentar using System.Collections.Generic para poder usar List;
            List<char> saida2 = new List<char>();
            string s5 = "karrrancak";
            foreach (char c in s5)
            {
                s5=s5.Remove(0,1);

                System.Console.WriteLine($"valor de c= {c}    valor de s5= {s5}   ");
                if (s5.Contains(c))
                {
                    System.Console.WriteLine($"        existe letra {c} duplicada");
                    if (!saida2.Contains(c))
                    {
                        saida2.Add(c);
                    }

                }
                System.Console.WriteLine($"                valor de saida2= " + String.Join(',',saida2));
                

            }

        }
    }
}