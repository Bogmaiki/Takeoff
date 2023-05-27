namespace API.DTOs
{
    public class CartItemDto
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public long Price { get; set; }
        public string PictureUrl { get; set; }
        public List<float> Sizes { get; set; }
        public string Collection { get; set; }
        public int Quantity { get; set; }
    }
}