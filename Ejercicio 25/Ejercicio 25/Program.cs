namespace Ejercicio_25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce 2 números enteros: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            n = Factorial(n);
            m = Factorial(m);

            Console.WriteLine($"El resultado de la operación es: { n - m }");
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
                fact = numero * Factorial( numero - 1 );
            }

            return fact;
        }
    }
}