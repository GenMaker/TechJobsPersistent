using System;
using System.ComponentModel.DataAnnotations;

namespace TechJobsPersistent.ViewModels
{
    public class AddEmployerViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(12, MinimumLength = 2)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Location is required")]
        [StringLength(20, MinimumLength = 3)]
        public string Location { get; set; }

    }
}
