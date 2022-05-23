﻿using System;
using System.Collections.Generic;

#nullable disable

namespace webAPI.Modelos
{
    public partial class OrdenesProduccionDetalle
    {
        public int PiezaCodigo { get; set; }
        public int OrdenProduccionCabeceraId { get; set; }
        public int Cantidad { get; set; }
        public int? MatrizId { get; set; }
        public int? EstadoId { get; set; }
        public int? OperarioId { get; set; }
        public int ImpactosVacios { get; set; }
        public int Ajuste { get; set; }

        public virtual EstadosProduccion Estado { get; set; }
        public virtual Matrix Matriz { get; set; }
        public virtual Operario Operario { get; set; }
        public virtual OrdenesProduccionCabecera OrdenProduccionCabecera { get; set; }
        public virtual Pieza PiezaCodigoNavigation { get; set; }
    }
}
