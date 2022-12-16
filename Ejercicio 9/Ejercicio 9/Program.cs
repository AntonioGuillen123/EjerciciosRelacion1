Console.WriteLine("Introduce uno de los siguientes caracteres para mostrar dicho estado civil: ");
Console.WriteLine("C");
Console.WriteLine("S");
Console.WriteLine("V");
Console.WriteLine("D");
char caracter = Convert.ToChar(Console.ReadLine());
string comprobacion = Convert.ToString(caracter);
comprobacion = comprobacion.ToUpper();

switch (comprobacion)
{
	case "C":
		Console.WriteLine("El estado civil es CASAD@");
		break;

	case "S":
		Console.WriteLine("El estado civil es SOLTER@");
		break;

	case "V":
        Console.WriteLine("El estado civil es VIUD@");
		break;

	case "D":
		Console.WriteLine("El estado civil es DIVORCIAD@");
		break;

	default:
		Console.WriteLine("\nEl operador que ha introducido no es válido");
		break;
}