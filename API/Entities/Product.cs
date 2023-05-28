using System.Text.Json.Serialization;

namespace API.Entities
{
    public class Size
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int ProductId { get; set; }
        
        [JsonIgnore]
        public Product Product { get; set; }
    }

    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }
        public string PictureUrl { get; set; }
        public string Collection { get; set; }
        public int QuantityInStock { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Condition { get; set; }
        public string Style { get; set; }

        [JsonIgnore]
        public ICollection<Size> Sizes { get; set; }
    }
}
