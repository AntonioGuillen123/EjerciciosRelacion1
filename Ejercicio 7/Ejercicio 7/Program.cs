using System;

Console.WriteLine("Introduce 3 números enteros:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a == b && a == c && b == c)
{
    Console.WriteLine("Es un triángulo Equilátero");
}
else if (a != b && a != c && b != c)
{
    Console.WriteLine("Es un triángulo Escaleno");
}
else
{
    Console.WriteLine("Es un triángulo Isósceles");
}