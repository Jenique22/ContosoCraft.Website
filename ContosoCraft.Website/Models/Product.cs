using System.Text.Json;
using System.Text.Json.Serialization;

namespace ContosoCraft.Website.Models
{
    public class Product
    {// adding data to asp.net
        public string Id { get; set; }

        public string Maker { get; set; }

        [JsonPropertyName("img")] //mapping img to image
        public string Image { get; set; }

        public string Url { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int[] Ratings { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
        //=> link to, {} not needed as it is only one line
    }
}
