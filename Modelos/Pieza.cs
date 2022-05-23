using System;
using System.Collections.Generic;

#nullable disable

namespace webAPI.Modelos
{
    public partial class Pieza
    {
        public Pieza()
        {
            MaterialPiezas = new HashSet<MaterialPieza>();
            OrdenesProduccionDetalles = new HashSet<OrdenesProduccionDetalle>();
        }

        public int Codigo { get; set; }
        public int? MarcaId { get; set; }
        public string Descripcion { get; set; }
        public int CodigoFabricacion { get; set; }
        public int? MatrizId { get; set; }
        public int? MaterialId { get; set; }
        public int Peso { get; set; }
        public int Bocas { get; set; }
        public int TiempoDeInyeccion { get; set; }
        public string PresionInyeccion { get; set; }
        public string VelocidadInyeccion { get; set; }
        public int Curado { get; set; }
        public int Carga { get; set; }
        public int Calefaccion { get; set; }
        public string NoyoA { get; set; }
        public string PosicionApertura { get; set; }
        public int ProduccionPorHora { get; set; }

        public virtual Marca Marca { get; set; }
        public virtual Materiale Material { get; set; }
        public virtual Matrix Matriz { get; set; }
        public virtual ICollection<MaterialPieza> MaterialPiezas { get; set; }
        public virtual ICollection<OrdenesProduccionDetalle> OrdenesProduccionDetalles { get; set; }
    }
}
