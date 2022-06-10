using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class AccesoriosDbContext : DbContext
    {
        public AccesoriosDbContext()
        {
        }

        public AccesoriosDbContext(DbContextOptions<AccesoriosDbContext> options)
            : base(options)
        {
           //Database.EnsureCreated();
        }
 
        public virtual DbSet<Deposito> Depositos { get; set; }
        public virtual DbSet<EstadosProduccion> EstadosProduccion { get; set; }
        public virtual DbSet<Inyectora> Inyectoras { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<MaterialPieza> MaterialPiezas { get; set; }
        public virtual DbSet<Material> Materiales { get; set; }
        public virtual DbSet<Matriz> Matrices { get; set; }
        public virtual DbSet<Operario> Operarios { get; set; }
        public virtual DbSet<OrdenesProduccionCabecera> OrdenesProduccionCabeceras { get; set; }
        public virtual DbSet<OrdenesProduccionDetalle> OrdenesProduccionDetalles { get; set; }
        public virtual DbSet<Pieza> Piezas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /*clave compuesta*/
            modelBuilder.Entity<MaterialPieza>()
                .HasKey(c => new { c.PiezaId, c.MaterialId });

            modelBuilder.Entity<OrdenesProduccionDetalle>()
                .HasKey(c => new { c.PiezaId, c.OrdenProduccionCabeceraId });
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
