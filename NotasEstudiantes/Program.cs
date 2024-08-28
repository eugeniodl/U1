// Declaración e inicialización de una matriz de notas
double[,] notas =
{
    { 85, 90, 88},
    { 78, 84, 82},
    { 92, 89, 94},
    { 70, 75, 73}
};

// Variables para almacenar los promedios
double[] promedioEstudiantes = new double[notas.GetLength(0)];
double sumaGeneral = 0;

// Recorre la matriz para calcular los promedios
for (int i = 0; i < notas.GetLength(0); i++)
{
    double sumaEstudiante = 0;
    for (int j = 0; j < notas.GetLength(1); j++)
    {
        sumaEstudiante += notas[i, j];
    }
    promedioEstudiantes[i] = sumaEstudiante 
        / notas.GetLength(1);
    sumaGeneral += promedioEstudiantes[i];
}

// Cálculo del promedio general de la clase
double promedioGeneral = sumaGeneral / notas.GetLength(0);

// Muestra los promedios de cada estudiante
for (int i = 0; i < promedioEstudiantes.Length; i++)
{
    Console.WriteLine($"Promedio del Estudiante {i + 1} :" +
        $"{promedioEstudiantes[i]:0.00}");
}
// Muestra el promedio general de la clase
Console.WriteLine($"Promedio General de la Clase: " +
    $"{promedioGeneral:0.00}");