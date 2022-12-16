namespace Ejercicio_36
{    
    //MAESTRO SI VES ESTO QUE SEPAS QUE CUANDO LO SAQUÉ CASI LLORO. PD: ME TOMÉ UN CHUPITO A TU SALUD
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce una lista de números enteros separados por comas: ");
            string[] arrayString = Console.ReadLine().Split(',');

            int[] numeros = new int[arrayString.Length];

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = int.Parse(arrayString[i]);
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                int valor;
                int contador = 0;

                for (int j = 1; j < numeros.Length; j++)
                {
                    if (numeros[contador] > numeros[j])
                    {
                        valor = numeros[contador];
                        numeros[contador] = numeros[j];
                        numeros[j] = valor;
                    }
                    contador++;
                }
            }

            Console.WriteLine("\nLa lista de números que ha introducido ordenada de menor a mayor es la siguiente: ");

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"{numeros[i]} ");
            }
        }
    }
}