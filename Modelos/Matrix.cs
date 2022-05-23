using System;
using System.Collections.Generic;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class Matrix
    {
        public Matrix()
        {
            OrdenesProduccionDetalles = new HashSet<OrdenesProduccionDetalle>();
            Piezas = new HashSet<Pieza>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string DepositoId { get; set; }

        public virtual Deposito Deposito { get; set; }
        public virtual ICollection<OrdenesProduccionDetalle> OrdenesProduccionDetalles { get; set; }
        public virtual ICollection<Pieza> Piezas { get; set; }
    }
}
