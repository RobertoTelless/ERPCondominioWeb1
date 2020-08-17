using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EntitiesServices.Model;

namespace Erp_Condominio.ViewModels
{
    public class ConfiguracaoViewModel
    {
        [Key]
        public int CONF_CD_ID { get; set; }
        public int COND_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo FALHAS/DIA obrigatorio")]
        [RegularExpression(@"^([0-9]+)$", ErrorMessage = "Deve ser um valor inteiro positivo")]
        public int CONF_NR_FALHAS_DIA { get; set; }
        [Required(ErrorMessage = "Campo HOST SMTP obrigatorio")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O HOST SMTP deve conter no minimo 1 caracteres e no máximo 50.")]
        public string CONF_NM_HOST_SMTP { get; set; }
        [Required(ErrorMessage = "Campo PORTA SMTP obrigatorio")]
        [RegularExpression(@"^([0-9]+)$", ErrorMessage = "Deve ser um valor inteiro positivo")]
        public string CONF_NM_PORTA_SMTP { get; set; }
        [Required(ErrorMessage = "Campo E-MAIL EMISSOR obrigatorio")]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O E-MAIL EMISSOR deve conter no minimo 1 caracteres e no máximo 100.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Deve ser um e-mail válido")]
        public string CONF_NM_EMAIL_EMISSOR { get; set; }
        [Required(ErrorMessage = "Campo CREDENCIAIS obrigatorio")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "A CREDENCIAL deve conter no minimo 1 caracteres e no máximo 50.")]
        public string CONF_NM_SENHA_EMAIL_EMISSOR { get; set; }
        public System.DateTime CONF_DT_ALTERACAO { get; set; }
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor numérico positivo")]
        public Nullable<int> CONF_NR_DIAS_CP { get; set; }
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor numérico positivo")]
        public Nullable<int> CONF_NR_DIAS_PATRIMONIO { get; set; }
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor numérico positivo")]
        public Nullable<int> CONF_NR_DIAS_ATENDIMENTO { get; set; }
        [RegularExpression(@"^[0-9]+([,.][0-9]+)?$", ErrorMessage = "Deve ser um valor numérico positivo")]
        [Required(ErrorMessage = "Campo REFRESH obrigatorio")]
        public Nullable<int> CONF_NR_REFRESH_DASH { get; set; }

        public virtual CONDOMINIO CONDOMINIO { get; set; }
    }
}