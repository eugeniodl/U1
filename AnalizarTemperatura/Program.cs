// Declaración e inicialización del arreglo con temperaturas
double[] temperaturas = { 23.5, 25.3, 21.8, 22.7, 24.6,
26.1, 23.9};

// Variables para almacenar la temperatura máxima, mínima 
// y la suma para el promedio
double maxTemp = temperaturas[0];
double minTemp = temperaturas[0];
double suma = 0;

// Recorre el arreglo para encontrar la temperatura máxima,
// mínima y calcular la suma
foreach (double t in temperaturas)
{
    if (t > maxTemp)
        maxTemp = t;
    if (t < minTemp)
        minTemp = t;
    suma += t;
}

// Cálculo del promedio
double promedio = suma / temperaturas.Length;

// Muestra los resultados
Console.WriteLine($"Temperatura Mínima: {minTemp}ºC");
Console.WriteLine($"Temperatura Máxima: {maxTemp}ºC");
Console.WriteLine($"Temperatura Promedio: {promedio:F1}ºC");