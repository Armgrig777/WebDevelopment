namespace Car_Sales.Entities
{
    public class Image : EntityBase
    {
        public byte[] Image { get; set; } = new byte[0];
        public  virtual Car Car { get; set; } = new Car();
    }
}
