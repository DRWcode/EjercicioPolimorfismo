using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPolimorfismo
{
    internal class CafeConLeche : Cafe
    {
        // Propiedades
        public double PrecioLeche { get; set; }

        // Sobrescritura del método  CalcularCosto
        public override double CalcularCosto()
        {
            return PrecioBase + PrecioLeche;
        }

        // Sobrescritura del método  Info
        public override void Info()
        {
            base.Info();
            Console.WriteLine($"Precio Leche: Lps.{PrecioLeche:0.00}");
        }
    }
}
