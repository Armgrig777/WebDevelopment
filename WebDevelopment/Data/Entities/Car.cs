namespace Car_Sales.Entities
{
    public class Car : EntityBase
    {
        public virtual Model Model { get; set; } = new Model();
        public virtual Type Type { get; set; } = new Type();
        public int? Year { get; set; }
        public string? Color { get; set; } = "";
        public decimal? Price { get; set; }
        public int? Mileage { get; set; }
        public string? Vin { get; set; } = "";
        public Images? MainImage => Images.FirstOrDefault();
        public virtual ICollection<Images> Images { get; set; } = new List<Images>();


    }
}
