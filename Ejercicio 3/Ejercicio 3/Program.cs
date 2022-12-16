Console.WriteLine("Introduzca una temperatura en grados Fahrenheit: ");
double Fº = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Esta es la temperatura en grados Celsius: " + (Fº - 32) * 5 / 9);