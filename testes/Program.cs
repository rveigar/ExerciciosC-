using System;

namespace testes
{
    class Program
    {
        // Enums não são declarados dentro de métodos
        // Enums não podem ser declarados dentro de métodos, 
        // o compilador acusará um erro quando este código for escrito. 
        // Os enums podem ser de declarados dentro de uma classe ou fora da mesma, 
        // abaixo do namespace ou então acima do mesmo. 
        // Mas nunca dentro de métodos.

        enum diasDaSemana { Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado };
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] indices = { 99, 14, 2, 34, 55, 89, 65 };
            insertionSort2(indices);
            eNumerador();
            Employee E = new Employee();
            E.GetInfo();
        }

        static void insertionSort(int[] indices)
        {
            int aux;
            for (int i = 0; i < indices.Length; i++)
            {
                System.Console.WriteLine("valor de i = {0} valor de indice [i]= {1}", i, indices[i]);
                for (int j = i + 1; j < indices.Length; j++)
                {
                    aux = indices[j];
                    if (indices[j] < indices[i])
                    {
                        indices[j] = indices[i];
                        indices[i] = aux;
                        System.Console.WriteLine("    valor de i = {0} j = {1} valor de indice [i]= {2}", i, j, indices[i]);

                    }

                }
            }
            System.Console.WriteLine(String.Join(",", indices));
        }

        static void insertionSort2(int[] A)
        {
            System.Console.WriteLine(String.Join(",", A));
            int key;
            int i;
            for (int j = 1; j < A.Length; j++)
            {
                System.Console.WriteLine($" j = {j} A[j] = {A[j]} ");
                key = A[j];
                i = j - 1;
                System.Console.WriteLine($"   i = {i} j = {j} A[j] = {A[j]} ");
                while (i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];

                    i = i - 1;
                    A[i + 1] = key;
                    // A[i]=key;
                    System.Console.WriteLine($"        i = {i} j = {j} A[j] = {A[j]} i+1 = {i + 1} A[i+1] = {A[i + 1]} ");

                }


            }
            System.Console.WriteLine(String.Join(",", A));
        }

        static void eNumerador()
        {
            diasDaSemana ds = diasDaSemana.Domingo;
            System.Console.WriteLine($"valor de ds = {ds}");

            ds = (diasDaSemana)3;
            System.Console.WriteLine($"valor de ds = {ds}");

            int i = (int)diasDaSemana.Sexta;
            System.Console.WriteLine($"valor de i = {i}");

        }



    }

    public class Person
    {
        protected string ssn = "444-55-6666";
        protected string name = "John L. Malgraine";

        public virtual void GetInfo()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("SSN: {0}", ssn);
        }
    }

    class Employee : Person
    {
        public string id = "ABC567EFG";
        public override void GetInfo()
        {
            // Calling the base class GetInfo method:
            base.GetInfo();
            Console.WriteLine("Employee ID: {0}", id);
        }
    }

    

}
