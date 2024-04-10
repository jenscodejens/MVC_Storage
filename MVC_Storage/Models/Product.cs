namespace MVC_Storage.Models
{
    public class Product
    {
        public int Id { get; set; } = 0;
        public int Price { get; set; } = 0;
        public int Count { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Shelf { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Orderdate { get; set; } = DateTime.Now;
    }
}
