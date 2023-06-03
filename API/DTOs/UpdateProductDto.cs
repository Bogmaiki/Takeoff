using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class UpdateProductDto
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [Range(100, Double.PositiveInfinity)]
        public long Price { get; set; }
        public IFormFile File { get; set; }
        [Required]
        public string Collection { get; set; }
        [Required]
        [Range(0, 200)]
        public int QuantityInStock { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string Condition { get; set; }
        [Required]
        public string Style { get; set; }
        [Required]
        public string Size { get; set; }
    }
}