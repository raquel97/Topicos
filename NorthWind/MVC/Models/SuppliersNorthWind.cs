using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class SuppliersNorthWind
    {
        public int SupplierID { get; set; }

        [Display(Name = "Compañía")]
        [Required(ErrorMessage = "Debe ingresar el nombre de la compañía")]
        [StringLength(40, ErrorMessage = "El nombre no debe exceder los 40 caracteres")]
        public string CompanyName { get; set; }

        [Display(Name = "Contacto")]
        [Required(ErrorMessage = "Debe ingresar el nombre del contacto")]
        [StringLength(30, ErrorMessage = "El nombre no debe exceder los 30 caracteres")]
        public string ContactName { get; set; }

        [Display(Name = "Ocupación")]
        [Required(ErrorMessage = "Debe ingresar el nombre de la ocupación")]
        [StringLength(30, ErrorMessage = "El nombre no debe exceder los 30 caracteres")]
        public string ContactTitle { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Debe ingresar la dirección de la compañía")]
        [StringLength(60, ErrorMessage = "El nombre no debe exceder los 60 caracteres")]
        public string Address { get; set; }

        [Display(Name = "Ciudad")]
        [Required(ErrorMessage = "Debe ingresar el nombre de la ciudad")]
        [StringLength(15, ErrorMessage = "El nombre no debe exceder los 15 caracteres")]
        public string City { get; set; }

        [Display(Name = "Código Postal")]
        [Required(ErrorMessage = "Debe ingresar el código postal")]
        [StringLength(10, ErrorMessage = "El nombre no debe exceder los 10 caracteres")]
        public string PostalCode { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "Debe ingresar el país")]
        [StringLength(15, ErrorMessage = "El nombre no debe exceder los 15 caracteres")]
        public string Country { get; set; }

        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "Debe ingresar el teléfono")]
        [StringLength(24, ErrorMessage = "El nombre no debe exceder los 24 caracteres")]
        public string Phone { get; set; }
    }
}