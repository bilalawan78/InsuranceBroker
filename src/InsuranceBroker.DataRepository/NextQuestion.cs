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
    
    public partial class NextQuestion
    {
        public System.Guid Id { get; set; }
        public int BaseQuestionId { get; set; }
        public int OptionGroupId { get; set; }
        public int OptionId { get; set; }
        public Nullable<int> NextQuestionId { get; set; }
        public Nullable<int> SortOrder { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Question Question { get; set; }
        public virtual Question Question1 { get; set; }
    }
}