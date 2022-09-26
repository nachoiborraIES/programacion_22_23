/* Programa que le pide al usuario a qué velocidad lleva el coche (en Km/h) 
 * y a qué distancia está la ciudad a la que quiere llegar (en Km), y le dice
 * cuántos minutos tardará en llegar.
 */
 
using System;
 
class Practica
{
    static void Main()
    {
        int velocidad, distancia, minutos;
        
        Console.WriteLine("¿A cuántos km/h llevas el coche? (Introduce " +
        "sólo el número)");
        velocidad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¿A cuántos kilómetros está el lugar al que " + 
        "quieres llegar? (Introduce sólo el número)");
        distancia = Convert.ToInt32(Console.ReadLine());
        minutos = (distancia*60)/velocidad;
        Console.WriteLine("Tardarás en llegar {0} minutos.", minutos);
    }
}
 
