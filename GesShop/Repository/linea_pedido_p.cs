//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class linea_pedido_p
    {
        public int Linea { get; set; }
        public int Num_ped { get; set; }
        public int Cantidad { get; set; }
        public Nullable<float> Total { get; set; }
        public string idArticulo { get; set; }
    
        public virtual articulo articulo { get; set; }
        public virtual pedido_p pedido_p { get; set; }
    }
}
