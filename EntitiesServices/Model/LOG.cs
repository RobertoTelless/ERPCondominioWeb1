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
    
    public partial class LOG
    {
        public int LOG_CD_ID { get; set; }
        public int USUA_CD_ID { get; set; }
        public System.DateTime LOG_DT_LOG { get; set; }
        public string LOG_NM_MODULO { get; set; }
        public string LOG_TX_REGISTRO { get; set; }
        public string LOG_TX_REGISTRO_ANTES { get; set; }
        public Nullable<int> LOG_IN_ATIVO { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}
