using System.Collections.Generic;

namespace Avtosolon.Data.Models
{
    public class Categories
    {
        public string CategoryName { get; set; }
        public int Id { get; set; }
        public string CatDesc { get; set; }
        public List<InfoCar> CarsList { get; set; }  
    }
}
