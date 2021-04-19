using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Avtosolon.Data.Models.Interface;
using Avtosolon.ViewResultModel;
using Microsoft.AspNetCore.Mvc;

namespace Avtosolon.Controllers
{
    public class HomeController : Controller
    {
        private readonly IInfoCar _car;
        public HomeController(IInfoCar _car)
        {
            this._car = _car;
        }

        public ViewResult Index()
        {
            var obj = new HomeViewModel();
            obj.izbrinniy = _car.FavouriteCars;
            return View(obj);
        }

        public ViewResult Contact()
        {

            return View();
        }
    }
}