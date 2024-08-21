// Declaración de variables
double peso, altura, imc;

// Solicitar datos al usuario
Console.WriteLine("Ingrese el peso en kilogramos:");
peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la altura en metros:");
altura = Convert.ToDouble(Console.ReadLine());

// Calcular el IMC
imc = peso / (altura * altura);

// Mostrar el IMC calculado
Console.WriteLine($"Su imc es: {imc:F}");