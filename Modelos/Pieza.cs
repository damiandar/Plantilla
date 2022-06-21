using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

#nullable disable

namespace AccesoriosArgentinos.Modelos
{
    public class PiezaVM {
        public Pieza Pieza {get;set;}
        
        public SelectList ListaMarcas{get;set;}
       
        public SelectList ListaMateriales {get;set;}
       
        public SelectList ListaMatrices {get;set;}
        
        public SelectList ListaInyectoras {get;set;}

    }
    public partial class Pieza
    {
        public Pieza()
        {
            MaterialPiezas = new HashSet<MaterialPieza>();
            OrdenesProduccionDetalles = new HashSet<OrdenesProduccionDetalle>();
        }
        [Key]
        public int Id{get;set;}
        [Display(Name = "Código Expoyer")] 
        public string Codigo { get; set; }
        [Display(Name = "Marca")]  
        public int? MarcaId { get; set; }
        [Display(Name = "Inyectora")]  
        public int? InyectoraId { get; set; }
        public string Descripcion { get; set; }
        [Display(Name = "Código de Fabricación")]  
        public string CodigoFabricacion { get; set; }
        [Display(Name = "Matriz")]  
        public int? MatrizId { get; set; }
        [Display(Name = "Material")]  
        public int? MaterialId { get; set; }
        public int Peso { get; set; }
        public int Bocas { get; set; }
        [Display(Name = "Tiempo de inyección")] 
        public string TiempoDeInyeccion { get; set; }
        [Display(Name = "Presion de inyección")] 
        public string PresionInyeccion { get; set; }
        [Display(Name = "Velocidad de inyección")] 
        public string VelocidadInyeccion { get; set; }
        public int Curado { get; set; }
        public string Carga { get; set; }
        public string Calefaccion { get; set; }
        public string NoyoA { get; set; }
        public string PosicionApertura { get; set; }
         
        [Display(Name = "Succión")]
        public string Succion { get; set; }
        
        [Display(Name = "Posición de expulsor")]
        public string PosicionExpulsor { get; set; }
        [Display(Name = "Producción por hora")] 
        public int ProduccionPorHora { get; set; }

        public virtual Marca Marca { get; set; }
        public virtual Material Material { get; set; }
        public virtual Matriz Matriz { get; set; }
        public virtual ICollection<MaterialPieza> MaterialPiezas { get; set; }
        public virtual ICollection<OrdenesProduccionDetalle> OrdenesProduccionDetalles { get; set; }
        public virtual Inyectora Inyectora { get; set; }

     

        [NotMapped]
        public string FotoRuta {get;set;}
        [NotMapped]
        public IFormFile Foto {get;set;}
    }
}
