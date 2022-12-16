Console.WriteLine("Introduzca una palabra: ");
string palabra = Console.ReadLine();

bool esPalindromo = true;
int inicio = 0;
int final = palabra.Length - 1;

for (int i = 0; i < palabra.Length; i++)
{
	if (palabra[inicio] == palabra[final])
	{
		inicio++;
		final--;
	}
	else
	{
		esPalindromo = false;
	}
}

if (esPalindromo)
{
	Console.WriteLine("La palabra que ha introducido es Palíndromo");
}
else
{
	Console.WriteLine("La palabra que ha indroducido no es Palíndromo");
}