/* Práctica_4_2 modificada y dividida en funciones para acortar el Main */

using System;
using System.Text;

class Ejercicio
{
    enum opciones { SALIR, INSERTAR, BORRAR, CARO, TIPO, TITULO }
    enum genero { ROL=1, INFANTIL, PUZZLE, OTROS }
    
    struct infoBasica
    {
        public byte edadMinima, minimoJugadores, maximoJugadores;
    }
    
    struct juego
    {
        public string nombre;
        public infoBasica informacion;
        public float precio;
        public genero generoJuego;
    }
    
    static int MostrarMenu()
    {
        int opcion;
        
        Console.WriteLine("Menú de opciones:");
        Console.WriteLine((int)opciones.INSERTAR + 
            ". Nuevo juego");
        Console.WriteLine((int)opciones.BORRAR + 
            ". Borrar juego");
        Console.WriteLine((int)opciones.CARO + 
            ". Juego más caro");
        Console.WriteLine((int)opciones.TIPO + 
            ". Juegos por tipo");
        Console.WriteLine((int)opciones.TITULO + 
            ". Juegos por titulo");
        Console.WriteLine((int)opciones.SALIR + 
            ". Salir");
        Console.WriteLine("Elige una opción del menú:");
        
        opcion = Convert.ToInt32(Console.ReadLine());
        
        return opcion;
    }
    
    static void MostrarGeneros()
    {
        Console.WriteLine("Género del juego: ");
        Console.WriteLine((int)genero.ROL + 
            " .Rol");
        Console.WriteLine((int)genero.INFANTIL + 
            " .Infantil");
        Console.WriteLine((int)genero.PUZZLE + 
            " .Puzzle");
        Console.WriteLine((int)genero.OTROS +
            " .Otros");
    }
    
    static void RecogerInfoJuego(out juego nuevoJuego, ref bool errorCatch)
    {
        
        Console.Write("Nombre del juego: ");
        nuevoJuego.nombre = Console.ReadLine();
        
        Console.WriteLine("Información del juego: ");
        
        Console.Write(" -Edad minima: ");
        nuevoJuego.informacion.edadMinima = 
            Convert.ToByte(Console.ReadLine());
            
        Console.Write(" -Mínimo de jugadores: ");
        nuevoJuego.informacion.minimoJugadores = 
            Convert.ToByte(Console.ReadLine());
            
        Console.Write(" -Máximo de jugadores: ");
        nuevoJuego.informacion.maximoJugadores =
            Convert.ToByte(Console.ReadLine());
            
        Console.Write("Precio del juego: ");
        
        if (!Single.TryParse(Console.ReadLine(), out nuevoJuego.precio))
            errorCatch = true;
        
        MostrarGeneros();
        
        nuevoJuego.generoJuego = 
            (genero)Convert.ToInt32(Console.ReadLine());
    }
    
    static void NuevoJuego(juego[] juegos, ref int cantidad)
    {
        juego nuevoJuego;
        nuevoJuego.precio = 0;
        bool errorCatch = false;
                    
        if (cantidad < juegos.Length)
        {
            RecogerInfoJuego(out nuevoJuego, ref errorCatch);
            
            if(nuevoJuego.precio > 0 && errorCatch == false)
            {
                juegos[cantidad] = nuevoJuego;
                cantidad++;
            }
            else
            {
                Console.WriteLine("Precio incorrecto");
                Console.WriteLine("Juego no guardado");
            }
        }
        
        Console.WriteLine("Pulsa ENTER para continuar");
        Console.ReadLine();
    }
    
    static void BorrarJuego(juego[] juegos, ref int cantidad)
    {
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine("{0}- {1}", i+1, juegos[i].nombre);
        }

        Console.WriteLine("Posición del juego: ");
        int posicion = Convert.ToInt32(Console.ReadLine());
        posicion--;

        Console.WriteLine("Seguro? S/N");
        string respuestaConfirmacion = Console.ReadLine();


