using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceBroker.Domain.Models
{
    public enum AnalysisState
    {
        Created = 0, 
        InProgress, 
        Submitted, 
        Closed
    }

    public class Analysis
    {
        public System.Guid Id { get; set; }
        public System.Guid AnalysisDefinitionId { get; set; }
        public System.Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Nullable<System.Guid> UserId { get; set; }
        public string UserName { get; set; }
        public AnalysisState AnalysisState { get; set; }
    }
}
