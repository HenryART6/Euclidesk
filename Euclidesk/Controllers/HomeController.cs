using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;

namespace Euclidesk.Controllers

{

    public class HomeController : Controller
    {

        public ActionResult Index(string pNum, string sNum)
        {
            int[] perfecto = new int[100];
           
            if (pNum != null && sNum != null)
            {

                int num = int.Parse(pNum);
                int num2 = int.Parse(sNum);
                
                int suma = 0;
                int acum = 0;
                int res;

                while (num <= num2)
                {
                    for (int i = 1; i <= num - 1; i++)
                    {
                        res = num % i;
                        if (res == 0)
                        {
                            suma = suma + i;
                        }
                    }
                    if (suma == num)
                    {
                        for (int j = acum; j < acum+1; j++)
                        {
                            perfecto[j] = num; 
                        }
                        acum++;
                    }
                    num = num + 1;
                    suma = 0;
                }
            }

            ViewData["perfecto_0"] = perfecto[0];
            ViewData["perfecto_1"] = perfecto[1];
            ViewData["perfecto_2"] = perfecto[2];

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