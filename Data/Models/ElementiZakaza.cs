namespace Avtosolon.Data.Models
{
    public class ElementiZakaza
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int IdZakaza { get; set; }
        public virtual InfoCar GetInfo { get; set; }
        public virtual Zakaz GetZakaz { get; set; }
    }
}
