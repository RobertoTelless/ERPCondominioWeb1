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
    
    public partial class RESERVA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RESERVA()
        {
            this.AGENDA = new HashSet<AGENDA>();
            this.LISTA_CONVIDADO = new HashSet<LISTA_CONVIDADO>();
        }
    
        public int RESE_CD_ID { get; set; }
        public Nullable<int> COND_CD_ID { get; set; }
        public int UNID_CD_ID { get; set; }
        public int FIRE_CD_ID { get; set; }
        public Nullable<int> AMBI_CD_ID { get; set; }
        public System.DateTime RESE_DT_EVENTO { get; set; }
        public string RESE_HR_INICIO { get; set; }
        public string RESE_HR_FINAL { get; set; }
        public Nullable<int> RESE_NR_CONVIDADOS { get; set; }
        public int RESE_IN_BOLETO { get; set; }
        public int RESE_IN_PAGA { get; set; }
        public string RESE_NR_BOLETO { get; set; }
        public int RESE_IN_CONFIRMADA { get; set; }
        public int RESE_IN_LEMBRAR { get; set; }
        public System.DateTime RESE_DT_CADASTRO { get; set; }
        public int RESE_IN_ATIVO { get; set; }
        public string RESE_NM_NOME { get; set; }
        public Nullable<System.DateTime> RESE_DT_FINAL { get; set; }
        public Nullable<System.DateTime> RESE_DT_INICIO { get; set; }
        public string RESE_TX_JUSTIFICATIVA { get; set; }
        public Nullable<int> RESE_IN_ACEITA { get; set; }
        public Nullable<int> USUA_CD_ID { get; set; }
        public Nullable<System.DateTime> RESE_DT_APROVACAO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENDA> AGENDA { get; set; }
        public virtual AMBIENTE AMBIENTE { get; set; }
        public virtual CONDOMINIO CONDOMINIO { get; set; }
        public virtual FINALIDADE_RESERVA FINALIDADE_RESERVA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LISTA_CONVIDADO> LISTA_CONVIDADO { get; set; }
        public virtual UNIDADE UNIDADE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}