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
    
    public partial class facturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public facturas()
        {
            this.linea_factura = new HashSet<linea_factura>();
        }
    
        public int Numero { get; set; }
        public int Empresa { get; set; }
        public int Facturado { get; set; }
        public int Enviado { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Tipo_ped { get; set; }
        public string Forma_pago { get; set; }
        public int Cliente { get; set; }
        public Nullable<float> Total_bruto { get; set; }
        public Nullable<float> Dto { get; set; }
        public Nullable<float> Dpp { get; set; }
        public Nullable<float> Portes { get; set; }
        public Nullable<float> IVA { get; set; }
        public Nullable<float> Re { get; set; }
        public Nullable<float> Cuota_Re { get; set; }
        public Nullable<float> Total { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<linea_factura> linea_factura { get; set; }
    }
}
