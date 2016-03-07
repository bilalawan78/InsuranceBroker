namespace InsuranceBroker.Models
{
    public class AnswerValue
    {
        public string Text { get; set; }
        public bool IsSelected { get; set; }

        public AnswerValue() { }

        public AnswerValue(string text, bool isSelected)
        {
            Text = text;
            IsSelected = isSelected;
        }

        public AnswerValue(string text)
        {
            Text = text;
            IsSelected = false;
        }

        public override string ToString()
        {
            return Text;
        }
       
    }
}