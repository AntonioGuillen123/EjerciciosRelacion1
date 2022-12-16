namespace Ejercicio_38
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] numeros = new int[10];

            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = random.Next();
            }

            for (int i = 1; i < numeros.Length; i+=2)
            {
                Console.WriteLine($"Este es el número que hay en la posición {i}: {numeros[i]}");
            }
        }
    }
}