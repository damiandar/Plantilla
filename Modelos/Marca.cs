using System;
using System.Collections.Generic;

#nullable disable

namespace webAPI.Modelos
{
    public partial class Marca
    {
        public Marca()
        {
            Piezas = new HashSet<Pieza>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Pieza> Piezas { get; set; }
    }
}
