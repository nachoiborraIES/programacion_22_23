/* Programa para almacenar información sobre hasta 50 juegos. El usuario puede
 * añadir juegos al programa, borrar un juego, buscar el juego más caro, buscar
 * juegos por tipo y buscar juegos por título, eligiendo la opción 
 * correspondiente en el menú. La información guardada de cada juego es el
 * título, el mínimo y máximo de jugadores, la edad mínima recomendada, el
 * precio y el tipo de juego, que puede ser rol, infantil, puzzle u otros.
 */

using System;

class Practica
{
    enum tipo {ROL=1, INFANTIL, PUZZLE, OTROS}
    
    enum opciones {SALIR, INSERTAR, BORRAR, CARO, BUSCAR_TIPO, BUSCAR_TITULO}
    
    struct infoBasica
    {
        public byte edad;
        public byte minJugador;
        public byte maxJugador;
    }
        
    struct datosJuego
    {
        public string nombre;
        public infoBasica info;
        public double precio;
        public tipo tipoJuego;
    }
    
    static void ListarJuego(datosJuego[] listaJuegos, int posicion)
    {
        Console.WriteLine("Título del juego: " 
            + listaJuegos[posicion].nombre);
        Console.WriteLine("Edad mínima para jugar: " 
            + listaJuegos[posicion].info.edad);
        Console.WriteLine("Mínimo de jugadores: "
            +listaJuegos[posicion].info.minJugador);
        Console.WriteLine("Máximo de jugadores: "
            +listaJuegos[posicion].info.maxJugador);
        Console.WriteLine("Precio: " 
            + listaJuegos[posicion].precio+" euros");
        Console.WriteLine("Tipo de juego: " 
            + listaJuegos[posicion].tipoJuego);
        Console.WriteLine();
    }
    
    static opciones MostrarMenu()
    {
        opciones opcion;
        
        Console.Clear();
        Console.WriteLine("Elige una opción:");
        Console.WriteLine((int)opciones.INSERTAR + ". Nuevo juego");
        Console.WriteLine((int)opciones.BORRAR + ". Borrar juego");
        Console.WriteLine((int)opciones.CARO + ". Juego más caro");
        Console.WriteLine((int)opciones.BUSCAR_TIPO + ". Juegos por tipo");
        Console.WriteLine((int)opciones.BUSCAR_TITULO + 
            ". Juegos por título");
        Console.WriteLine((int)opciones.SALIR + ". Salir");
        
        opcion = (opciones)Convert.ToInt32(Console.ReadLine());
        
        return opcion;
    }
    
