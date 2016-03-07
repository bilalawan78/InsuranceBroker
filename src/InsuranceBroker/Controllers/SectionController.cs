using System.Collections.Generic;
using InsuranceBroker.Constants.SectionController;
using InsuranceBroker.Models;
using Microsoft.AspNet.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace InsuranceBroker.Controllers
{
    [Route("[controller]")]
    public class SectionController : Controller
    {              
        [HttpGet("index", Name = SectionControllerRoute.GetIndex)]
        public IActionResult Index()
        {
            Section section = new Section
            {
                Id = 1,
                Title = "GroupSection1", 
                Used = true,
                QandA = new List<QuestionAnswerPair>()
                {
                    new QuestionAnswerPair(
                        new Question(0, "What??", Question.QuestionType.SingleChoice,
                            new List<AnswerValue>() {new AnswerValue("Something",false), new AnswerValue("Something Else",false), new AnswerValue("Something Totally Different",false)}),
                        new Answer(0, new List<AnswerValue>())),
                    new QuestionAnswerPair(
                        new Question(1, "NOW??", Question.QuestionType.YesNo,
                            new List<AnswerValue>() { new AnswerValue("Yes",false),
                                new AnswerValue("No",false)}),
                        new Answer(1, new List<AnswerValue>())),
                     new QuestionAnswerPair(
                        new Question(2, "Now and when else??", Question.QuestionType.YesNoWithText,
                            new List<AnswerValue>()
                            {
                                new AnswerValue("Yes",false),
                                new AnswerValue("No",false)
                            }),
                        new Answer(2, new List<AnswerValue>(),""))
                }
            };
            return View(section);
        }

        [HttpGet("QuestionCreator", Name = SectionControllerRoute.QuestionCreator)]
        public IActionResult QuestionCreator()
        {
            Question question = new Question(1, "NOW??", Question.QuestionType.YesNo,
                new List<AnswerValue>() {new AnswerValue("Yes"), new AnswerValue("No")});
            return View(question);
        }

        [HttpPost("QuestionCreator", Name = SectionControllerRoute.QuestionCreator)]
        public IActionResult QuestionCreator(Question question)
        {            
            return View(question);
        }

        [HttpPost("index", Name = SectionControllerRoute.GetIndex)]
        public IActionResult Index(Section section)
        {
            //process the questions
            return View("Success",section);
        }      
    }
}