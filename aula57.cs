using System;
using System.Collections.Generic;
class Aula57{

    static void Main(){
        List<string> carros = new List<string>();
        carros.Add("Golf");
        carros.Add("BMW");
        carros.Add("Ford");
        carros.Add("Renault");

        foreach (string c in carros){
            System.Console.WriteLine(c);
        }


    }
}