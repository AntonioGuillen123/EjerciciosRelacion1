namespace Ejercicio_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número entero: ");
            int n = int.Parse(Console.ReadLine());
            int fact = 0;

            for (int i = 1; i <= n; i++)
            {
                fact += Factorial(i) + i;
            }

            Console.WriteLine($"\nEl resultado es: {fact}");
        }

        static int Factorial(int numero)
        {
            int fact;

            if (numero <= 1)
            {
                fact = 1;
            }
            else
            {
                fact = numero * Factorial( numero - 1);
            }

            return fact;

        }
    }
}