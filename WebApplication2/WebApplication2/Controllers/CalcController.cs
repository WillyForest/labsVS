using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CalcController : Controller
    {
        // GET: Calc
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OperandsModel model)
        {
            string[] mass = new string[model.nums.Length];
            mass = model.nums.Split(' ');
            int[] massInt = new int[mass.Length];
            for (int i = 0; i < mass.Length; i++)
            {
                massInt[i] = Int32.Parse(mass[i]);
            }
            int[] res = new int[massInt.Length];
            string result = string.Empty;
            try
            {
                int i = 0;
                foreach (int num in massInt)
                {
                    if (num % 3 == 0)
                    {
                        res[i] = num;
                        i++; 
                    }
                }
                int[] rest = new int[i];
                for (int j = 0; j < i; j++)
                {
                    rest[j] = res[j];
                }
                string reslt = string.Join(", ", rest);
                result = string.Format("Різниця: {0} Остача від ділення: {1}, Числа що діляться на 3: {2}", 
                    model.Num1 - model.Num2, model.Num1 % model.Num2, reslt);
            }
            catch (Exception e)
            {
                result = "Виникла помилка: " + e.Message.ToString();
            }

            ViewBag.Result = result; //result container

            return View();
        }

    }
}