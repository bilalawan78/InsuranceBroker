using System.Collections.Generic;

namespace InsuranceBroker.Models
{
    public class Question
    {
        public enum QuestionType
        {
            YesNo,
            MultipleChoice,
            Text,
            SingleChoice,
            YesNoWithText
        }

        public Question(int id, string text, QuestionType type, List<AnswerValue> answerChoice)
        {
            Id = id;
            Text = text;
            Type = type;
            AnswerChoice = answerChoice;
        }

        public Question()
        {
            AnswerChoice=new List<AnswerValue>();
        }

        public int Id { get; set; }
        public string Text { get; set; }

        public QuestionType Type { get; set; }

        public List<AnswerValue> AnswerChoice { get; set; }
        
    }
}