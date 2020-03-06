using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Euclidesk.Controllers

{

    public class HomeController : Controller
    {

        public ActionResult Index(string pNum, string sNum)
        {

            
            if (pNum != null && sNum != null)
            {
                
                int num = int.Parse(pNum);
                int num2 = int.Parse(sNum);
                int suma = (num + num2);
               
                ViewData["suma"] = suma;
            }
            
            
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}