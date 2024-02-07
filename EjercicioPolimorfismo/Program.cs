
using EjercicioPolimorfismo;

// Crear instancias de Cafe y CafeConLeche
Cafe cafe = new Cafe { Nombre = "Café Americano", Descafeinado = false, PrecioBase = 15 };
CafeConLeche cafeConLeche = new CafeConLeche { Nombre = "Café Latte", Descafeinado = true, PrecioBase = 15, PrecioLeche = 5 };

// Llamar al método Info para mostrar la información de cada bebida
cafe.Info();
Console.WriteLine();
cafeConLeche.Info();