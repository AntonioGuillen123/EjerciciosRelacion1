namespace Ejercicio_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una lista de números enteros separados por comas: ");
            string list = Console.ReadLine();

            string[] texto = list.Split(',');

            int[] numeros = new int[texto.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(texto[i]);

                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine(numeros[i]);
                }
            }
        }
    }
}