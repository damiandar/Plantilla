using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class Marca
    {
        public Marca()
        {
            Piezas = new HashSet<Pieza>();
        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Pieza> Piezas { get; set; }
    }
}
