using System;

namespace SistemaPrestamos.Services
{
    public class PrService
    {
        // Conversión de Tasa Efectiva Anual (TEA) a Tasa Efectiva Mensual (TEM)
        // Fórmula: TEM = (1 + TEA)^(1/12) - 1
        public double CalcularTEM(double tea)
        {
            return Math.Pow(1 + tea, 1.0 / 12.0) - 1;
        }
    }
}

