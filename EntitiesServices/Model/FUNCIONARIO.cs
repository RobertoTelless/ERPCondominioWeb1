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
    
    public partial class FUNCIONARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FUNCIONARIO()
        {
            this.CONTROLE_VEICULO = new HashSet<CONTROLE_VEICULO>();
            this.DEPENDENTE = new HashSet<DEPENDENTE>();
            this.DOCUMENTO = new HashSet<DOCUMENTO>();
            this.ENCOMENDA = new HashSet<ENCOMENDA>();
            this.FUNCIONARIO_ATIVO = new HashSet<FUNCIONARIO_ATIVO>();
            this.FUNCIONARIO_ANEXO = new HashSet<FUNCIONARIO_ANEXO>();
        }
    
        public int FUCR_CD_ID { get; set; }
        public int COND_CD_ID { get; set; }
        public Nullable<int> CARG_CD_ID { get; set; }
        public Nullable<int> MODE_CD_ID { get; set; }
        public int SEXO_CD_ID { get; set; }
        public int ESCI_CD_ID { get; set; }
        public int ESCO_CD_ID { get; set; }
        public int VIEM_CD_ID { get; set; }
        public int TISA_CD_ID { get; set; }
        public Nullable<int> ESTR_CD_ID { get; set; }
        public Nullable<int> BANC_CD_ID { get; set; }
        public string FUCR_NM_NOME { get; set; }
        public System.DateTime FUCR_DT_ADMISSAO { get; set; }
        public Nullable<System.DateTime> FUCR_DT_DESLIGAMENTO { get; set; }
        public int FUCR_IN_JUSTA_CAUSA { get; set; }
        public System.DateTime FUCR_DT_NASCIMENTO { get; set; }
        public string FUCR_NR_RG { get; set; }
        public string FUCR_ORGAO_RG { get; set; }
        public System.DateTime FUCR_DT_RG { get; set; }
        public string FUCR_NR_CPF { get; set; }
        public string FUCR_NR_TITULO_ELEITOR { get; set; }
        public string FUCR_NR_TITULO_ELEITOR_ZONA { get; set; }
        public string FUCR_TITULO_ELEITOR_SECAO { get; set; }
        public string FUCR_NM_MUNICIPIO_ELEICAO { get; set; }
        public string FUCR_NR_NIS { get; set; }
        public string FUCR_NR_CTPS { get; set; }
        public string FUCR_NR_CTPS_SERIE { get; set; }
        public System.DateTime FUCR_DT_CTPS_DATA { get; set; }
        public string FUCR_SG_CTPS_UF { get; set; }
        public string FUCR_NM_NATURALIDADE { get; set; }
        public string FUCR_NM_NACIONALIDADE { get; set; }
        public string FUCR_SG_NATURALIDADE_UF { get; set; }
        public string FUCR_NM_ENDERECO { get; set; }
        public string FUCR_NR_NUMERO { get; set; }
        public string FUCR_NR_COMPLEMENTO { get; set; }
        public string FUCR_NM_BAIRRO { get; set; }
        public string FUCR_NM_CIDADE { get; set; }
        public string FUCR_SG_UF { get; set; }
        public string FUCR_NR_CEP { get; set; }
        public string FUCR_NM_PAI { get; set; }
        public string FUCR_NM_MAE { get; set; }
        public Nullable<System.DateTime> FUCR_DT_FGTS { get; set; }
        public Nullable<int> FUCR_IN_DEPENDENTES_IR { get; set; }
        public Nullable<int> FUCR_NR_EXPERIENCIA { get; set; }
        public string FUCR_NR_CENTRO_CUSTO { get; set; }
        public decimal FUCR_VL_SALARIO { get; set; }
        public Nullable<int> FUCR_NR_HORAS { get; set; }
        public int FUCR_N_ESTUDANTE { get; set; }
        public Nullable<System.DateTime> FUCR_DT_APOSENTADORIA { get; set; }
        public string FUCR_NR_RESERVISTA { get; set; }
        public string FUCR_NR_RIC { get; set; }
        public string FUCR_NM_RIC_ORGAO { get; set; }
        public Nullable<System.DateTime> FUCR_DT_RIC_EMISSAO { get; set; }
        public Nullable<System.DateTime> FUCR_DT_EXAME_ADMISSIONAL { get; set; }
        public Nullable<System.DateTime> FUCR_DT_EXAME_PERIODICO { get; set; }
        public Nullable<int> FUCR_IN_PRAZO_CONTRATO { get; set; }
        public Nullable<int> FUCR_NR_RENOVACAO_EXPERIENCIA { get; set; }
        public Nullable<int> FUCR_IN_SEFIP { get; set; }
        public Nullable<int> FUCR_NR_VALE_TRANSPORTE { get; set; }
        public string FUCR_NR_AGENCIA_BANCARIA { get; set; }
        public string FUCR_NR_CONTA_BANCARIA { get; set; }
        public Nullable<int> FUCR_IN_DESCONTO_INSS { get; set; }
        public Nullable<int> FUCR_IN_ADIANTEMENTO_QUINZENAL { get; set; }
        public Nullable<int> FUCR_IN_CONTRIBUICAO_SINDICAL { get; set; }
        public Nullable<int> FUCR_IN_APOSENTADORIA_RESCISAO { get; set; }
        public System.DateTime FUCR_DT_CADASTRO { get; set; }
        public int FUCR_IN_ATIVO { get; set; }
        public string FUCR_NM_FOTO { get; set; }
        public Nullable<int> USUA_CD_ID { get; set; }
    
        public virtual BANCO BANCO { get; set; }
        public virtual CARGO CARGO { get; set; }
        public virtual CONDOMINIO CONDOMINIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CONTROLE_VEICULO> CONTROLE_VEICULO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DEPENDENTE> DEPENDENTE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DOCUMENTO> DOCUMENTO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ENCOMENDA> ENCOMENDA { get; set; }
        public virtual ESCALA_TRABALHO ESCALA_TRABALHO { get; set; }
        public virtual ESCOLARIDADE ESCOLARIDADE { get; set; }
        public virtual ESTADO_CIVIL ESTADO_CIVIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FUNCIONARIO_ATIVO> FUNCIONARIO_ATIVO { get; set; }
        public virtual MOTIVO_DESLIGAMENTO MOTIVO_DESLIGAMENTO { get; set; }
        public virtual SEXO SEXO { get; set; }
        public virtual TIPO_SALARIO TIPO_SALARIO { get; set; }
        public virtual VINCULO_EMPREGATICIO VINCULO_EMPREGATICIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FUNCIONARIO_ANEXO> FUNCIONARIO_ANEXO { get; set; }
    }
}
