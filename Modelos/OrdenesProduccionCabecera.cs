using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class OrdenesProduccionCabecera
    {
        public OrdenesProduccionCabecera()
        {
            OrdenesProduccionDetalles = new HashSet<OrdenesProduccionDetalle>();
        }

        public int Id { get; set; } 

        [Display(Name = "Nro Inyectora")]
        public int? InyectoraId { get; set; }

        [Display(Name = "Fecha de Creación")]
        public DateTime FechaCreacion { get; set; }

        public virtual Inyectora Inyectora { get; set; }
        public virtual ICollection<OrdenesProduccionDetalle> OrdenesProduccionDetalles { get; set; }
    }
}
