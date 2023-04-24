namespace Expert.WebShop.Vjezbe.Models
{
    public class ShoppingCart
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int NumberOfItems { get; set; }
        //public string OrderedByName { get; set; }
        //public string OrderedByEmail { get; set; }
        //public string ShipingAddress { get; set; }
        //public string OrderId { get; set; }
    }
}