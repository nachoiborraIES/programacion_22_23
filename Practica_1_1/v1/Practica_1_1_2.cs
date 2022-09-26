/*Programa que le pide al usuario la distancia y la velocidad 
  y muestra por pantalla los minutos que tardará en llegar a su destino*/

using System;

class Practica_1_1_2
{
    static void Main()
	{
        
        int velocidad, distancia, tiempo;
        Console.WriteLine("¿A que velocidad en Km/h va su coche?");
        velocidad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("¿A qué distancia en Km está la ciudad,");
        Console.WriteLine("a la que quiere llegar?");
        distancia = Convert.ToInt32(Console.ReadLine());
        
        tiempo = distancia * 60 / velocidad;
        
        Console.WriteLine("Tardará {0} minutos en llegar a su destino", tiempo);
        
    }
}
