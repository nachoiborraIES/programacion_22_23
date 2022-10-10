/*Programa que pide el año actual y de nacimiento del usuario
 * hasta que introduzca uno válido, 
 * tras lo que le dice su edad.*/

using System;

class Ejercicio
{
    static void Main()
    {
        int fecha, nacimiento;
        Console.WriteLine("Escribe el año actual: ");
        fecha = Convert.ToInt32(Console.ReadLine());
        do
        {
            Console.WriteLine("Escribe tu año de nacimiento: ");
            nacimiento = Convert.ToInt32(Console.ReadLine());
        }
        while(nacimiento > fecha);
        
        Console.WriteLine("Tienes " + (fecha - nacimiento) + " años");
    }
}
