using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Sales.Entities
{
    public class Image : EntityBase
    {
        public byte[] ImageUrl { get; set; } = new byte[0];
        [ForeignKey("Car")]
        public int? CarId { get; set; }
        public  virtual Car Car { get; set; } = new Car();
    }
}
