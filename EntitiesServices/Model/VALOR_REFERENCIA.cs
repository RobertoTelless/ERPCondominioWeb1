//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiesServices.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class VALOR_REFERENCIA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VALOR_REFERENCIA()
        {
            this.MULTA = new HashSet<MULTA>();
        }
    
        public int VARE_CD_ID { get; set; }
        public string VARE_NM_NOME { get; set; }
        public decimal VARE_VL_VALOR { get; set; }
        public System.DateTime VARE_DT_CADASTRO { get; set; }
        public int VARE_IN_ATIVO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MULTA> MULTA { get; set; }
    }
}
