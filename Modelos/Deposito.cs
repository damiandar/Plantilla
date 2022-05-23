using System;
using System.Collections.Generic;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public partial class Deposito
    {
        public Deposito()
        {
            Matrices = new HashSet<Matrix>();
        }

        public string Id { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Matrix> Matrices { get; set; }
    }
}
