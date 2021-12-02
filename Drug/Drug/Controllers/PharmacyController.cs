using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Drug.Models;
namespace Drug.Controllers
{
    public class PharmacyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Drug()
        {
            List<cDrug> drugs = new List<cDrug>
            {
                new cDrug("love",12.32f),
                new cDrug("death",132.32f),
                new cDrug("hate",125.32f),

            };
            ViewData["drugs"] = drugs;

            return View();
        }
        public IActionResult DrugTypes()
        {
            List<DrugTypes> drugTypes = new List<DrugTypes>
            {
                new DrugTypes("love"),
                new DrugTypes("death"),
                new DrugTypes("hate"),

            };
            ViewData["drugTypes"] = drugTypes;
            return View();
        }
    }
}
