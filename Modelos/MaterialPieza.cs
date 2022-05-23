using System;
using System.Collections.Generic;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class MaterialPieza
    {
        public int MaterialId { get; set; }
        public int PiezaId { get; set; }
        public int Proporcion {get;set;}

        public virtual Materiale Material { get; set; }
        public virtual Pieza Pieza { get; set; }
    }
}
