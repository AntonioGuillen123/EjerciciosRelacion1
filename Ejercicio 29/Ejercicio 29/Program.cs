namespace Ejercicio_29
{
    class Program
    {
        enum Moneda { Dolares, Yenes, Libras}

        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la cantidad de Euros que desea convertir: ");
            double euros = double.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca la moneda a la que desea hacer la conversión (Dólares, Yenes, Libras): ");
            string eleccion = Console.ReadLine();
            Moneda moneda = (Moneda)Enum.Parse(typeof(Moneda), eleccion, true);

            if (moneda == Moneda.Dolares)
            {
                MetodoDolares(euros, eleccion);
            }
            else if (moneda == Moneda.Yenes)
            {
                MetodoYenes(euros, eleccion);
            }
            else
            {
                MetodoLibras(euros, eleccion);
            }
        }

        static void MetodoDolares(double euros, string moneda)
        {
            const double DOLAR = 1.28611;
            double dolares = euros * DOLAR;
            Console.WriteLine($"\n{euros} Euros en {moneda} es: {dolares}");
        }

        static void MetodoYenes(double euros, string moneda)
        {
            const double YENES = 129.852;
            double yenes = euros * YENES;
            Console.WriteLine($"\n{euros} Euros en {moneda} es: {yenes}");
        }

        static void MetodoLibras(double euros, string moneda)
        {
            const double LIBRA = 0.86;
            double libras = euros * LIBRA;
            Console.WriteLine($"\n{euros} Euros en {moneda} es: {libras}");
        }
    }
}