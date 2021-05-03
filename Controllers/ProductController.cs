using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace M05.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            var context = new Models.NorthwindEntities();
            var product = context.Products.ToList();
            return View(product);
        }

        public ActionResult Display(int ID)
        {
            var context = new Models.NorthwindEntities();
            var product = context.Products.FirstOrDefault(p => p.ProductID == ID);
            return View("DinamycView", product);
        }

        public ActionResult DisplayExtern(int ID)
        {
            var Extern = new Models.ExternProduct
            {
                ProductName = "Producto externo",
                UnitPrice = 10,
                UnitsInStock = 100,
                ExternID = 50
            };
            return View("DinamycView", Extern);
        }

        // Details
        // Create
        // Edit
        // Delete

    }
}