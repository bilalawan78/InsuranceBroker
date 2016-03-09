using System;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using InsuranceBroker.Models;
using InsuranceBroker.DomainServices;

namespace InsuranceBroker.Controllers
{
    public class SurveysController : Controller
    {
        private ApplicationDbContext _context;
        private InsuranceBroker.DomainServices.Models.Survey surveyManager;

        public SurveysController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Surveys
        public IActionResult Index()
        {
            return View(_context.Survey.ToList());
        }

        // GET: Surveys/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Survey survey = _context.Survey.Single(m => m.Id == id);
            if (survey == null)
            {
                return HttpNotFound();
            }

            return View(survey);
        }

        // GET: Surveys/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Surveys/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Survey survey)
        {
            if (ModelState.IsValid)
            {
                survey.Id = Guid.NewGuid();
                _context.Survey.Add(survey);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(survey);
        }

        // GET: Surveys/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Survey survey = _context.Survey.Single(m => m.Id == id);
            if (survey == null)
            {
                return HttpNotFound();
            }
            return View(survey);
        }

        // POST: Surveys/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Survey survey)
        {
            if (ModelState.IsValid)
            {
                _context.Update(survey);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(survey);
        }

        // GET: Surveys/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Survey survey = _context.Survey.Single(m => m.Id == id);
            if (survey == null)
            {
                return HttpNotFound();
            }

            return View(survey);
        }

        // POST: Surveys/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            Survey survey = _context.Survey.Single(m => m.Id == id);
            _context.Survey.Remove(survey);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
