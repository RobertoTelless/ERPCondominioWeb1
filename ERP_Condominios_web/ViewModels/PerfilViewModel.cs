using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EntitiesServices.Model;

namespace Erp_Condominio.ViewModels
{
    public class PerfilViewModel
    {
        [Key]
        public int PERF_CD_ID { get; set; }
        [Required(ErrorMessage = "Campo SIGLA obrigatorio")]
        [StringLength(10, MinimumLength = 1, ErrorMessage = "A SIGLA deve ter no minimo 1 caractere e no máximo 10.")]
        public string PERF_SG_SIGLA { get; set; }
        [Required(ErrorMessage = "Campo NOME obrigatorio")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "O NOME deve ter no minimo 1 caractere e no máximo 50.")]
        public string PERF_NM_PERFIL { get; set; }
        [StringLength(100, ErrorMessage = "A DESCRIÇÃO deve ter no máximo 100 caracteres.")]
        public string PERF_DS_DESCRICAO { get; set; }
        public int PERF_IN_ATIVO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PERFIL_FUNCIONALIDADE> PERFIL_FUNCIONALIDADE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIO { get; set; }

    }
}