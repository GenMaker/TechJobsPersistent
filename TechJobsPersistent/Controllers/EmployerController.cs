using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private EmployerDbContext context;

        //public Employer newEmployer { get; private set; }

        public EmployerController(EmployerDbContext dbContext )
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Employer> employer = context.Employer.ToList();
            return View(employer);
        }

        public IActionResult Add()
        {
            AddEmployerViewModel addEmployerViewModel = new AddEmployerViewModel();

            return View(addEmployerViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddEmployerViewModel addEmployerViewModel)
        {
            if (ModelState.IsValid)
            {
                Employer newEmployer = new Employer
                {
                    Name = addEmployerViewModel.Name,
                    Location = addEmployerViewModel.Location,
                };
                context.Employer.Add(newEmployer);
                context.SaveChanges();

                return Redirect("/Employer");
            }
            return View(addEmployerViewModel);
        }
        public IActionResult ProcessAddEmployerForm()
        {
            return View();
        }

        public IActionResult About(int id)
        {
            return View();
        }

        
    }
}
