using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProveedoresController : Controller
    {
        NorthwindEntities contexto = new NorthwindEntities();
        // GET: Proveedores
        public ActionResult Index()
        {
            List<Models.SuppliersNorthWind> lista = (from s in contexto.Suppliers
                                                     select new Models.SuppliersNorthWind
                                                     {
                                                         SupplierID = s.SupplierID,
                                                         CompanyName = s.CompanyName,
                                                         ContactName = s.ContactName,
                                                         ContactTitle = s.ContactTitle,
                                                         Address = s.Address,
                                                         City = s.City,
                                                         PostalCode = s.PostalCode,
                                                         Country = s.Country,
                                                         Phone = s.Phone
                                                     }).ToList();
            return View(lista);
        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Models.SuppliersNorthWind model)
        {
            if (ModelState.IsValid)
            {
                Suppliers proveedores = new Suppliers();

                proveedores.CompanyName = model.CompanyName;
                proveedores.ContactName = model.ContactName;
                proveedores.ContactTitle = model.ContactTitle;
                proveedores.Address = model.Address;
                proveedores.City = model.City;
                proveedores.PostalCode = model.PostalCode;
                proveedores.Country = model.Country;
                proveedores.Phone = model.Phone;

                contexto.Suppliers.Add(proveedores);
                contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Eliminar(int id)
        {
            Suppliers proveedor = (from s in contexto.Suppliers
                                   where s.SupplierID == id
                                   select s).FirstOrDefault();
            contexto.Suppliers.Remove(proveedor);
            contexto.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Modificar(int id)
        {
            Models.SuppliersNorthWind proveedor = (from s in contexto.Suppliers
                                                   where s.SupplierID == id
                                                   select new Models.SuppliersNorthWind
                                                   {
                                                       SupplierID = s.SupplierID,
                                                       CompanyName = s.CompanyName,
                                                       ContactName = s.ContactName,
                                                       ContactTitle = s.ContactTitle,
                                                       Address = s.Address,
                                                       City = s.City,
                                                       PostalCode = s.PostalCode,
                                                       Country = s.Country,
                                                       Phone = s.Phone
                                                   }).FirstOrDefault();

            return View(proveedor);
        }

        [HttpPost]
        public ActionResult Modificar(Models.SuppliersNorthWind model)
        {
            if (ModelState.IsValid)
            {
                Suppliers proveedor = (from s in contexto.Suppliers
                                       where s.SupplierID == model.SupplierID
                                       select s).FirstOrDefault();
                proveedor.SupplierID = model.SupplierID;
                proveedor.CompanyName = model.CompanyName;
                proveedor.ContactName = model.ContactName;
                proveedor.ContactTitle = model.ContactTitle;
                proveedor.Address = model.Address;
                proveedor.City = model.City;
                proveedor.PostalCode = model.PostalCode;
                proveedor.Country = model.Country;
                proveedor.Phone = model.Phone;
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}