namespace InsuranceBroker.Models
{
    public class QuestionAnswerPair
    {
        public QuestionAnswerPair()
        {
        }

        public QuestionAnswerPair(Question q, Answer a)
        {
            Q = q;
            A = a;
        }

        public Question Q { get; set; }
        public Answer A { get; set; }
    }
}