using BusinessObjects;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;

namespace ProductManagementMVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Product
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _productService.GetProducts();
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        // POST: api/Product
        [HttpPost]
        public ActionResult<Product> PostProduct(Product p)
        {
            _productService.SaveProduct(p);
            return CreatedAtAction(nameof(GetProduct), new { id = p.ProductID }, p);
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, Product p)
        {
            if (id != p.ProductID)
            {
                return BadRequest();
            }

            try
            {
                _productService.UpdateProduct(p);
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateConcurrencyException)
            {
                var exists = _productService.GetProductById(id) != null;
                if (!exists)
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Product/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            _productService.DeleteProduct(product);

            return NoContent();
        }
    }
}
