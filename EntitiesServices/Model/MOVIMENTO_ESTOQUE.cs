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
    
    public partial class MOVIMENTO_ESTOQUE
    {
        public int MOES_CD_ID { get; set; }
        public int PROD_CD_ID { get; set; }
        public int MOES_IN_TIPO { get; set; }
        public System.DateTime MOES_DT_MOVIMENTO { get; set; }
        public int MOES_QN_QUANTIDADE { get; set; }
        public string MOES_DS_DESCRICAO { get; set; }
        public int MOES_IN_ATIVO { get; set; }
    
        public virtual PRODUTO PRODUTO { get; set; }
    }
}