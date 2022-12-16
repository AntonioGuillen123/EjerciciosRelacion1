Console.WriteLine("Introduce un número entero de dos cifras:");
int numero = Convert.ToInt32(Console.ReadLine());
string cadenanumero = Convert.ToString(numero);


if (cadenanumero.Length == 2)
{
    int decenas = numero / 10;
    int unidades = numero % 10;
    int numeroinvertido = unidades * 10 + decenas;

    Console.WriteLine("\nEl número que ha introducido invertido es: " + numeroinvertido);
}
else
{
    Console.Error.WriteLine("\nEl número que ha introducido no es válido");
}
