using System;

namespace subString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
           // subString2("0123435","35");
        string s1 = "13";
		string s2 = "1213413";

		int res = isSubstring(s1, s2);

		if (res == -1)
			Console.Write("Not present");
		else
			Console.Write("Present at index "+ res);
        }

        static void subString(string sub1, string sub2)
        {   int cont=0;
            int flag=0;
            foreach (char c in sub2)
            {
                System.Console.WriteLine($"valor de c= {c}");
                while (cont < sub2.Length)
                {
                    System.Console.WriteLine($"++++  valor de cont = {cont} sub1[cont] = {sub1[cont]} valor de c = {c} flag = {flag}");                   
                     if (c == sub1[cont])
                    {
                        System.Console.WriteLine("if");
                        flag=1;
                        System.Console.WriteLine($".......    valor de cont = {cont} sub1[cont] = {sub1[cont]} flag = {flag}");

                        cont = cont + 1;
                        System.Console.WriteLine($"valor de cont = {cont}");
                    } else
                    {
                        System.Console.WriteLine("else");
                        if (flag==1)
                        {
                            System.Console.WriteLine($"FALSE");
                        }
                        cont = cont + 1;

                    }
                }

            }

        }
   
        static void subString2(string str1, string substr1)
        {
            System.Console.WriteLine(  ("0123435,35") );
           for (int i = 0; i < substr1.Length; i++)
           {
              System.Console.WriteLine($"valor de i = {i} substr[i] = {substr1[i]}");

              for (int j = 0; j < str1.Length; j++)
              {
                  if (str1[j] == substr1[i])
                  {
                      System.Console.WriteLine($"encontrei substr[i] i = {i} j = {j} ");
                      continue;
                  } System.Console.WriteLine($"   nao encontrei substr[i] i = {i} j = {j} ");
                  break;
              }
           }
        }
    
        static int isSubstring(string s1, string s2)
	    {
            
            int M = s1.Length;
            int N = s2.Length;
            System.Console.WriteLine($"s1 = 13    s2=1213413  N-M = {N-M}");

            /* A loop to slide pat[] one by one */
            for (int i = 0; i <= N - M; i++) 
            {
                int j;

                /* For current index i, check for
                pattern match */
                for (j = 0; j < M; j++)
                {
                    System.Console.WriteLine($"valor de i = {i} valor de j = {j}  = s2[{i+j}] != s1[{j}] ..... {s2[i+j]} != {s1[j]}");
                    if (s2[i + j] != s1[j])
                        break;
                }

                if (j == M){

                    System.Console.WriteLine($"....valor de j = {j}  M = {M}");
                    return i;
                }
            }

            return -1;
	    }
    }
}
