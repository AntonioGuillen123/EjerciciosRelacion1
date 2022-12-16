namespace Ejercicio_21
{
    internal class Program
    {
        enum DaysOfWeek { Lunes = 1, Martes, Miércoles, Jueves, Viernes, Sabado, Domingo }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un día de la semana para ver si es laboral o no: ");
            DaysOfWeek dia = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Console.ReadLine(), true);

            int numero = (int)dia;
             
            if (numero > 0 && numero < 6)
            {
                Console.WriteLine($"El día {dia} es laboral");
            }
            else
            {
                Console.WriteLine($"El día {dia} es no laboral");
            }
        }

    }
}