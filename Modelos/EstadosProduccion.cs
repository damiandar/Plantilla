using System;
using System.Collections.Generic;

#nullable disable

namespace AccesoriosArgentinos.Modelos
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
