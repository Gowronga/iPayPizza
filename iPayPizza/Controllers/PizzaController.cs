using iPayPizza.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace iPayPizza.Controllers
{
    public class PizzaController : Controller
    {
        // GET: Pizza
        public ActionResult Index()
        {
            var model = new Pizza() { Name = "Sunkova ", Price = 107};

            return View(model);
        }

        public ActionResult AddPizza()
        {
            return PartialView("_PizzaItemView.cshtml");
        }


        [HttpPost]
        public ActionResult AddPizza2(string[] txtAmount)// public ActionResult AddPizza2(string txtAmount, string txtRate, string txtYear)
        {
            
            return Content(txtAmount.ToString());
        }

    }
}