        if (respuestaConfirmacion == "S")
        {
            if (cantidad > 0 && posicion >= 0 && posicion < cantidad)
            {
                for (int i = posicion; i < cantidad - 1; i++)
                {
                    juegos[i] = juegos[i+1];
                }
                cantidad--;

                System.Console.WriteLine("Borrado realizado");
            }
        }
        else
        {
            System.Console.WriteLine("Borrado cancelado");
        }
        
        Console.WriteLine("Pulsa ENTER para continuar");
        Console.ReadLine();
    }
    
    static int JuegoMasCaro(juego[] juegos, int cantidad)
    {
        float precioMax = juegos[0].precio;
        int maximo = 0;
        
        if(cantidad > 0)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if (juegos[i].precio > precioMax)
                {
                    precioMax = juegos[i].precio;
                    maximo = i;
                }
            }
        }
        else
            maximo = -1;
            
        return maximo;
    }
    
    static void MostrarInfoJuego(juego[] juegos, int i)
    {
        Console.WriteLine(juegos[i].nombre);
        Console.WriteLine
            (juegos[i].informacion.edadMinima);
        Console.WriteLine
            (juegos[i].informacion.minimoJugadores);
        Console.WriteLine
            (juegos[i].informacion.maximoJugadores);
        Console.WriteLine(juegos[i].precio + "€");
    }
    
    static void JuegosPorTipo(juego[] juegos, int cantidad)
    {
        MostrarGeneros();
                        
        genero buscarGenero = 
            (genero)Convert.ToInt32(Console.ReadLine());
            
        bool existeGenero = false;
        
        if ((int)buscarGenero >= (int)genero.ROL && 
            (int)buscarGenero <= (int)genero.OTROS)
        {
            for (int i = 0; i < cantidad; i++)
            {
                if ((genero)buscarGenero == juegos[i].generoJuego)
                {
                    existeGenero = true;
                    MostrarInfoJuego(juegos, i);
                }
            }
            
            if (!existeGenero)
            {
                System.Console.WriteLine("No se encuentran juegos");
            }
        }

        else
        {
            System.Console.WriteLine("No existe esa opción");
        }
        
        Console.WriteLine("Pulsa ENTER para continuar");
        Console.ReadLine();
    }
    
    static void BuscarPorTitulo(juego[] juegos, int cantidad)
    {
        Console.Write("Introduce el nombre del juego: ");
        
        string buscarTitulo = Console.ReadLine();
        
        for (int i = 0; i < cantidad; i++)
        {
            if (juegos[i].nombre.ToUpper().Contains
                (buscarTitulo.ToUpper()))
            {
                MostrarInfoJuego(juegos, i);
            }
        }
        
        Console.WriteLine("Pulsa ENTER para continuar");
        Console.ReadLine();
    }
			
    static void Main()
    {
        int cantidad = 0, opcion;
        juego[] juegos = new juego[30];
        
        do
		{
            Console.Clear();
            opcion = MostrarMenu();
			
			switch((opciones)opcion)
			{
				case opciones.INSERTAR:
                
                    NuevoJuego(juegos, ref cantidad);
                    
					break;
                    
				case opciones.BORRAR:
                
                    BorrarJuego(juegos, ref cantidad);
                    
					break;
                    
				case opciones.CARO:
                
					int masCaro = JuegoMasCaro(juegos, cantidad);
                    
                    if(masCaro != -1)
                    {
                        Console.WriteLine("El juego mas caro es: ");
                        MostrarInfoJuego(juegos, masCaro);
                    }
                    
                    else
                    {
                        Console.WriteLine("No hay juegos");
                    }
                    
                    Console.WriteLine("Pulsa ENTER para continuar");
                    Console.ReadLine();
                    
					break;
                    
				case opciones.TIPO:
                
                    JuegosPorTipo(juegos, cantidad);
                    
					break;
				case opciones.TITULO:
					
                    BuscarPorTitulo(juegos, cantidad);
                    
					break;
				case opciones.SALIR:
					Console.WriteLine("Fin del programa");
					break;
				default:
					Console.WriteLine("Opción incorrecta");
					break;
			}
		}
		while(opcion != (int)opciones.SALIR);
        
    }
}
        
