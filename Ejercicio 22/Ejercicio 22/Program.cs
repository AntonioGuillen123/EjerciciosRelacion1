namespace Ejercicio_22
{
    class Program
    {
        enum estados { ON, OFF}

        static void Main(string[] args)
        {
            estados estado = estados.OFF;

            while (true)
            {
                Console.WriteLine($"\nEl estado de la lámpara es {estado} ");
                Console.WriteLine("Introduce un nuevo estado: ");
                string eleccion = Console.ReadLine();
                estados eleccionEstado = (estados)Enum.Parse(typeof(estados), eleccion, true);

                if (eleccionEstado == estado)
                {
                    throw new Exception($"\nError, la lámpara ya estaba: {estado}");
                }
                else
                {
                    estado = (estados)Enum.Parse(typeof(estados), eleccion);
                }
            }
        }
    }
}