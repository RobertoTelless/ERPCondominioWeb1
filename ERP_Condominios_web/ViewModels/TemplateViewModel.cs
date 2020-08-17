using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EntitiesServices.Model;

namespace Erp_Condominio.ViewModels
{
    public class TemplateViewModel
    {
        [Key]
        public int TEMP_CD_ID { get; set; }
        public int COND_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo NOME obrigatorio")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O NOME deve ter no minimo 1 caractere e no máximo 50.")]
        public string TEMP_NM_NOME { get; set; }
        [Required(ErrorMessage = "Campo TEXTO obrigatorio")]
        public string TEMP_TX_TEXTO { get; set; }
        [Required(ErrorMessage = "Campo DATA DE CRIAÇÃO obrigatorio")]
        [DataType(DataType.Date, ErrorMessage = "DATA DE CRIAÇÃO Deve ser uma data válida")]
        public Nullable<System.DateTime> TEMP_DT_CRIACAO { get; set; }
        public int TEMP_IN_ATIVO { get; set; }
        [Required(ErrorMessage = "Campo SIGLA obrigatorio")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "A SIGLA deve ter no minimo 1 caractere e no máximo 10.")]
        public string TEMP_SG_SIGLA { get; set; }
        public Nullable<int> CAMP_CD_ID { get; set; }

        public string TEMP_AQ_ARQUIVO { get; set; }
        public System.DateTime TEMP_DT_CADASTRO { get; set; }
        public string TEMP_TX_CONTEUDO { get; set; }
        public string TEMP_TX_CONTEUDO_LIMPO { get; set; }
        public string TEMP_TX_CABECALHO { get; set; }
        public string TEMP_TX_CORPO { get; set; }
        public string TEMP_TX_DADOS { get; set; }

        public virtual CONDOMINIO CONDOMINIO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICACAO> NOTIFICACAO { get; set; }

    }
}