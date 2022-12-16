namespace Ejercicio_20
{
    class Program
    {
        enum MonthsOfYear
        {
            Enero = 1, Febrero, Marzo, Abril, Mayo, Junio,
            Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero del 1 al 12");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 12 || numero < 1)
            {
                Console.WriteLine("\nEl número que ha introducido no es válido"); 
            }
            else
            {
                Console.WriteLine($"\nEl número {numero} corresponde con este mes: {(MonthsOfYear)numero}");
            }
        }
    }
}