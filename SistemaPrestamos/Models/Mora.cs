using System;

namespace SistemaPrestamos.Models
{
    public class Mora
    {
        public int MoraId { get; set; }
        public int PrestamoId { get; set; }

        public DateTime Fecha { get; set; } = DateTime.Now;
        public decimal MontoMora { get; set; }
    }
}