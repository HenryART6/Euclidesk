using System.Web.Mvc;

namespace Euclidesk.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string pNum, string sNum)
        {
            int[] perfecto = new int[49];
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
                        for (int j = acum; j < acum + 1; j++)
                        {
                            perfecto[j] = num;
                        }
                        acum++;
                    }
                    num = num + 1;
                    suma = 0;
                }
            }

            if (perfecto[0] != 0)
            {
                ViewData["mensage"] = "Los numeros perfectos encontrados entre " + pNum + " y " + sNum + " son:";
                ViewData["perfecto_0"] = perfecto[0];
            }
            if (perfecto[1] != 0)
            {
                ViewData["perfecto_1"] = perfecto[1];
            }
            if (perfecto[2] != 0)
            {
                ViewData["perfecto_2"] = perfecto[2];
            }
            if (perfecto[3] != 0)
            {
                ViewData["perfecto_3"] = perfecto[3];
            }
            if (perfecto[4] != 0)
            {
                ViewData["perfecto_4"] = perfecto[4];
            }
            int comp = 0;
            ViewData["comp"] = comp;

            return View(perfecto);
        }

        public ActionResult Print()
        {
            return new Rotativa.ActionAsPdf("Index")
            { FileName = "txt.pdf" };
        }
    }
}