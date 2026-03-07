using System;

namespace SistemaPrestamos.Services
{
    public class PrestamoService
    {
        // Obtener tasa de interés según los meses
        public double ObtenerTasaInteres(int meses)
        {
            if (meses <= 12)
                return 0.1325; // 13.25%

            if (meses <= 24)
                return 0.15; // 15%

            return 0.30; // 30%
        }

        // Interés simple: I = P * r * t
        public double CalcularInteresSimple(double capital, double tasa, double tiempo)
        {
            return capital * tasa * tiempo;
        }

        // Interés compuesto: A = P (1 + r/n)^(nt)
        public double CalcularInteresCompuesto(double capital, double tasa, int n, double tiempo)
        {
            return capital * Math.Pow((1 + tasa / n), n * tiempo);
        }

    }
}


