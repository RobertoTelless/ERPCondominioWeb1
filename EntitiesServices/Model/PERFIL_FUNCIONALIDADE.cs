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
    
    public partial class PERFIL_FUNCIONALIDADE
    {
        public int PEFU_CD_ID { get; set; }
        public int PERF_CD_ID { get; set; }
        public int FUNC_CD_ID { get; set; }
    
        public virtual FUNCIONALIDADE FUNCIONALIDADE { get; set; }
        public virtual PERFIL PERFIL { get; set; }
    }
}
