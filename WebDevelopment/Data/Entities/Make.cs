namespace Car_Sales.Entities
{
    public class Make : EntityBase
    {
        public string Name { get; set; } = "";
        public virtual ICollection<Model> Models { get; set; } = new List<Model>();
    }
}