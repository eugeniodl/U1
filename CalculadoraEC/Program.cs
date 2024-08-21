// Declaración de variables
double masa, velocidad, energiaCinetica;

// Solicitar la masa y la velocidad
Console.WriteLine("Ingrese la masa del objeto en kilogramos:");
masa = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la velocidad del objeto en metros por segundo:");
velocidad = Convert.ToDouble(Console.ReadLine());

// Calcular la energía cinética
energiaCinetica = 1.0 / 2.0 * masa * Math.Pow(velocidad, 2);

// Mostrar el resultado de la energía cinética
Console.WriteLine($"La energía cinética del objeto es: {energiaCinetica:F2} joules");
