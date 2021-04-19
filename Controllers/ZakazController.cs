using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avtosolon.Data;
using Avtosolon.Data.Interface;
using Avtosolon.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Avtosolon.Controllers
{
    public class ZakazController : Controller
    {
        private readonly IZakaz _zakaz;
        private readonly Korzina _korzina;
        public ZakazController(IZakaz _zakaz, Korzina _korzina)
        {
            this._zakaz = _zakaz;
            this._korzina = _korzina;
        }
        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Zakaz zakaz)
        {
            _korzina.spisokdannix = _korzina.noviyedanniye();

            if(ModelState.IsValid)
            {
                _zakaz.sozdaniyeZakaza(zakaz);
               return RedirectToAction("Views");
            }
            return View(zakaz);
        }

        public IActionResult Views()
        {
            return View();
        }
    }
}