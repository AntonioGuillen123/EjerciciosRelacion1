using System;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero en base 10: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce un número que indique la base a la que lo quiere transformar: ");
            int @base = int.Parse(Console.ReadLine());

            if (@base > 9 || @base < 2)
            {
                Console.WriteLine("El número que ha introducido no es válido");
            }
            else
            {
                int cociente = numero / @base;
                string resto = Convert.ToString(numero % @base);
                
                
                while (cociente >= @base)
                {

                    if (cociente > @base)
                    {
                        resto += Convert.ToString(cociente % @base);
                        cociente /= @base;
                    }
                    else
                    {
                        resto += Convert.ToString(cociente % @base);
                        resto += Convert.ToString(cociente / @base);
                        cociente /= @base;
                    }
                    
                }

                int longitud = resto.Length - 1;
                string final = "";

                for (int i = 0; i < resto.Length; i++)
                {
                    final += resto[longitud];
                    longitud--;
                }
                
                Console.Write(final);
            }
        }
    }
}