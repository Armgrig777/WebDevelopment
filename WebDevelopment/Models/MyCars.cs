using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations.Schema;
using WebDevelopment.Data.Entities;

namespace WebDevelopment.Models
{
    public class MyCarsModel
    {
        public int Id { get; set; }
        public string Model { get; set; }
        public string Make { get; set; }
        public string Type { get; set; }
        public string Fuel { get; set; }
        public string GearBox { get; set; }
        public string Color { get; set; }
        public double? EngineSize { get; set; }
        public int? Power { get; set; }
        public int? Doors { get; set; }
        public int? Seats { get; set; }
        public int? Year { get; set; }
        public decimal? Price { get; set; }
        public int? Mileage { get; set; }
        public string? Vin { get; set; } = "";

        public byte[]? Image => Carpics.FirstOrDefault();
        public List<byte[]> Carpics { get; set; }

    }
}
