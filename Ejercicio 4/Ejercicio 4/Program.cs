/*Console.WriteLine("Introduce un número entero: ");
int num = Convert.ToInt32(Console.ReadLine());
string resultado = Convert.ToString(num);

Console.WriteLine(resultado.Substring(resultado.Length - 1));*/

//También se puede hacer de la siguiente manera

Console.WriteLine("Introduce un número entero:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(num % 10);