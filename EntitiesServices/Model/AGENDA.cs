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
    
    public partial class AGENDA
    {
        public int AGEN_CD_ID { get; set; }
        public Nullable<int> ASPR_CD_ID { get; set; }
        public Nullable<int> ASVI_CD_ID { get; set; }
        public int CAAG_CD_ID { get; set; }
        public Nullable<int> AMBI_CD_ID { get; set; }
        public Nullable<int> USUA_CD_ID { get; set; }
        public Nullable<int> RESE_CD_ID { get; set; }
        public System.DateTime AGEN_DT_INICIO { get; set; }
        public System.DateTime AGEN_DT_FINAL { get; set; }
        public string AGEN_NM_TITULO { get; set; }
        public string AGEN_DS_DESCRICAO { get; set; }
        public int AGEN_IN_DIA_INTEIRO { get; set; }
        public string AGEN_NM_MODULO { get; set; }
        public System.DateTime AGEN_DT_CADASTRO { get; set; }
        public int AGEN_IN_STATUS { get; set; }
    
        public virtual AMBIENTE AMBIENTE { get; set; }
        public virtual ASSEMBLEIA_PRESENCIAL ASSEMBLEIA_PRESENCIAL { get; set; }
        public virtual ASSEMBLEIA_VIRTUAL ASSEMBLEIA_VIRTUAL { get; set; }
        public virtual CATEGORIA_AGENDA CATEGORIA_AGENDA { get; set; }
        public virtual RESERVA RESERVA { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}
