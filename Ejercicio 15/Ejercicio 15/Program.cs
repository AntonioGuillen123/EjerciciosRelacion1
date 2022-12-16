Console.WriteLine("Introduce un número entero que indique cuantos números poner: ");
int numero = Convert.ToInt32(Console.ReadLine());
double num;
double media = 0;

Console.WriteLine("\nIntroduce " + numero + " números");

for (int i = 0; i < numero; i++)
{
    num = Convert.ToDouble(Console.ReadLine());
    media += num;
}

Console.WriteLine("\nLa media de los números que ha introducido es: " + (media / numero));