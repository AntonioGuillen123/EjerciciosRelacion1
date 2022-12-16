namespace Ejercicio_35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] tabla = new char[] { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B',
                'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };

            Console.WriteLine("Introduzca un DNI sin la letra: ");
            int numero = int.Parse(Console.ReadLine());

            char letraDNI = LetraDNI(tabla,numero);

            Console.WriteLine($"\nEl DNI entero es: {numero}{letraDNI}");
        }

        static char LetraDNI(char[] array, int numero)
        {
            int resto = numero % 23;

            char letraDNI = array[resto];

            return letraDNI;
        }
    }
}