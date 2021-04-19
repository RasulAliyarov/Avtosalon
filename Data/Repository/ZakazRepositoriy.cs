using Avtosolon.Data.Interface;
using Avtosolon.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtosolon.Data.Repository
{
    public class ZakazRepositoriy : IZakaz
    {
        private readonly DBContent _dBContent;
        private readonly Korzina _korzina;
        public ZakazRepositoriy(DBContent _dBContent, Korzina _korzina)
        {
            this._dBContent = _dBContent;
            this._korzina = _korzina;
        }
        public void sozdaniyeZakaza(Zakaz zakaz)
        {
            zakaz.Date = DateTime.Now;
            _dBContent.dbZakaza.Add(zakaz);

            var items = _korzina.spisokdannix;
            foreach(var el in items)
            {
                var NoviyZakaz = new ElementiZakaza()
                {
                    CarId = el.Cars.Id,
                    IdZakaza = zakaz.Id
                };
                _dBContent.dbElementiZakaza.Add(NoviyZakaz);
            }
            _dBContent.SaveChanges();
        }
    }
}
