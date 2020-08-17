using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using EntitiesServices.Model;

namespace Erp_Condominio.ViewModels
{
    public class UFViewModel
    {
        public int UF_CD_ID { get; set; }
        public string UF_SG_SIGLA { get; set; }
        public string UF_NM_ESTADO { get; set; }
        public Nullable<int> UF_IN_ATIVO { get; set; }

    }
}