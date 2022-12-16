Console.WriteLine("Introduce un número para la semilla: ");
int seed = Convert.ToInt32(Console.ReadLine());

Random random = new Random(seed);

Console.WriteLine("Introduce la cantidad de caracteres que quiere generar: ");
int cantidad = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < cantidad; i++)
{
    char caracter = Convert.ToChar(random.Next(0, 256));
    Console.Write(caracter);
}