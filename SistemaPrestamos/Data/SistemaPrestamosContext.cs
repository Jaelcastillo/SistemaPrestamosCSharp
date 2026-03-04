using SistemaPrestamos.Models;
using System.Data.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaPrestamos.Data
{
    public class SistemaPrestamosContext : DbContext
    {
        public SistemaPrestamosContext() : base("name=SistemaPrestamosDB")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Pago> Pagos { get; set; }
        public DbSet<Mora> Moras { get; set; }
    }
}