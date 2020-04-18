using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MVC.Controllers
{
    public class NorthWindController : Controller
    {
        NorthwindEntities contexto = new NorthwindEntities();
        // GET: NorthWindMVC
        public ActionResult Index()
        {

            List<Models.Northwind> lista = (from pro in contexto.Products
                                            join cat in contexto.Categories on pro.CategoryID equals cat.CategoryID
                                            join sup in contexto.Suppliers on pro.SupplierID equals sup.SupplierID
                                            select new Models.Northwind
                                            {
                                                ProductID = pro.ProductID,
                                                ProductName = pro.ProductName,
                                                CategoryName = cat.CategoryName,
                                                UnitPrice = pro.UnitPrice,
                                                UnitsInStock = pro.UnitsInStock,
                                                CompanyName = sup.CompanyName,
                                                Country = sup.Country,
                                                PostalCode = sup.PostalCode,
                                                Address = sup.Address,
                                                Phone = sup.Phone

                                            }).ToList();

            return View(lista);

        }

        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Models.Northwind model)
        {
            if (ModelState.IsValid)
            {
                Products productos = new Products();
                Suppliers proveedores = new Suppliers();
                Categories categorias = new Categories();
                productos.ProductID = model.ProductID;
                productos.ProductName = model.ProductName;
                categorias.CategoryName = model.CategoryName;
                productos.UnitPrice = model.UnitPrice;
                productos.UnitsInStock = model.UnitsInStock;
                proveedores.CompanyName = model.CompanyName;
                proveedores.Country = model.Country;
                proveedores.PostalCode = model.PostalCode;
                proveedores.Address = model.Address;
                proveedores.Phone = model.Phone;



                contexto.Products.Add(productos);
                contexto.Suppliers.Add(proveedores);
                contexto.Categories.Add(categorias);
                contexto.SaveChanges();

                return RedirectToAction("Index");

            }
            return View(model);
        }

        public ActionResult Eliminar(int id)
        {
            Products producto = (from p in contexto.Products
                                 where p.ProductID == id
                                 select p).FirstOrDefault();
            contexto.Products.Remove(producto);
            contexto.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Modificar(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Modificar(Models.Northwind model)
        {
            return View();
        }
    }
}