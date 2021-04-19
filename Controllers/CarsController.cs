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
    public class CarsController : Controller
    {
        private readonly IInfoCar _infoCar;
        private readonly ICategories _categories;
        public CarsController(IInfoCar _infoCar, ICategories _categories)
        {
            this._categories = _categories;
            this._infoCar = _infoCar;
        }
        [Route("Cars/LIST")]
        [Route("Cars/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<InfoCar> mashini = null;
            string nazvaniyecategoriy = "";

            if (string.IsNullOrEmpty(category))
            {
                mashini = _infoCar.Cars.OrderBy(i => i.Id);
            }
            else
            {
                if (string.Equals("electro", category, StringComparison.OrdinalIgnoreCase))
                {
                    mashini = _infoCar.Cars.Where(i => i.Categories.CategoryName.Equals("Электромашины"));
                    nazvaniyecategoriy = "Электромашины";
                }
                else if (string.Equals("fuel", category, StringComparison.OrdinalIgnoreCase))
                {
                    mashini = _infoCar.Cars.Where(i => i.Categories.CategoryName.Equals("Классические машины"));
                    nazvaniyecategoriy = "Классические машины";
                }
            }

            var obj = new ViewResultCars()
            {
                info = mashini,
                somestring = nazvaniyecategoriy
            };
          //  ViewResultCars obj = new ViewResultCars();
          //  obj.info = _infoCar.Cars;
         //   obj.somestring = "Все автомобили";

            return View(obj);
        }
    }
}