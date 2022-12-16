namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un texto: ");
            string texto = Console.ReadLine();

            int contador = 0;
            char caracter;
            char caracter2;
            string letras = "";

            for (int i = 0; i < texto.Length; i++)
            {

                caracter = texto[i];

                for (int e = 0; e < texto.Length; e++)
                {

                    caracter2 = texto[e];

                    if (caracter == caracter2)
                    {
                        contador++;
                    }

                }

                if (!letras.Contains(texto[i]))
                {
                    letras += texto[i];
                    Console.WriteLine($"El caracter {caracter} aparece: {contador} veces");
                }

                contador = 0;

            }
        }
    }
}