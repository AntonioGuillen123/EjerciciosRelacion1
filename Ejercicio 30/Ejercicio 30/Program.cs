namespace Ejercicio30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero entero");
            int filas = int.Parse(Console.ReadLine());
            for (int i = 1; i <= filas; i++)
            {
                int spaces = filas - i;
                Console.Write(new string(' ', spaces));
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(Combinatorio(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
        static int Combinatorio(int m, int n)
        {
            return Factorial(m) / (Factorial(n) * Factorial(m - n));
        }
        static int Factorial(int n)
        {
            int fact;

            if (n <= 1)
            {
                fact = 1;
            }
            else
            {
                fact = n * Factorial(n - 1);
            }

            return fact;

        }
    }
}