    static void NuevoJuego(datosJuego[] listaJuegos, ref int cantidad)
    {
        if(cantidad < listaJuegos.Length)
        {
            datosJuego nuevo;
            Console.WriteLine("Título del juego:");
            nuevo.nombre = Console.ReadLine();
            Console.WriteLine("Edad mínima para jugar:");
            nuevo.info.edad = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Mínimo de jugadores:");
            nuevo.info.minJugador = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Máximo de jugadores:");
            nuevo.info.maxJugador = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Tipo de juego:");
            foreach(tipo t in Enum.GetValues(typeof(tipo)))
            {
                Console.WriteLine("{0}. {1}", (int)t, t);
            }
            nuevo.tipoJuego = (tipo)Convert.ToInt32(Console.ReadLine());
                
            try
            {
                Console.WriteLine("Precio del juego:");
                nuevo.precio = Convert.ToDouble(Console.ReadLine());
                if(nuevo.precio > 0)
                {
                    listaJuegos[cantidad] = nuevo;
                    cantidad++;
                }
                else
                {
                    Console.WriteLine("Precio no válido");
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Precio no válido.");
            }
        }
        else
        {
            Console.WriteLine("No caben más juegos.");
        }
        Console.WriteLine("Intro para continuar.");
        Console.ReadLine();
    }
    
    static void BorrarJuego(datosJuego[] listaJuegos, ref int cantidad)
    {
        char confirmacion;
        int posicion;
        for(int i = 0; i <cantidad; i++)
        {
            Console.WriteLine("{0}. {1}", (i+1), listaJuegos[i].nombre);
        }
        Console.WriteLine("Posición del juego a borrar:");
        posicion = Convert.ToInt32(Console.ReadLine())-1;
        if(posicion>=0 && posicion<cantidad)
        {
            Console.Write("Has elegido el juego \"{0}\".", 
                listaJuegos[posicion].nombre);
            Console.WriteLine("¿Seguro que quieres borrarlo?(S/N)");
            confirmacion = Convert.ToChar(Console.ReadLine().ToLower());
            if(confirmacion=='s')
            {
                for(int i = posicion; i<cantidad-1; i++)
                {
                    listaJuegos[i] = listaJuegos[i+1];
                }
                cantidad--;
                Console.WriteLine("Lista actualizada:");
                for(int i = 0; i <cantidad; i++)
                {
                    Console.WriteLine("{0}. {1}", (i+1), listaJuegos[i].nombre);
                }
                Console.WriteLine("Intro para continuar.");
                Console.ReadLine();
            }
            else if(confirmacion=='n')
            {
                Console.WriteLine("Borrado cancelado. Intro para continuar.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Opción no válida.");
            }
        }
        else
        {
            Console.WriteLine("No hay juegos en esa posición.");
            Console.WriteLine("Intro para continuar.");
            Console.ReadLine();
        }
    }
    
    static int JuegoMasCaro(datosJuego[] listaJuegos, int cantidad)
    {
        int posicion = 0;
        
        if(cantidad>0)
        {
            datosJuego maximo = listaJuegos[0];
            for(int i =1; i<cantidad;i++)
            {
                if(listaJuegos[i].precio>maximo.precio)
                {
                    maximo = listaJuegos[i];
                    posicion = i;
                }
            }
        }
        else
        {
            posicion = -1;
        }
        
        return posicion;
    }
    
    static void JuegosPorTipo(datosJuego[] listaJuegos, int cantidad)
    {
        int tipoBuscar;
        
        Console.WriteLine("¿Qué tipo de juego quieres buscar?");
        
        foreach(tipo t in Enum.GetValues(typeof(tipo)))
        {
            Console.WriteLine("{0}. {1}", (int)t, t);
        }
        
        tipoBuscar = Convert.ToInt32(Console.ReadLine());
        
        if(tipoBuscar<= (Enum.GetValues(typeof(tipo)).Length)
            && tipoBuscar > 0)
        {
            bool existe=false;
            for(int i = 0; i<cantidad; i++)
            {
                if(tipoBuscar==(int)listaJuegos[i].tipoJuego)
                {
                    existe=true;
                    ListarJuego(listaJuegos, i);
                }
            }
            if(!existe)
            {
                Console.Write("No se encuentran juegos ");
                Console.WriteLine("del tipo indicado");
            }
            Console.WriteLine("Intro para continuar.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Tipo inválido.");
            Console.WriteLine("Intro para continuar.");
            Console.ReadLine();
        }
    }
    
    static void JuegosPorTitulo(datosJuego[] listaJuegos, int cantidad)
    {
        string tituloBuscar;
        Console.WriteLine("Escribe el título del juego:");
        tituloBuscar=Console.ReadLine().ToLower();
        bool contiene = false;
        for(int i = 0; i<cantidad; i++)
        {
            if(listaJuegos[i].nombre.ToLower().
                Contains(tituloBuscar))
            {
                contiene = true;
                ListarJuego(listaJuegos, i);
            }
        }
        if(!contiene)
        {
            Console.WriteLine("No hay juegos con ese nombre.");
        }
        Console.WriteLine("Intro para continuar.");
        Console.ReadLine();
    }
    
    static void Main()
    {
        datosJuego[] listaJuegos = new datosJuego[30];
        opciones opcion;
        int cantidad=0;
        int posicion;
        
        do
        {
            opcion = MostrarMenu();
            
            switch(opcion)
            {
                case opciones.INSERTAR:
                    NuevoJuego(listaJuegos, ref cantidad);
                    break;
                    
                case opciones.BORRAR:
                    BorrarJuego(listaJuegos, ref cantidad);
                    break;
                    
                case opciones.CARO:
                    posicion = JuegoMasCaro(listaJuegos, cantidad);
                    if(posicion == -1)
                    {
                        Console.WriteLine("No hay juegos.");
                    }
                    else
                    {
                        ListarJuego(listaJuegos, posicion);
                    }
                    Console.WriteLine("Intro para continuar");
                    Console.ReadLine();
                    break;
                    
                case opciones.BUSCAR_TIPO:
                    JuegosPorTipo(listaJuegos, cantidad);
                    break;
                    
                case opciones.BUSCAR_TITULO:
                    JuegosPorTitulo(listaJuegos, cantidad);
                    break;
            
                case opciones.SALIR:
                    Console.WriteLine("Fin del programa.");
                    break;
                    
                default:
                    Console.WriteLine("Opción incorrecta.");
                    Console.WriteLine("Intro para continuar.");
                    Console.ReadLine();
                    break;
            }
        }
        while(opcion!=opciones.SALIR);
    }
}
