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
    
    public partial class EQUIPAMENTO
    {
        public int EQUI_CD_ID { get; set; }
        public int COND_CD_ID { get; set; }
        public int TIEQ_CD_ID { get; set; }
        public string EQUI_NM_NOME { get; set; }
        public Nullable<System.DateTime> EQUI_DT_AQUISICAO { get; set; }
        public int EQUI_IN_ALUGADO { get; set; }
        public Nullable<int> EQUI_NR_GARANTIA { get; set; }
        public string EQUI_NM_FABRICANTE { get; set; }
        public string EQUI_NM_ASSISTENCIA { get; set; }
        public string EQUI_NM_TELEFONE { get; set; }
        public string EQUI_NM_CONTATO { get; set; }
        public Nullable<int> EQUI_NR_INTERVALO_MANUTENCAO { get; set; }
        public Nullable<decimal> EQUI_VL_CUSTO_MEDIO { get; set; }
        public Nullable<System.DateTime> EQUI_DT_PROXIMA_MANUTENCAO { get; set; }
        public System.DateTime EQUI_DT_CADASTRO { get; set; }
        public int EQUI_IN_ATIVO { get; set; }
    
        public virtual CONDOMINIO CONDOMINIO { get; set; }
        public virtual TIPO_EQUIPAMENTO TIPO_EQUIPAMENTO { get; set; }
    }
}
