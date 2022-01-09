using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RegistrationForm.Data;
using RegistrationForm.DTOs;
using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm.Controllers
{
    public class RegistrationFormController : Controller
    {
        private DataContext _context;

        public RegistrationFormController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var createQuestion = _context.CreateQuestions.Include(x => x.Questions).ThenInclude(a => a.Answers).FirstOrDefault();
            return View(createQuestion);

        }
        [HttpPost]
        public IActionResult Submit(CreateQuestion createQuestion)
        {
            _context.Update(createQuestion);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
