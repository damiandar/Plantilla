using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public class OrdenDetalleVM { 
        public OrdenesProduccionDetalle OrdenDetalle { get; set; }
    }
    public partial class OrdenesProduccionDetalle
    {
        public int PiezaId { get; set; }
        public int OrdenProduccionCabeceraId { get; set; }
        public int Cantidad { get; set; }
        public int? MatrizId { get; set; }
        public int? EstadoId { get; set; }
        public int? OperarioId { get; set; }
        public int ImpactosVacios { get; set; }
        public int Ajuste { get; set; }

        public virtual EstadosProduccion Estado { get; set; }
        public virtual Matriz Matriz { get; set; }
        public virtual Operario Operario { get; set; }
        public virtual OrdenesProduccionCabecera OrdenProduccionCabecera { get; set; }
        public virtual Pieza Pieza { get; set; }

        [NotMapped]
        public string PesoTotal { get {
                double peso = Pieza.Peso * Cantidad;
                return (peso/1000).ToString() + " Kgs" ;
            } }
    }
}
