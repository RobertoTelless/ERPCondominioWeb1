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
    
    public partial class FUNCIONARIO_ANEXO
    {
        public int FUAN_CD_ID { get; set; }
        public int FUCR_CD_ID { get; set; }
        public string FUAN_NM_TITULO { get; set; }
        public System.DateTime FUAN_DT_ANEXO { get; set; }
        public int FUAN_IN_TIPO { get; set; }
        public string FUAN_AQ_ARQUIVO { get; set; }
        public int FUAN_IN_ATIVO { get; set; }
    
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
    }
}
