using System;

namespace InsuranceBroker.DomainServices.Models
{

    public enum AnalysisState
    {
        Created=0,
        InProgress,
        Submitted,
        Completed
    }
    public class Survey
    {

        public System.Guid Id { get; set; }
        public System.Guid AnalysisDefinitionId { get; set; }
        public System.Guid CustomerId { get; set; }
        public string CustomerName { get; set; }
        public Guid? UserId { get; set; }
        public string UserName { get; set; }
        public AnalysisState AnalysisState { get; set; }
    }
}
