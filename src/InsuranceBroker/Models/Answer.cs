using System.Collections.Generic;

namespace InsuranceBroker.Models
{
    public class Answer
    {
        public int QuestionId { get; set; }
        public List<AnswerValue> Value { get; set; }
        public string ExtraText { get; set; }

        public Answer()
        {
            Value=new List<AnswerValue>();
        }
        public Answer(int questionId, List<AnswerValue> value)
        {
            QuestionId = questionId;
            Value = value;
        }

        public Answer(int questionId, List<AnswerValue> value,string extraText)
        {
            QuestionId = questionId;
            Value = value;
            ExtraText = extraText;
        }
    }
}
