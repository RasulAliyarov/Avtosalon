using Avtosolon.Data.Models;
using Avtosolon.Data.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Avtosolon.Data.Repository
{
    public class CategoryRepository : ICategories
    {
        private readonly DBContent dBContent;

        public CategoryRepository(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }
        public IEnumerable<Categories> Icategory => dBContent.dbCategories;
    }
}
