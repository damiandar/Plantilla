using System;
using System.Collections.Generic;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class Operario
    {
        public Operario()
        {
            OrdenesProduccionDetalles = new HashSet<OrdenesProduccionDetalle>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public virtual ICollection<OrdenesProduccionDetalle> OrdenesProduccionDetalles { get; set; }
    }
}
