namespace Ejercicio_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una lista de números enteros separados por comas");
            string list = Console.ReadLine();

            string[] texto = list.Split(',');
            int[] numeros = new int[texto.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(texto[i]);
            }
            
            int higher = numeros[0];
            int lower = numeros[0];

            foreach (int position in numeros)
            {
                if (position > higher)
                {
                    higher = position;
                }else if (position < lower)
                {
                    lower = position;
                }
            }

            Console.WriteLine($"El número más pequeño de los que ha introducido es: {lower}");
            Console.WriteLine($"El número más grande de los que ha introducido es: {higher}");
        }
    }
}