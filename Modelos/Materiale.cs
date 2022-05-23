using System;
using System.Collections.Generic;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class Materiale
    {
        public Materiale()
        {
            MaterialPiezas = new HashSet<MaterialPieza>();
            Piezas = new HashSet<Pieza>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public string Codigo {get;set;}

        public virtual ICollection<MaterialPieza> MaterialPiezas { get; set; }
        public virtual ICollection<Pieza> Piezas { get; set; }
    }
}
