using System;

namespace avancarDiasSemana
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um dia da semana (segunda-feira)");
            var dia = Console.ReadLine();
            Console.WriteLine("Digite um número para calcular novo dia da semana");
            var num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"dia= {dia} num= {num}");

            //Console.WriteLine(avancarDiasSemana(dia,num));
            Console.WriteLine(novoDia(dia, num));

        }

        public static string avancarDiasSemana(string dia, int quantidade)
        {
            int novoDia = 0;

            string diaDaSemana = ""; // error CS0165: Uso de variável local não atribuída
            switch (dia.ToLower())
            {
                case "segunda-feira":
                    novoDia = 1;
                    //Console.WriteLine($"novoDia= {novoDia}");
                    break;
                case "terca-feira":
                case "terça-feira":
                    novoDia = 2;
                    // Console.WriteLine($"novoDia= {novoDia}");
                    break;
                case "quarta-feira":
                    novoDia = 3;
                    // Console.WriteLine($"novoDia= {novoDia}");
                    break;
                case "quinta-feira":
                    novoDia = 4;
                    // Console.WriteLine($"novoDia= {novoDia}");
                    break;
                case "sexta-feira":
                    novoDia = 5;
                    // Console.WriteLine($"novoDia= {novoDia}");
                    break;
                case "sabado":
                case "sábado":
                    novoDia = 6;
                    // Console.WriteLine($"novoDia= {novoDia}");
                    break;
                case "domingo":
                    novoDia = 7;
                    // Console.WriteLine($"novoDia= {novoDia}");
                    break;
            }
            if ((novoDia + quantidade) < 7)
            {
                Console.WriteLine($"novoDia {novoDia}");
                novoDia = novoDia + quantidade;
            }
            else
            {
                novoDia = (novoDia + quantidade) % 7;
                //Console.WriteLine($"novoDia {novoDia}");
            }

            switch (novoDia)
            {
                case 1:
                    diaDaSemana = "Segunda-feira";
                    break;
                case 2:
                    diaDaSemana = "Terça-feira";
                    break;
                case 3:
                    diaDaSemana = "Quarta-feira";
                    break;
                case 4:
                    diaDaSemana = "Quinta-feira";
                    break;
                case 5:
                    diaDaSemana = "Sexta-feira";
                    break;
                case 6:
                    diaDaSemana = "Sábado";
                    break;
                case 7:
                    diaDaSemana = "Domingo";
                    break;
            }
            return ($"dia= {dia} num = {quantidade}  novoDiaDaSemana = {diaDaSemana}");
        }

        public static string novoDia(string dia, int quantidade)
        {
            string[] semana = { "segunda-feira", "terca-feira", "quarta-feira", "quinta-feira", "sexta-feira", "sabado", "domingo" };

            int indice = Array.IndexOf(semana, dia);
            System.Console.WriteLine($"valor de indice= {indice}");

            if ((indice + quantidade) < 7)
            {
                System.Console.WriteLine($"Novo dia = {semana[indice + quantidade]}");
            }
            else
            {
                System.Console.WriteLine($"Novo dia = {semana[(indice + quantidade) % 7]}");
            }
            return null;
        }
    }
}