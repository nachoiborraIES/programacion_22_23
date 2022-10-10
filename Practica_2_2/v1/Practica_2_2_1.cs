//Practica realizada por Manuel Pérez Moya 1ºDAM B

/*La practica nos pide que le pida al usuario el año actual y su año
 * de nacimiento, en este ultimo lo tendremos que pedir tantas veces
 * hasta que sea correcto.Por ultimo, mostrara por pantalla el numero de
 * años del usuario.*/

using System;

class Practica_2_2_1
{
	static void Main()
	{
		int anyoActual, anyoNacimiento,resta;
		Console.Write("Dime el año actual: ");
		anyoActual = Convert.ToInt32(Console.ReadLine());
		
		do
		{
			Console.Write("Dime tu año de nacimiento: ");
			anyoNacimiento = Convert.ToInt32(Console.ReadLine());
			if(anyoNacimiento >= anyoActual)
			{
				Console.WriteLine("Año de nacimiento incorrecto.");
			}
		}
		while(anyoNacimiento > anyoActual);
		
		resta = anyoActual - anyoNacimiento;
		Console.WriteLine("El usuario tiene {0} años", resta);
	}
}
		
