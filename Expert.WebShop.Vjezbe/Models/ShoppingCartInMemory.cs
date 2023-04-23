using System.Diagnostics.Contracts;
using System.Net.Http.Json;

namespace Expert.WebShop.Vjezbe.Models
{
    public class ShoppingCartInMemory
    {
        private readonly HttpClient _httpClient;
        public List<Product> selectedItems { get; set; } = new();

        //konstruktor klase
        public ShoppingCartInMemory(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        ///  Ovo je metoda za dodavanje u košaricu
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public async Task AddToShoppingCart(int productId)
        {
            //ovo mi je komentar
            var result = await _httpClient
                .GetAsync($"https://expertshopapi.azurewebsites.net/api/Products/{productId}");

            if (result.IsSuccessStatusCode)
            {
                var addProduct = await result.Content.ReadFromJsonAsync<Product>();
                selectedItems.Add(addProduct);
            }
        }
    }
}