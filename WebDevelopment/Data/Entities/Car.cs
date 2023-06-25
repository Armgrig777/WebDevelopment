using System.ComponentModel.DataAnnotations.Schema;
using WebDevelopment.Data.Entities;

namespace Car_Sales.Entities
{
    public class Car : EntityBase
    {
        [ForeignKey("Model")]
        public int ModelId { get; set; }    
        public virtual Model Model { get; set; } = new Model();
		
        [ForeignKey("Make")]
        public int MakeId { get; set; }
		public virtual Make Make { get; set; } = new Make();
		
		public  Types Type { get; set; } 
        public  Fuel Fuel { get; set; } 
        public  GearBox GearBox{ get; set; } 
        public  Color Color { get; set; }
        public  double? EngineSize { get; set; }
        public int? Power { get; set; }
        public  int? Doors { get; set; }
        public int? Seats { get; set; }
        public int? Year { get; set; }
        public decimal? Price { get; set; }
        public int? Mileage { get; set; }
        public string? Vin { get; set; } = "";
        public Image? MainImage => Images.FirstOrDefault();
        public virtual ICollection<Image> Images { get; set; } = new List<Image>();


    }
}
