using System.Diagnostics.Contracts;

namespace Expert.WebShop.Vjezbe.Models
{
    public class ShoppingCartInMemory
    {
        private readonly HttpClient _httpClient;
        private List<ShoppingCart> SelectedItems { get; set; } = new();

        //konstruktor klase
        public ShoppingCartInMemory(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
    }
}