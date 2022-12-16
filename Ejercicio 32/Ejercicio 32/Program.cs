namespace Ejercicio_32
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SIZE = 10;

            int[] numeros = new int[SIZE];

            Rellenar(numeros);

            Console.Clear();
            
            Mostrar(numeros);
        }

        static void Rellenar(int[] array)
        {
            Console.WriteLine("Introduce 10 números para introducirlos en el array: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }

        static void Mostrar(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"\nLa posición {i} del array corresponde con el número {array[i]}");
            }
        }
    }
}