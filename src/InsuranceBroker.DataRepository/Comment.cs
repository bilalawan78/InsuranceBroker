//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace InsuranceBroker.DataRepository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public System.Guid Id { get; set; }
        public Nullable<System.Guid> AnalysisId { get; set; }
        public string Comment1 { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Analysis Analysis { get; set; }
    }
}
