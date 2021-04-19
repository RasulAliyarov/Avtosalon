using Avtosolon.Data.Models;
using Avtosolon.Data.Models.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtosolon.Data.Repository
{
    public class CarRepository : IInfoCar
    {
        private readonly DBContent dBContent;
       
        public CarRepository(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }
        public IEnumerable<InfoCar> Cars => dBContent.dbInfoCar.Include(c => c.Categories);

        public IEnumerable<InfoCar> FavouriteCars => dBContent.dbInfoCar.Where(c => c.Favourite).Include(p => p.Categories);

        public InfoCar OneCar(int carid) => dBContent.dbInfoCar.FirstOrDefault(c => c.Id == carid);
    }
}
