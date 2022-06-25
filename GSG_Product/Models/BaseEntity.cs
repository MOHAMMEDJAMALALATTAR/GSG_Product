namespace GSG_Product.Models
{
    public class BaseEntity
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public double? Price { get; set; }

        public BaseEntity()
        {
            Price = 100;
        }
    }
}
