using System;

namespace SistemaPrestamos.Models
{
    public class Pago
    {
        public int PagoId { get; set; }
        public int PrestamoId { get; set; }

        public DateTime FechaPago { get; set; } = DateTime.Now;
        public decimal MontoAnterior { get; set; }
        public decimal InteresPagado { get; set; }
        public decimal MontoAbonado { get; set; }
        public decimal NuevoMonto { get; set; }

        public bool FuePagoDelMes { get; set; } = true;
    }
}