namespace Ejercicio_31
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[100];
            int contador = 1;
            int suma = 0;

            for (int i = 0; i < 100; i++)
            {
                numeros[i] = contador;
                contador++;

                suma += numeros[i];
            }

            Console.WriteLine($"La suma de todas las posiciones del array es: {suma}");
            Console.WriteLine($"\nLa media de todas las posiciones del array es: {suma / numeros.Length}");

        }
    }
}