using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EntitiesServices.Model;

namespace Erp_Condominio.ViewModels
{
    public class NotificacaoViewModel
    {
        [Key]
        public int NOTI_CD_ID { get; set; }
        public int COND_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo CATEGORIA obrigatorio")]
        public int CANO_CD_ID { get; set; }
        public Nullable<int> TEMP_CD_ID { get; set; }
        public Nullable<int> MULT_CD_ID { get; set; }
        public int UNID_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo DESTINO obrigatorio")]
        public int USUA_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo TÍTULO obrigatorio")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O TÍTULO deve ter no minimo 1 caractere e no máximo 50.")]
        public string NOTI_NM_TITULO { get; set; }
        public string NOTI_TX_TEXTO { get; set; }
        [Required(ErrorMessage = "Campo DATA DE EMISSÃO obrigatorio")]
        [DataType(DataType.Date, ErrorMessage = "DATA DE EMISSÂO Deve ser uma data válida")]
        public System.DateTime NOTI_DT_EMISSAO { get; set; }
        public int NOTI_IN_VISTA { get; set; }
        [Required(ErrorMessage = "Campo DATA DE VALIDADE obrigatorio")]
        [DataType(DataType.Date, ErrorMessage = "DATA DE VALIDADE Deve ser uma data válida")]
        public System.DateTime NOTI_DT_VALIDADE { get; set; }
        public int NOTI_IN_ATIVO { get; set; }
        [DataType(DataType.Date, ErrorMessage = "Deve ser uma data válida")]
        public Nullable<System.DateTime> NOTI_DT_VISTA { get; set; }
        public Nullable<int> NOTI_IN_NIVEL { get; set; }
        public Nullable<System.DateTime> NOTI_DT_LEITURA { get; set; }
        public int NOTI_IN_PRIVADA { get; set; }
        public int NOTI_IN_BOLETO { get; set; }
        public int NOTI_IN_ENVIADA { get; set; }
        public int NOTI_IN_STATUS { get; set; }

        public virtual CATEGORIA_NOTIFICACAO CATEGORIA_NOTIFICACAO { get; set; }
        public virtual CONDOMINIO CONDOMINIO { get; set; }
        public virtual MULTA MULTA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NOTIFICACAO_ANEXO> NOTIFICACAO_ANEXO { get; set; }
        public virtual TEMPLATE TEMPLATE { get; set; }
        public virtual UNIDADE UNIDADE { get; set; }
        public virtual USUARIO USUARIO { get; set; }
    }
}