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

        // Cálculo de interés simple
        // Fórmula: I = P * r * t
        public double CalcularInteresSimple(double prestamo, double tasaAnual, int meses)
        {
            double tiempoAnios = meses / 12.0;
            return prestamo * tasaAnual * tiempoAnios;
        }

        // Cálculo del monto total a pagar
        public double CalcularMontoTotal(double prestamo, double interes)
        {
            return prestamo + interes;
        }

        // Cálculo de cuota mensual (Sistema Francés)
        public double CalcularCuotaMensual(double prestamo, double tea, int meses)
        {
            double tem = CalcularTEM(tea);
            double potencia = Math.Pow(1 + tem, meses);

            return prestamo * (tem * potencia) / (potencia - 1);
        }

        // Cálculo de mora (10% de la cuota)
        public double CalcularMora(double cuota)
        {
            return cuota * 0.10;
        }
    }
}

