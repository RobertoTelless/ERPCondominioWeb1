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
    
    public partial class FUNCIONARIO_ATIVO
    {
        public int FUAT_CD_ID { get; set; }
        public Nullable<int> COND_CD_ID { get; set; }
        public int FUCR_CD_ID { get; set; }
        public Nullable<System.DateTime> FUAT_DT_ENTRADA { get; set; }
        public Nullable<System.DateTime> FUAT_DT_SAIDA { get; set; }
        public string FUAT_DS_OBSERVACOES { get; set; }
        public int FUAT_IN_ATIVO { get; set; }
        public Nullable<int> USUA_CD_ID { get; set; }
    
        public virtual CONDOMINIO CONDOMINIO { get; set; }
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
    }
}
