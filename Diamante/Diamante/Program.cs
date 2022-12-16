Console.Write("Introduzca el número de filas que desea: ");
int nº = Convert.ToInt32(Console.ReadLine());

int espacio = nº - 1;

for (int columnas = 1; columnas < nº; columnas++)
{
	for (int filas = 1; filas < espacio; filas++)
	{
		Console.Write(" ");
	}

	espacio--;

	for (int filas = 1; filas <= 2 * columnas - 1; filas++)
	{
		Console.Write("*");
	}

	Console.WriteLine();

}

espacio = 1;

for (int columnas = 1; columnas <= nº; columnas++)
{
	for (int filas = 1; filas < espacio; filas++)
	{
		Console.Write(" ");
	}

	espacio++;

	for (int filas = 1; filas <= 2 * (nº - columnas) - 1; filas++)
	{
		Console.Write("*");
	}

	Console.WriteLine();

}