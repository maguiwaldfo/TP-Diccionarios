namespace TP_Diccionario;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string , int> dicRecursos = new Dictionary<string , int>();

        AgregarRecurso("madera", 40 , dicRecursos);
        AgregarRecurso("hierro" , 80 , dicRecursos);
        AgregarRecurso("Soga" , 10 , dicRecursos); 
    }
    public void AgregarRecurso(string recurso , int cantidad , Dictionary<string , int> dicRecursos)
    {
        bool esta = dicRecursos.ContainsKey(recurso); 
        if (esta == false)
        {
            dicRecursos.Add(recurso , cantidad)
        }
        else 
        {
            Console.WriteLine("Recurso existente")
        }
    }
}
