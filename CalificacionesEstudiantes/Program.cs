// Declaración e inicialización
// de una matriz de calificaciones
double[,] calificaciones =
{
    { 85, 90, 88 },
    { 78, 84, 82 },
    { 92, 89, 94 },
    { 70, 75, 73 }
};

// Variables para almacenar los promedios
double[] promediosEstudiantes = 
    new double[calificaciones.GetLength(0)];
double sumaGeneral = 0;

// Recorre la matriz para calcular los promedios
for (int i = 0; i < calificaciones.GetLength(0); i++)
{
    double sumaEstudiante = 0;
    for (int j = 0; j < calificaciones.GetLength(1); j++)
    {
        sumaEstudiante += calificaciones[i, j];
    }
    promediosEstudiantes[i] = sumaEstudiante / 
        calificaciones.GetLength(1);
    sumaGeneral += promediosEstudiantes[i];
}

// Cálculo del promedio general de la clase
double promedioGeneral = sumaGeneral / 
    calificaciones.GetLength(0);

// Muestra los promedios de cada estudiante
for (int i = 0; i < promediosEstudiantes.Length; i++)
{
    Console.WriteLine($"Promedio del Estudiante {i + 1}:" +
        $" {promediosEstudiantes[i]:0.00}");
}

// Muestra el promedio general de la clase
Console.WriteLine($"Promedio General de la Clase: " +
    $"{promedioGeneral:0.00}");