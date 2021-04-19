using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Avtosolon.Data.Models
{
    public class Korzina
    {
        private readonly DBContent dBContent;
        public Korzina(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }

        public string IdKorzini { get; set; }
        public List<DanniyeKorzini> spisokdannix { get; set; }

        public static Korzina Sessiyi(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<DBContent>();
            string IdDlyaKorzini = session.GetString("Key") ?? Guid.NewGuid().ToString();
            session.SetString("Key", IdDlyaKorzini);

            return new Korzina(context) { IdKorzini = IdDlyaKorzini };
        }

        public void AddElementi(InfoCar Car)
        {
            dBContent.danniyeKorzini.Add(
                new DanniyeKorzini
                {
                    IdKorzini = IdKorzini,
                    Cars = Car,
                    price = Car.Price,
                    Image = Car.Image
                }); 
            dBContent.SaveChanges();
        }
         
        public List<DanniyeKorzini> noviyedanniye()
        {
            return dBContent.danniyeKorzini.Where(c => c.IdKorzini == IdKorzini).Include(p => p.Cars).ToList();
        }
        
    }
}
