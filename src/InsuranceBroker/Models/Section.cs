using System.Collections.Generic;

namespace InsuranceBroker.Models
{
    public class Section
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Used { get; set; }
        public List<QuestionAnswerPair> QandA { get; set; }   
        
        public Section() { }
    }
}
