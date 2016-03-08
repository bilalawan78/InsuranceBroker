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
    
    public partial class AnalysisDefinition
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AnalysisDefinition()
        {
            this.Analyses = new HashSet<Analysis>();
            this.SectionGroups = new HashSet<SectionGroup>();
        }
    
        public System.Guid Id { get; set; }
        public System.Guid OwnerId { get; set; }
        public Nullable<int> AnalysisTypeId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string TaskDetails { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Analysis> Analyses { get; set; }
        public virtual AnalysisType AnalysisType { get; set; }
        public virtual Owner Owner { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SectionGroup> SectionGroups { get; set; }
    }
}
