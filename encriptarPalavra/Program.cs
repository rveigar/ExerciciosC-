using System;

namespace encriptarPalavra
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(encriptaPalavras("ola",2));
            Console.WriteLine(cryptoPalavras("caz",1));
        }
        public static string encriptaPalavras(string palavra, int chave)
        {
            string[] abc = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
            foreach (string i in abc)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine("[{0}]", string.Join(", ", abc));
            return string.Join(",",abc);
        }

        public static string cryptoPalavras(string texto, int num)
        {
            string[] retorno ;
            retorno = new string[texto.Length];
            string[] abc = {"a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z"};
            Console.WriteLine(texto);
            for (int i = 0; i < texto.Length; i++)
            {   
                int index = Array.IndexOf(abc, texto[i].ToString());
                Console.WriteLine($"valor de i= {i} valor de index= {index} texto[i] = {texto[i]}");
                if ((index + num) < abc.Length - 1)
                {
                    retorno[i] = abc[index+num];
                    Console.WriteLine($"    valor de abc[index+num]= {abc[index+num]}");
                } else 
                    {
                        Console.WriteLine($"valor de abc.Length= {abc.Length}");
                        var passou = ((index + num)%(abc.Length)) ;
                        Console.WriteLine($"        valor de passou= {passou} ");
                        Console.WriteLine("        Valor de index%texto.Length= {index%texto.Length}");
                        retorno[i]=abc[passou];

                       
                    }
            }
            // Console.WriteLine("[{0}]", string.Join(", ", retorno));
            
            return String.Join(",",retorno);
            // return "[" + String.Join(",",retorno) + "]"; 
        }

    }
}
