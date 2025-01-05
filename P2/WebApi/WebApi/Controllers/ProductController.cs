using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UtilsApp.DTOs;
using WebApi.Model;
using WebApi.Repository.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        { 
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            try
            {
                var productsDto = (await _productRepository.GetAllWithUser())
                .Select(product => new ProductDTO
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Status = product.Status,
                    CreatedByUserId = product.CreatedByUserId,
                    CreatedByUser = product.CreatedByUser.Name,
                    UpdatedByUserId = product?.UpdatedByUserId ?? 0,
                    UpdatedByUser = product?.UpdatedByUser?.Name ?? ""
                })
                .ToList();

                return Ok(productsDto);    
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            try
            {
                var product = await _productRepository.GetById(id);

                var productDto = new ProductDTO
                {
                    Id = product.Id,
                    Name = product.Name,
                    Price = product.Price,
                    Status = product.Status,
                    CreatedByUserId = product.CreatedByUserId,
                    CreatedByUser = product.CreatedByUser.Name,
                    UpdatedByUserId = product?.UpdatedByUserId ?? 0,
                    UpdatedByUser = product?.UpdatedByUser?.Name ?? ""
                };

                return Ok(productDto);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]  
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            try
            {
                await _productRepository.Create(product);

                return Created("", new object { });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            try
            {
                await _productRepository.Update(product);

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromRoute] int id)
        {
            try
            {
                await _productRepository.Delete(id);    

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
