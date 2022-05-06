using System;

namespace subArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 1, 3, 5};
            int[] arr3 = { 1, 5, 3};
            int[] arr4 = { 1, 0, 3};
            int[] arr5 = { 1, 6};

            System.Console.WriteLine("Digite o Array principal separando os numeros por vírgula");
            var ar1 = Array.ConvertAll(Console.ReadLine().Trim().Split(','),Convert.ToInt32);
            //  string foo = Console.ReadLine();
            //  string[] token1 = foo.Split(",");
            System.Console.WriteLine("Digite o SubArray separando os numeros por vírgula");
            var ar2 = Array.ConvertAll(Console.ReadLine().Trim().Split(','),Convert.ToInt32);

            //  string foo2 = Console.ReadLine();
            //  string[] token2 = foo.Split(",");

            //System.Console.WriteLine(subArray(arr1, arr3)); 
            System.Console.WriteLine(subArray(ar1, ar2)); 
        }
        static bool subArray(int[] arr1, int[] arr2)
        {
            //procura se arr2 está em array1
            // “1,3,5” é uma subsequência de “1,2,3,4,5”
            // “[1,3,4] não é uma subsequencia de [1,4,3,5]", a ordem é diferente
            int cont=0;
            foreach (var c in arr2)
            {
                if (cont >= arr1.Length){
                    System.Console.WriteLine("if do foreach");
                return false;
                }
              System.Console.WriteLine($"Valor de c= {c}");
              //for (int i=cont; i < arr1.Length; )
              //for (;cont < arr1.Length;)
              while (cont < arr1.Length)
              {
                  System.Console.WriteLine($"   valor de cont= {cont}");
                  if (c == arr1[cont])
                  {
                      cont = cont+1;
                      break;
                  } else {
                      cont = cont +1;
                       if (cont >= arr1.Length){
                           System.Console.WriteLine("if do else");
                           return false;
                        }
                    }
              }
            }
            return true;
        }
    }
}
