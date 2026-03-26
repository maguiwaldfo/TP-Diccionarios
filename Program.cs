namespace TP_Diccionario;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string , int> dicRecursos = new Dictionary<string , int>();

        AgregarRecurso("madera", 40 , dicRecursos);
        AgregarRecurso("hierro" , 80 , dicRecursos);
        AgregarRecurso("Soga" , 10 , dicRecursos); 
        int x = MostrarMenu();
        while (x != 4)
        {
            switch (x)
            {
                case 0:
                    string recurso = IngresarString("Ingrese el nombre del recurso");
                    int cantidad = IngresarInt("Ingrese la cantidad del recurso");
                    AgregarRecurso(recurso , cantidad , dicRecursos);
                    break;
                case 1:
                    string recursoModificar = IngresarString("Ingrese el nombre del recurso a modificar");
                    bool esta = dicRecursos.ContainsKey(recursoModificar);
                    if (esta == true)
                    {
                        int cantidadModificar = IngresarInt("Ingrese la nueva cantidad del recurso");
                        dicRecursos[recursoModificar] = cantidadModificar;
                    }
                    else
                    {
                        Console.WriteLine("Recurso no encontrado");
                    }
                    break;
                case 2:
                    string recursoEliminar = IngresarString("Ingrese el nombre del recurso a eliminar");
                    bool estaEliminar = dicRecursos.ContainsKey(recursoEliminar);
                    if (estaEliminar == true)
                    {
                        dicRecursos.Remove(recursoEliminar);
                    }
                    else
                    {
                        Console.WriteLine("Recurso no encontrado");
                    }
                    break;
                case 3:
                    foreach (KeyValuePair<string , int> recursoCantidad in dicRecursos)
                    {
                        Console.WriteLine("Recurso: " + recursoCantidad.Key + " - Cantidad: " + recursoCantidad.Value);
                    }
                    break;
                default:
                    Console.WriteLine("Opción inválida");
                    break;
            }
            x = MostrarMenu();
        }


    }
    private static void AgregarRecurso(string recurso , int cantidad , Dictionary<string , int> dicRecursos)
    {
        bool esta = dicRecursos.ContainsKey(recurso); 
        if (esta == false)
        {
            dicRecursos.Add(recurso , cantidad);
        }
        else 
        {
            Console.WriteLine("Recurso existente");
        }
    }

    private static string IngresarString(string mensaje)
    {
        Console.WriteLine(mensaje);
        return Console.ReadLine();
    }
    private static int IngresarInt(string mensaje)
    {
        Console.WriteLine(mensaje);
        return int.Parse(Console.ReadLine());
    }
    private static int MostrarMenu()
    {
        Console.WriteLine("0- Agregar recurso");
        Console.WriteLine("1- Modificar recurso");
        Console.WriteLine("2- Eliminar recurso");
        Console.WriteLine("3- Mostrar recursos");
        Console.WriteLine("4- Salir");
        return int.Parse(Console.ReadLine());
    }

}
