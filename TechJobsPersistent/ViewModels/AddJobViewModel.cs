using System;
using TechJobsPersistent.Models;
using System.Collections.Generic;
using TechJobsPersistent.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddJobViewModel
    {
        
  
        public int EmployerId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(12, MinimumLength = 2)]
        public string Name { get; set; }

        public List<Skill> Skills { get; set; }

        public List<SelectListItem> Employers { get; set; }
   

        public AddJobViewModel()
        {

        }

        public AddJobViewModel ( List<Employer> employers, List<Skill> skills)
        {
            Employers = new List<SelectListItem>();
            Skills = skills;

            foreach (Employer employer in employers)
            {
                Employers.Add(new SelectListItem {
                    Text= employer.Name,
                    Value= employer.Id.ToString()
                    }
                );
            }
        }

    }
}
