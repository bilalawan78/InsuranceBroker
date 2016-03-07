using System.Collections.Generic;
using InsuranceBroker.Constants.SectionGroupController;
using InsuranceBroker.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace InsuranceBroker.Controllers
{
    [Route("[controller]")]
    public class SectionGroupController : Controller
    {
        [HttpGet("index", Name = SectionGroupControllerRoute.GetIndex)]
        public IActionResult Index()
        {
            var section = new Section
            {
                Id = 1,
                Title = "GroupSection1",
                Used = true,
                QandA = new List<QuestionAnswerPair>
                {
                    new QuestionAnswerPair(
                        new Question(0, "What??", Question.QuestionType.SingleChoice,
                            new List<AnswerValue> {new AnswerValue("Something"), new AnswerValue("Something Else"), new AnswerValue("Something Totally Different")}),
                        new Answer(0, new List<AnswerValue>())),
                    new QuestionAnswerPair(
                        new Question(1, "NOW??", Question.QuestionType.YesNo,
                            new List<AnswerValue> {new AnswerValue("Yes"), new AnswerValue("No")}),
                        new Answer(1, new List<AnswerValue>())),
                    new QuestionAnswerPair(
                        new Question(2, "Now and when else??", Question.QuestionType.YesNoWithText,
                            new List<AnswerValue> {new AnswerValue("Yes"), new AnswerValue("No")}),
                        new Answer(2, new List<AnswerValue>(), ""))
                }
            };
            var section2 = new Section
            {
                Id = 2,
                Title = "GroupSection2",
                Used = true,
                QandA = new List<QuestionAnswerPair>
                {
                    new QuestionAnswerPair(
                        new Question(0, "What now??", Question.QuestionType.SingleChoice,
                            new List<AnswerValue> {new AnswerValue("Something"), new AnswerValue("Something Else"), new AnswerValue("Something Totally Different")}),
                        new Answer(0, new List<AnswerValue>())),
                    new QuestionAnswerPair(
                        new Question(1, "NOW really??", Question.QuestionType.YesNo,
                            new List<AnswerValue> {new AnswerValue("Yes"), new AnswerValue("No")}),
                        new Answer(1, new List<AnswerValue>())),
                    new QuestionAnswerPair(
                        new Question(2, "Now and when else??", Question.QuestionType.YesNoWithText,
                            new List<AnswerValue> {new AnswerValue("Yes"), new AnswerValue("No")}),
                        new Answer(2, new List<AnswerValue>(), ""))
                }
            };

            var questionnaire = new SectionGroup {Sections = new List<Section> {section, section2}};
            return View(questionnaire);
        }

        [HttpPost("index", Name = SectionGroupControllerRoute.GetIndex)]
        public IActionResult Index(SectionGroup sectionGroup)
        {
            //process the questions
            return View(sectionGroup);
        }
    }
}