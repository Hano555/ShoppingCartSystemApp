namespace ShoppingCartSystem
{
    public class CartData
    {
        public DateTime LastUpdated { get; set; }
        public List<Product> Products { get; set; } = [];
    }
}