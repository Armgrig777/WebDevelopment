using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using WebDevelopment.Data.Entities;

namespace Car_Sales.Entities
{
	public class Car : EntityBase
	{
		public string UserID { get; set; } = "";

		[ForeignKey("Model")]
		public int? ModelId { get; set; }
		public virtual Model Model { get; set; } = new Model();

		public Types Type { get; set; }
		public Fuel Fuel { get; set; }
		public GearBox GearBox { get; set; }
		public Colors Color { get; set; }
		public double? EngineSize { get; set; }
		public int? Power { get; set; }
		public int? Doors { get; set; }
		public int? Seats { get; set; }
		public int? Year { get; set; }
		public decimal? Price { get; set; }
		public int? Mileage { get; set; }
		public string? Vin { get; set; } = "";
		public Image? MainImage => Images.FirstOrDefault();
		public virtual ICollection<Image> Images { get; set; } = new List<Image>();
	}
}
