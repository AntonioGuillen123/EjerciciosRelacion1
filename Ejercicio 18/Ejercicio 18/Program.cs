namespace Ejercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero que indique cuantos números poner: ");
            int cantidad = int.Parse(Console.ReadLine());
            double numero;
            double media = 0;
            double resultado;

            Console.WriteLine($"\nIntroduce {cantidad} números: ");

            for (int i = 0; i < cantidad; i++)
            {
                numero = double.Parse(Console.ReadLine());
                media += Math.Pow(numero, 2);
            }

            media /= cantidad;
            resultado = Math.Sqrt(media);

            Console.WriteLine($"La media cuadrática de los números que ha introducido es: {resultado}");

        }
    }
}