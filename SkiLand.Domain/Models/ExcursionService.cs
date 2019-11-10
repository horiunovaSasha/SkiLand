namespace SkiLand.Domain.Models
{
    public class ExcursionService : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
