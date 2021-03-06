using System;
using System.Collections.Generic;



namespace AccesoriosArgentinos.Modelos
{
    public partial class Matriz
    {
        public Matriz()
        {
            OrdenesProduccionDetalles = new HashSet<OrdenesProduccionDetalle>();
            Piezas = new HashSet<Pieza>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public string Estado {get;set;}
        public string DepositoId { get; set; }

        public Deposito Deposito { get; set; }
        public virtual ICollection<OrdenesProduccionDetalle> OrdenesProduccionDetalles { get; set; }
        public virtual ICollection<Pieza> Piezas { get; set; }
    }
}
