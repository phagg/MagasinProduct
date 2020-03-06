using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MagasinProduct.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IEnumerable<Product> Products;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

            string jsonFile;
            using (var r = new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "data\\products.json")))
            {
                jsonFile = r.ReadToEnd();
            }
            Products = JsonSerializer.Deserialize<List<Product>>(jsonFile);
        }

        public class Product
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
            [JsonPropertyName("fromPrice")]
            public string FromPrice { get; set; }
            [JsonPropertyName("image")]
            public string Image { get; set; }
            [JsonPropertyName("description")]
            public string Description { get; set; }
        }
    }
}
