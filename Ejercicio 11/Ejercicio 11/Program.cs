Console.WriteLine("Introduzca un número entero: ");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= numero; i++)
{
	int comprobacion = 2;
	bool esPrimo = true;

	while (esPrimo && comprobacion < i)
	{
        if (i % comprobacion == 0)
        {
            esPrimo = false;
        }
        else
        {
            comprobacion++;
        }
    }

    if (esPrimo)
    {
        Console.WriteLine("\n" + i + " Es primo");
    }
}