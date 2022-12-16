Console.WriteLine("Introduce un número entero: ");
int numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nLos números divisibles por 2 y 3 dentro del rango son los siguientes: ");

for (int i = 1; i <= numero; i++)
{
    if (i % 2 == 0 && i % 3 == 0)
	{
		Console.WriteLine(i);
	}
}