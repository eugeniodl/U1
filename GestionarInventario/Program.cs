// Declaración e inicialización del arreglo 
// con cantidades de productos
int[] inventario = { 50, 20, 0, 15, 30 };

// Reabastecimiento de un producto (por ejemplo,
// el tercer producto)
inventario[2] = 25;

// Verificar si algún producto necesita reabastecimiento
// (cantidad < 10)
for (int i = 0; i < inventario.Length; i++)
{
    if (inventario[i] < 10)
    {
        Console.WriteLine($"Producto {i + 1} necesita " +
            $"rebastecimiento. " +
            $"Cantidad actual: {inventario[i]}");
    }
}