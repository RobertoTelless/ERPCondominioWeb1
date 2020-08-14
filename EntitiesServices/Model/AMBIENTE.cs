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
    
    public partial class AMBIENTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AMBIENTE()
        {
            this.AGENDA = new HashSet<AGENDA>();
            this.AMBIENTE_CHAVE = new HashSet<AMBIENTE_CHAVE>();
            this.AMBIENTE_CUSTO = new HashSet<AMBIENTE_CUSTO>();
            this.AMBIENTE_IMAGEM = new HashSet<AMBIENTE_IMAGEM>();
            this.RESERVA = new HashSet<RESERVA>();
        }
    
        public int AMBI_CD_ID { get; set; }
        public Nullable<int> COND_CD_ID { get; set; }
        public int TIAM_CD_ID { get; set; }
        public string AMBI_NM_AMBIENTE { get; set; }
        public int AMBI_NR_LOTACAO { get; set; }
        public string AMBI_NM_DESCRICAO { get; set; }
        public int AMBI_IN_CHAVE { get; set; }
        public System.DateTime AMBI_DT_CADASTRO { get; set; }
        public int AMBI_IN_ATIVO { get; set; }
        public string AMBI_AQ_FOTO { get; set; }
        public Nullable<int> AMBI_IN_GRATUITO { get; set; }
        public string AMBI_TX_NORMAS_USO { get; set; }
        public string AMBI_TX_LISTA { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AGENDA> AGENDA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMBIENTE_CHAVE> AMBIENTE_CHAVE { get; set; }
        public virtual CONDOMINIO CONDOMINIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMBIENTE_CUSTO> AMBIENTE_CUSTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AMBIENTE_IMAGEM> AMBIENTE_IMAGEM { get; set; }
        public virtual TIPO_AMBIENTE TIPO_AMBIENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVA> RESERVA { get; set; }
    }
}