using Avtosolon.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtosolon.ViewResultModel
{
    public class ViewResultCars
    {
        public IEnumerable<InfoCar> info { get; set; }
        public string somestring;
    }
}
