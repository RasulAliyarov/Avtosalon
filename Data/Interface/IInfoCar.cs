using Avtosolon.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtosolon.Data.Models.Interface
{
    public interface IInfoCar
    {
        IEnumerable<InfoCar> Cars { get;  }
        IEnumerable<InfoCar> FavouriteCars { get;  }
        InfoCar OneCar(int carid);
    }
}
