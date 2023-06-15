using System.ComponentModel.DataAnnotations;

namespace Car_Sales.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
