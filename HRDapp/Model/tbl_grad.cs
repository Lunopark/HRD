//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HRDapp.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_grad
    {
        public int grad_id { get; set; }
        public Nullable<double> grad_precentage { get; set; }
        public string grad_institue { get; set; }
        public string grad_doc { get; set; }
        public Nullable<int> grad_fk_ap_id { get; set; }
    
        public virtual tbl_applicant_personal tbl_applicant_personal { get; set; }
    }
}