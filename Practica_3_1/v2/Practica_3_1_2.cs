//Programa que transforma una medida de centímetros a pulgadas o viceversa.
using System;

class Ejercicio
{
    
    static void Main()
    {
        bool dato = false;
        float num = 0;
        string opcion;
        do
        {
            try
            {
                Console.WriteLine("Indica el número de la medida");
                num = Convert.ToSingle(Console.ReadLine());
                dato = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: dato no válido. Vuélvelo a intentar.");
                Console.WriteLine(e.Message);
            }
        }
        while(!dato);
        Console.WriteLine("Indica la unidad (C = centimetros, P = pulgadas):");
        opcion =  Console.ReadLine();
        if (opcion == "C")
        {
            Console.WriteLine(num+" pulgadas son "+
                              (num/2.54).ToString("N3")+" centímetros.");
        }
        
        else if (opcion == "P")
        {
            Console.WriteLine(num+" pulgadas son "+
                              (num*2.54).ToString("N3")+" centímetros.");
        }
        else
        {
            Console.WriteLine("Unidad no válida");
        }
    }
}
