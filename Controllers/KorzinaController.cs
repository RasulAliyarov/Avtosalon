using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avtosolon.Data.Models;
using Avtosolon.Data.Models.Interface;
using Avtosolon.ViewResultModel;
using Microsoft.AspNetCore.Mvc;

namespace Avtosolon.Controllers
{
    public class KorzinaController : Controller
    {
        private readonly IInfoCar _car;
        private readonly Korzina _korzina;
        public KorzinaController(IInfoCar _car, Korzina _korzina)
        {
            this._car = _car;
            this._korzina = _korzina;
        }
        public ViewResult Index()
        {
            var items = _korzina.noviyedanniye();
            _korzina.spisokdannix = items;
            var obj = new ViewKorzinaModel
            {
                viewkorzina = _korzina
            };
            return View(obj);
        }
        public RedirectToActionResult pereadressaciya(int id)
        {
            var item = _car.Cars.FirstOrDefault(i => i.Id == id);
            if (item != null)
            {
                _korzina.AddElementi(item);
            }
            return RedirectToAction("Index");
                
        }
    }
}