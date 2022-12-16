Random random = new Random();
bool esIgual = true;

Console.WriteLine("Introduce un número entero: ");
int numero = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 5; i++)
{
    int numgenerado = random.Next(1, numero + 1);
    Console.WriteLine("\n" + numgenerado);
    if (esIgual)
    {
        if (numero == numgenerado)
        {
            Console.WriteLine("Este número es igual al número que ha introducido");
            esIgual = false;
        }
    }
}