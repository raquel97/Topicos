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

        [Display(Name = "Categor�a")]
        [Required(ErrorMessage = "Debe ingresar la categor�a del producto")]
        public string CategoryName { get; set; }

        [Display(Name = "Precio")]
        [Required(ErrorMessage = "Debe ingresar el precio del producto")]
        public decimal? UnitPrice { get; set; }

        [Display(Name = "Stock")]
        [Required(ErrorMessage = "Debe ingresar el stock del producto")]
        public short? UnitsInStock { get; set; }

        [Display(Name = "Compa��a")]
        [Required(ErrorMessage = "Debe ingresar la compa��a del producto")]
        public string CompanyName { get; set; }

        [Display(Name = "Pa�s")]
        [Required(ErrorMessage = "Debe ingresar el pa�s del producto")]
        public string Country { get; set; }

        [Display(Name = "C�digo Postal")]
        [Required(ErrorMessage = "Debe ingresar el c�digo postal")]
        public string PostalCode { get; set; }

        [Display(Name = "Direcci�n")]
        [Required(ErrorMessage = "Debe ingresar la direcci�n de la compa��a")]
        public string Address { get; set; }

        [Display(Name = "Tel�fono")]
        [Required(ErrorMessage = "Debe ingresar el tel�fono de la compa��a")]
        public string Phone { get; set; }
    }
}