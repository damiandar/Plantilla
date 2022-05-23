using System;
using System.Collections.Generic;

#nullable disable

namespace webAPI.Modelos
{
    public partial class OrdenesProduccionCabecera
    {
        public OrdenesProduccionCabecera()
        {
            OrdenesProduccionDetalles = new HashSet<OrdenesProduccionDetalle>();
        }

        public int Id { get; set; }
        public int? InyectoraId { get; set; }
        public DateTime FechaCreacion { get; set; }

        public virtual Inyectora Inyectora { get; set; }
        public virtual ICollection<OrdenesProduccionDetalle> OrdenesProduccionDetalles { get; set; }
    }
}
