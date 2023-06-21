namespace WebDevelopment.Controllers
{
	public class CarModel
	{
		public int Id { get; set; }

		public string Make { get; set; } = "";
		public string Model { get; set; } = "";
		public Car Car { get; set; } = new Car();
		

		
	}
}
