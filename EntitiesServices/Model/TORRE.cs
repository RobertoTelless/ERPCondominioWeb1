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
    
    public partial class TORRE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TORRE()
        {
            this.MORADOR = new HashSet<MORADOR>();
            this.UNIDADE = new HashSet<UNIDADE>();
        }
    
        public int TORR_CD_ID { get; set; }
        public string TORR_NM_NOME { get; set; }
        public int COND_CD_ID { get; set; }
        public Nullable<int> TORR_IN_ATIVO { get; set; }
        public Nullable<System.DateTime> TORR_DT_CADASTRO { get; set; }
    
        public virtual CONDOMINIO CONDOMINIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MORADOR> MORADOR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIDADE> UNIDADE { get; set; }
    }
}
