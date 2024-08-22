// Declaración de variables
double peso;
double altura;
double imc;

// Solicitar datos al usuario
Console.WriteLine("Ingrese su peso en kilogramos");
peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese su altura en metros");
altura = Convert.ToDouble(Console.ReadLine());

// Calcular el IMC
imc = peso / (altura * altura);

// Mostrar el IMC calculado
Console.WriteLine($"Su IMC es: {imc:F2}");

// Determinar el rango del IMC
if(imc < 18.5)
{
    Console.WriteLine("Peso bajo.");
}
else if(imc >= 18.5 && imc <= 24.9)
{
    Console.WriteLine("Peso normal.");
}
else
{
    Console.WriteLine("Sobrepeso.");
}




Console.ReadLine();