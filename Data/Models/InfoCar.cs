using Avtosolon.Data.Models;

namespace Avtosolon.Data.Models
{
    public class InfoCar
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string SortDesc { get; set; }
        public string LongDesc { get; set; }
        public bool Favourite { get; set; }
        public bool Avaible { get; set; }
        public int CatID { get; set; }
        public virtual Categories Categories { get; set; }
    }
}
