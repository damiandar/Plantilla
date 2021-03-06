using System;
using System.Collections.Generic;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class Inyectora
    {
        public Inyectora()
        {
            OrdenesProduccionCabeceras = new HashSet<OrdenesProduccionCabecera>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<OrdenesProduccionCabecera> OrdenesProduccionCabeceras { get; set; }
        public virtual ICollection<Pieza> Piezas { get; set; }
    }
}
