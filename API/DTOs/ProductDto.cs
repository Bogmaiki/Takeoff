namespace API.DTOs
{
    public class ProductDto
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
        public ICollection<string> Sizes { get; set; }
    }
}
