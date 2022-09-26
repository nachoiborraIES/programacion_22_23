/* Programa que le pide al usuario tres notas de exámenes 
 * y muestra la media de las tres, sin decimales.
 */
 
using System;
 
class Practica
{
	static void Main()
	{
        int nota1, nota2, nota3, media;
        
		Console.WriteLine("Dime la nota sin decimales del primer examen");
        nota1= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime la nota sin decimales del segundo examen");
        nota2= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Dime la nota sin decimales del tercer examen");
        nota3= Convert.ToInt32(Console.ReadLine());
        media=(nota1+nota2+nota3)/3;
        Console.WriteLine("Tu nota media es {0}.", media);
	}
}
