namespace MVC_Storage.Models.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public string Name { get; set; } = string.Empty;
        public int InventoryValue { get; set; }
    }
}
/*
 * public void CalculateInventoryValue()
{
    InventoryValue = Count * Price;
}
public int InventoryValue
{
    get
    {
        return Count * Price;
    }
}*/

