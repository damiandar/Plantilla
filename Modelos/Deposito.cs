using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class Deposito
    {
        public Deposito()
        {
            Matrices = new HashSet<Matriz>();
        }
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public string DescripcionCorta {
            get {
                return Descripcion.Substring(0, 2);
            }
        }

        public virtual ICollection<Matriz> Matrices { get; set; }
    }
}
