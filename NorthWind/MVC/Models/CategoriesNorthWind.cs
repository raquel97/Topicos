using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MVC.Models
{
    public class CategoriesNorthWind
    {
        public int CategoryID { get; set; }

        [Display(Name = "Categoria")]
        [Required(ErrorMessage = "Debe ingresar la categoria")]
        public string CategoryName { get; set; }

        [Display(Name = "Descripción")]
        [Required(ErrorMessage = "Debe ingresar la descripción")]
        public string Description { get; set; }
    }
}