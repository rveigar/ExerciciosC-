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
            System.Console.WriteLine("Digite um texto: ");
            string texto = Console.ReadLine();
            letraDuplicada(texto);
        }



	 public static void letraDuplicada(string texto)
        {
            // acrescentar using System.Collections.Generic para poder usar List;
            List<char> saida2 = new List<char>();
            //string s5 = "karrrancak";
            //string s5 = texto;
            foreach (char c in texto)
            {
                texto=texto.Remove(0,1);
                //System.Console.WriteLine($"valor de c= {c}    valor de texto= {texto}   ");
                if (texto.Contains(c))
                {
                    //System.Console.WriteLine($"        existe letra {c} duplicada");
                    if (!saida2.Contains(c))
                    {
                        saida2.Add(c);
                    }
                }
                
                

            }
            System.Console.WriteLine($"========= valor de saida2= " + String.Join(',',saida2));

        }
    }
}