using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class Cafe : Bebida 
    {
        public bool Descafeinado { get; set; }
        public double PrecioBase { get; set; }

        // inplementacion método abstracto
        public override double CalcularCosto()
        {
            return PrecioBase;
        }

        public override void Info()
        {
            String tipo = Descafeinado ? "Descafeinado" : "Normal";
            Console.WriteLine($"Café: {Nombre} ({tipo})");
            Console.WriteLine($"Costo: Lps{CalcularCosto():0.00}");
        }

    }
}
