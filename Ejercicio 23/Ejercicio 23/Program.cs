namespace Ejercicio_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce dos números enteros: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            if (num2 == 0)
            {
                throw new Exception("Error, no se puede dividir entre 0");
            }

            Console.WriteLine($"El resultado de la división es: {num1 / num2}");

        }
    }
}