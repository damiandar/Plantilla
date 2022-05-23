using System;
using System.Collections.Generic;

#nullable disable

namespace webAPI.Modelos
{
    public partial class EstadosProduccion
    {
        public EstadosProduccion()
        {
            OrdenesProduccionDetalles = new HashSet<OrdenesProduccionDetalle>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<OrdenesProduccionDetalle> OrdenesProduccionDetalles { get; set; }
    }
}
