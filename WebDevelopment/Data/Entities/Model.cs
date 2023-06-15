using System.ComponentModel.DataAnnotations.Schema;

namespace Car_Sales.Entities
{
    public class Model : EntityBase
    {
        [ForeignKey("Make")]
        public int MakeId { get; set; }
        public virtual Make Make { get; set; } = new Make();
        public virtual ICollection<Car> Cars { get; set; } = new List<Car>();
        public string Name { get; set; } = "";
    }
}
