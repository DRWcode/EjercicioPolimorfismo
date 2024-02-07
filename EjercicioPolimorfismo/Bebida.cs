using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
     abstract class Bebida
    {
        // propiedad
        public string? Nombre {  get; set; }

        // Método abstracto para calcular el costo

        public abstract double CalcularCosto();

        // Método para mostrar información en pantalla

        public virtual void Info ()
        {
            Console.WriteLine($"Bebida: {Nombre}");
        }
    }
}
