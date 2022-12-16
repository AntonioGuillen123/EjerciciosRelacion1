namespace Ejercicio_28
{
    class Program
    {
        enum Formas { Circulo, Cuadrado, Triangulo}

        static void Main(string[] args)
        {
            Console.WriteLine("Elige una figura para calcular su área (Círculo, Cuadrado, Triángulo): ");
            Formas formas = (Formas)Enum.Parse(typeof(Formas), Console.ReadLine(), true);

            switch(formas)
            {
                case Formas.Circulo:
                    Console.WriteLine("\nIntroduce el radio para calcular el área de un Círculo: ");
                    double radio = double.Parse(Console.ReadLine());
                    double areaCirculo = AreaCirculo(radio);

                    Console.WriteLine($"\nEl área del Círculo es: {areaCirculo}");
                    break;

                case Formas.Cuadrado:
                    Console.WriteLine("\nIntroduce 2 lados de un Cuadrado para calcular su área: ");
                    double ladoA = double.Parse(Console.ReadLine());
                    double ladoB = double.Parse(Console.ReadLine());
                    double areaCuadrado = AreaCuadrado(ladoA, ladoB);

                    Console.WriteLine($"\nEl área del Cuadrado es: {areaCuadrado}");
                    break;

                default:
                    Console.WriteLine("\nIntroduce la base y la altura para calcular el área de un Triángulo: ");
                    double @base = double.Parse(Console.ReadLine());
                    double altura = double.Parse(Console.ReadLine());
                    double areaTriangulo = AreaTriangulo(@base, altura);

                    Console.WriteLine($"\nEl área del Triángulo es: {areaTriangulo}");
                    break;
            }
        }

        static double AreaCirculo(double numero)
        {
            double area = Math.Pow(numero, 2) * Math.PI;
            return area;
        }

        static double AreaCuadrado(double numero1, double numero2)
        {
            double area = numero1 * numero2;
            return area;
        }

        static double AreaTriangulo(double numero1, double numero2)
        {
            double area = numero1 * numero2 / 2;
            return area;
        }
    }
}