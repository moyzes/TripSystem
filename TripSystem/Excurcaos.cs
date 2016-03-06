//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TripSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Excurcaos
    {
        public Excurcaos()
        {
            this.Carrinhoes = new HashSet<Carrinhoes>();
            this.ItensOrdems = new HashSet<ItensOrdems>();
            this.Reservas = new HashSet<Reservas>();
        }
    
        public int ID { get; set; }
        public int GeneroId { get; set; }
        public int GuiaId { get; set; }
        public int VeicuiloId { get; set; }
        public string Titulo { get; set; }
        public string LocalPartida { get; set; }
        public System.DateTime DataPartida { get; set; }
        public System.DateTime DataRetorno { get; set; }
        public int NumeroPessoas { get; set; }
        public decimal Preco { get; set; }
        public string ExcurcaoArtUrl { get; set; }
    
        public virtual ICollection<Carrinhoes> Carrinhoes { get; set; }
        public virtual Generoes Generoes { get; set; }
        public virtual Guias Guias { get; set; }
        public virtual Veiculoes Veiculoes { get; set; }
        public virtual ICollection<ItensOrdems> ItensOrdems { get; set; }
        public virtual ICollection<Reservas> Reservas { get; set; }
    }
}