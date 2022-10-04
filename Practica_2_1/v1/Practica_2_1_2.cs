/*
 * Este programa pide al usuario un código numérico completo, si es 
 * 5678 o 8765 le mostrará el saludo "Hola, señor", si es 1234 o 4321 le 
 * mostrará el saludo "Hola, señora". Si es otro le mostrará el mensaje
 * "Código no identificado".
 */
using System;
class Practica
{
    static void Main()
    {
        int num;
        Console.WriteLine("Escribe un código numérico completo.");
        num = Convert.ToInt32(Console.ReadLine());
        switch (num)
        {
            case 5678:
            case 8765:
                Console.WriteLine ("Hola, señor.");
                break;
            case 1234:
            case 4321:
                Console.WriteLine ("Hola señora.");
                break;
            default:
                Console.WriteLine ("Código no identiificado.");
                break;
        }
    }
}
