namespace Ejercicio_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce dos números enteros: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"El resultado de la suma de las dos sucessiones Fibonacci es: {Fibonacci(a) /*+ Fibonacci(b)*/}");
        }

        static int Fibonacci(int numero)
        {
            int fibonacci;

            if (numero == 1)
            {
                fibonacci = 1;
            }
            else if (numero == 0)
            {
                fibonacci = 0;
            }
            else
            {
                fibonacci = Fibonacci( numero - 1 ) + Fibonacci( numero - 2 );
            }

            return fibonacci;

        }
    }
}