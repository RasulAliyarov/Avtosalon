using Avtosolon.Data.Models.Interface;
using Avtosolon.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtosolon.Data.Moks
{
    public class CategoryMoks : ICategories
    {
        public IEnumerable<Categories> Icategory
        {
            get
            {
                return new List<Categories>
                {
                    new Categories{CategoryName="Электромашины", CatDesc=""},
                    new Categories{CategoryName="Гибридные машины", CatDesc=""},
                    new Categories{CategoryName="Классические машины", CatDesc=""}           
                };
            }
        }
    }
}
