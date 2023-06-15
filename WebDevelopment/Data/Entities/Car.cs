using WebDevelopment.Data.Entities;

namespace Car_Sales.Entities
{
    public class Car : EntityBase
    {
        public virtual Model Model { get; set; } = new Model();
        public virtual Type Type { get; set; } 
        public virtual Fuel Fuel { get; set; } 
        public virtual GearBox GearBox{ get; set; } 
        public virtual Color Color { get; set; }
        public int? Year { get; set; }
        public decimal? Price { get; set; }
        public int? Mileage { get; set; }
        public string? Vin { get; set; } = "";
        public Image? MainImage => Images.FirstOrDefault();
        public virtual ICollection<Image> Images { get; set; } = new List<Image>();


    }
}
