
//Practica realizada por Manuel Pérez Moya 1ºDAM B

/*En esta practica le pide al usuario que pida un numero y muestre los
 * 10 numeros que le siguen y los 5 que le preceden separados por comas.
 * */

using System;

class Practica_2_2_2
{
	static void Main()
	{
		int numero;
		
		Console.Write("Dime un numero: ");
		numero = Convert.ToInt32(Console.ReadLine());
		
		Console.Write("10 numeros siguientes: ");
		for(int i = numero+1;i <= numero+10; i++)
		{
			if( i < numero + 10)
			{
				Console.Write("{0}," ,i);
			}
			else
			{
				Console.Write(i);
			}
		}
		Console.WriteLine();
		
		Console.Write("5 numeros anteriores: ");
		for(int i = numero-1;i >= numero-5; i--)
		{
			if( i > numero -5)
			{
				Console.Write("{0}," ,i);
			}
			else
			{
				Console.Write(i);
			}
		}
		Console.WriteLine();
	}
}
		
