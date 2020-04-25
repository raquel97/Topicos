using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;

namespace MVC.Controllers
{
    public class CategoriasController : Controller
    {
        NorthwindEntities contexto = new NorthwindEntities();
        // GET: Categorias
        public ActionResult Index(string sortOrder, string searchString, int? page)
        {
            
            int pageSize = 5;
            int pageNumber = (page ?? 1);
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.DateSortParm = sortOrder == "Date" ? "date_desc" : "Date";
            var lista = from s in contexto.Categories
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                lista = lista.Where(s => s.CategoryName.Contains(searchString));
                                       //|| s.FirstMidName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "name_desc":
                    lista = lista.OrderByDescending(s => s.CategoryName);
                    break;
                case "date_desc":
                    lista = lista.OrderByDescending(s => s.CategoryID);
                    break;
                default:
                    lista = lista.OrderBy(s => s.CategoryID);
                    break;
            }

            return View(lista.ToList());
            //return View(lista.ToPagedList(pageNumber, pageSize));
        }



        public ActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Crear(Models.CategoriesNorthWind model)
        {
            if (ModelState.IsValid)
            {
                Categories categoria = new Categories();
                categoria.CategoryID = model.CategoryID;
                categoria.CategoryName = model.CategoryName;
                categoria.Description = model.Description;


                contexto.Categories.Add(categoria);
                contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Eliminar(int id)
        {
            Categories categoria = (from c in contexto.Categories
                                    where c.CategoryID == id
                                    select c).FirstOrDefault();
            contexto.Categories.Remove(categoria);
            contexto.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Modificar(int id)
        {
            Models.CategoriesNorthWind categoria = (from c in contexto.Categories
                                                    where c.CategoryID == id
                                                    select new Models.CategoriesNorthWind
                                                    {
                                                        CategoryID = c.CategoryID,
                                                        CategoryName = c.CategoryName,
                                                        Description = c.Description

                                                    }).FirstOrDefault();

            return View(categoria);
        }

        [HttpPost]
        public ActionResult Modificar(Models.CategoriesNorthWind model)
        {
            if (ModelState.IsValid)
            {
                Categories categoria = (from c in contexto.Categories
                                        where c.CategoryID == model.CategoryID
                                        select c).FirstOrDefault();
                categoria.CategoryID = model.CategoryID;
                categoria.CategoryName = model.CategoryName;
                categoria.Description = model.Description;
                contexto.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}