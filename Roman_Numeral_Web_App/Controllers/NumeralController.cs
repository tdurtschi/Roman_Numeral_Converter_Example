using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Roman_Numeral_Web_App.Controllers
{
    public class NumeralController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult convert(Models.NumeralsViewModel model)
        {
            model.Arabic_Numerals = RomanNumeral.RomanNumeralConverter.Convert(model.Roman_Numerals);

            return Json(model);
        }
    }
}
