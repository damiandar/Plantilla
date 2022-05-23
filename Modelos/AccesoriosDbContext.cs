using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace webAPI.Modelos
{
    public partial class AccesoriosDbContext : DbContext
    {
        public AccesoriosDbContext()
        {
        }

        public AccesoriosDbContext(DbContextOptions<AccesoriosDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Deposito> Depositos { get; set; }
        public virtual DbSet<EstadosProduccion> EstadosProduccions { get; set; }
        public virtual DbSet<Inyectora> Inyectoras { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<MaterialPieza> MaterialPiezas { get; set; }
        public virtual DbSet<Materiale> Materiales { get; set; }
        public virtual DbSet<Matrix> Matrices { get; set; }
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
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<EstadosProduccion>(entity =>
            {
                entity.ToTable("EstadosProduccion");
            });

            modelBuilder.Entity<MaterialPieza>(entity =>
            {
                entity.HasKey(e => new { e.MaterialId, e.PiezaId });

                entity.ToTable("MaterialPieza");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.MaterialPiezas)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialPieza_Materiales");

                entity.HasOne(d => d.Pieza)
                    .WithMany(p => p.MaterialPiezas)
                    .HasForeignKey(d => d.PiezaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MaterialPieza_Piezas");
            });

            modelBuilder.Entity<Matrix>(entity =>
            {
                entity.HasIndex(e => e.DepositoId, "IX_Matrices_DepositoId");

                entity.HasOne(d => d.Deposito)
                    .WithMany(p => p.Matrices)
                    .HasForeignKey(d => d.DepositoId);
            });

            modelBuilder.Entity<OrdenesProduccionCabecera>(entity =>
            {
                entity.ToTable("OrdenesProduccionCabecera");

                entity.HasIndex(e => e.InyectoraId, "IX_OrdenesProduccionCabecera_InyectoraId");

                entity.HasOne(d => d.Inyectora)
                    .WithMany(p => p.OrdenesProduccionCabeceras)
                    .HasForeignKey(d => d.InyectoraId);
            });

            modelBuilder.Entity<OrdenesProduccionDetalle>(entity =>
            {
                entity.HasKey(e => new { e.PiezaCodigo, e.OrdenProduccionCabeceraId })
                    .HasName("PK_OrdenesProduccionDetalle_1");

                entity.ToTable("OrdenesProduccionDetalle");

                entity.HasIndex(e => e.EstadoId, "IX_OrdenesProduccionDetalle_EstadoId");

                entity.HasIndex(e => e.MatrizId, "IX_OrdenesProduccionDetalle_MatrizId");

                entity.HasIndex(e => e.OperarioId, "IX_OrdenesProduccionDetalle_OperarioId");

                entity.HasIndex(e => e.OrdenProduccionCabeceraId, "IX_OrdenesProduccionDetalle_OrdenProduccionCabeceraId");

                entity.HasIndex(e => e.PiezaCodigo, "IX_OrdenesProduccionDetalle_PiezaCodigo");

                entity.HasOne(d => d.Estado)
                    .WithMany(p => p.OrdenesProduccionDetalles)
                    .HasForeignKey(d => d.EstadoId);

                entity.HasOne(d => d.Matriz)
                    .WithMany(p => p.OrdenesProduccionDetalles)
                    .HasForeignKey(d => d.MatrizId);

                entity.HasOne(d => d.Operario)
                    .WithMany(p => p.OrdenesProduccionDetalles)
                    .HasForeignKey(d => d.OperarioId);

                entity.HasOne(d => d.OrdenProduccionCabecera)
                    .WithMany(p => p.OrdenesProduccionDetalles)
                    .HasForeignKey(d => d.OrdenProduccionCabeceraId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.PiezaCodigoNavigation)
                    .WithMany(p => p.OrdenesProduccionDetalles)
                    .HasForeignKey(d => d.PiezaCodigo)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Pieza>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.HasIndex(e => e.MarcaId, "IX_Piezas_MarcaId");

                entity.HasIndex(e => e.MaterialId, "IX_Piezas_MaterialId");

                entity.HasIndex(e => e.MatrizId, "IX_Piezas_MatrizId");

                entity.Property(e => e.Codigo).ValueGeneratedNever();

                entity.HasOne(d => d.Marca)
                    .WithMany(p => p.Piezas)
                    .HasForeignKey(d => d.MarcaId);

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.Piezas)
                    .HasForeignKey(d => d.MaterialId);

                entity.HasOne(d => d.Matriz)
                    .WithMany(p => p.Piezas)
                    .HasForeignKey(d => d.MatrizId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
