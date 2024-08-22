// Declaración de variables
double masa;
double velocidad;
double energiaCinetica;

try
{
	// Solicitar la masa y la velocidad
	Console.WriteLine("Ingrese la masa del objeto en kilogramos:");
	masa = Convert.ToDouble(Console.ReadLine());

	if (masa <= 0 )
	{
        Console.WriteLine("La masa debe ser un valor positivo.");
		return;
    }

	Console.WriteLine("Ingrese la velocidad del objeto en metros por segundo:");
	velocidad = Convert.ToDouble(Console.ReadLine());

	if( velocidad < 0 )
	{
        Console.WriteLine("La velocidad no puede ser negativa.");
		return;
    }

	// Calcular la energía cinética
	energiaCinetica = 1.0 / 2.0 * masa * Math.Pow(velocidad, 2);

	// Mostrar el resultado de la energía cinética
	Console.WriteLine($"La energía cinética del objeto es: {energiaCinetica:F} joules");

}
catch (FormatException)
{
    Console.WriteLine("Por favor, ingrese un número válido.");
}