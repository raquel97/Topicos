using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Northwind
    {
        public int ProductID { get; set; }

		// Modelo del MVC para el proyecto Northwind

        [Display(Name = "Producto")]
        [Required(ErrorMessage = "Debe ingresar el nombre del producto")]
        //[StringLength(15, ErrorMessage = "El nombre no debe exceder los")]
        public string ProductName { get; set; }

        [Display(Name = "Categoría")]
        [Required(ErrorMessage = "Debe ingresar la categoría del producto")]
        public string CategoryName { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Debe ingresar el precio del producto")]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "Debe ingresar el stock del producto")]
        public short? UnitsInStock { get; set; }

        [Display(Name = "Compañía")]
        [Required(ErrorMessage = "Debe ingresar la compañía del producto")]
        public string CompanyName { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "Debe ingresar el país del producto")]
        public string Country { get; set; }

        [Display(Name = "Código Postal")]
        [Required(ErrorMessage = "Debe ingresar el código postal")]
        public string PostalCode { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "Debe ingresar la dirección de la compañía")]
        public string Address { get; set; }

        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "Debe ingresar el teléfono de la compañía")]
        public string Phone { get; set; }
    }
}