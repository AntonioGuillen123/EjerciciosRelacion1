using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Introduce el primer número real: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Introduce el segundo número real: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double resultado = num1 + num2;

Console.WriteLine("\nEl resultado de la suma es: " + resultado);