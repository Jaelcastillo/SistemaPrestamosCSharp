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

        // Cuota mensual (Sistema Francés)
        public double CalcularCuotaMensual(double capital, double tasaAnual, int meses)
        {
            double tasaMensual = tasaAnual / 12;

            double cuota = capital *
                          (tasaMensual * Math.Pow(1 + tasaMensual, meses)) /
                          (Math.Pow(1 + tasaMensual, meses) - 1);

            return cuota;
        }

        // Mora (10% de la cuota)
        public double CalcularMora(double cuota)
        {
            return cuota * 0.10;
        }

    }
}


