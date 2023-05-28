using API.Data;
using API.DTOs;
using API.Entities;
using API.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ProductsController : BaseApiController
    {
        private readonly StoreContext _context;

        public ProductsController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetProducts(string orderBy,
            string searchTerm, string Collections, string Sizes)
        {
            var query = _context.Products.Include(p => p.Sizes)
                .Sort(orderBy)
                .Search(searchTerm)
                .Filter(Collections, Sizes)
                .AsQueryable();

            var products = await query.ToListAsync();
            var productDtos = products.Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                PictureUrl = product.PictureUrl,
                Collection = product.Collection,
                QuantityInStock = product.QuantityInStock,
                ReleaseDate = product.ReleaseDate,
                Condition = product.Condition,
                Style = product.Style,
                Sizes = product.Sizes?.Select(s => s.Value).ToList()
            }).ToList();

            return Ok(productDtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDto>> GetProduct(int id)
        {
            var product = await _context.Products
                .Include(p => p.Sizes)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) return NotFound();

            var productDto = new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                PictureUrl = product.PictureUrl,
                Collection = product.Collection,
                QuantityInStock = product.QuantityInStock,
                ReleaseDate = product.ReleaseDate,
                Condition = product.Condition,
                Style = product.Style,
                Sizes = product.Sizes?.Select(s => s.Value).ToList()
            };

            return productDto;
        }
    }
}
