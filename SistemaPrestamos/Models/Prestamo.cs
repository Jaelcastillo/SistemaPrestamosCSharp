using System;

namespace SistemaPrestamos.Models
{
    public class Prestamo
    {
        public int PrestamoId { get; set; }
        public int ClienteId { get; set; }

        public decimal Monto { get; set; }
        public int Meses { get; set; }

        public decimal TasaAnual { get; set; }
        public decimal InteresGenerado { get; set; }
        public decimal MontoTotal { get; set; }
        public decimal CuotaMensual { get; set; }
        public decimal SaldoActual { get; set; }

        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public bool EstaActivo { get; set; } = true;
    }
}