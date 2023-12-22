using eshop.Application;
using eshop.Application.DataTransferObjects.Requests;
using eshop.Domains.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace eshop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //REpresentational State Transfer
        //Temsili (İstemci) Durum Transferi

        private readonly IProductService _productService;
        private readonly IMemoryCache _memoryCache;
        private readonly ILogger<ProductsController> logger;

        public ProductsController(IProductService productService, IMemoryCache memoryCache, ILogger<ProductsController> logger)
        {
            _productService = productService;
            _memoryCache = memoryCache;
            this.logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult GetProducts()
        {
            if (!_memoryCache.TryGetValue("allProducts", out CacheObject cacheObject))
            {
                var options = new MemoryCacheEntryOptions()
                                  .SetSlidingExpiration(TimeSpan.FromMinutes(1))
                                  .SetPriority(CacheItemPriority.Normal)
                                  .RegisterPostEvictionCallback((key, value, evictionReason, state) =>
                                  {
                                      //Eğer veriniz cache'den düştüğünde bir şey yapmanız gerekirse buraya yazıyorsunuz.

                                  });


                cacheObject = new CacheObject
                {
                    Products = _productService.GetProducts(),
                    CacheDate = DateTime.Now
                };
                _memoryCache.Set("allProducts", cacheObject, options);
            }
            logger.LogInformation($"{cacheObject.CacheDate} tarihinde cache'a atıldı");
            return Ok(cacheObject);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]

        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                Product product = await _productService.GetProductByIdAsync(id);
                if (product != null)
                {
                    return Ok(product);
                }
                return NotFound();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("[action]/{name}")]
        public async Task<IActionResult> SearchProductsByName(string name)
        {
            IEnumerable<Product> products = await _productService.GetProductsByName(name);
            return Ok(products);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(CreateProductRequest request)
        {
            if (ModelState.IsValid)
            {
                int createdId = await _productService.CreateProduct(request);
                return CreatedAtAction(nameof(GetById), routeValues: new { id = createdId }, null);

            }

            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, UpdateProductRequest request)
        {
            var product = await _productService.GetProductByIdAsync(id);
            if (product != null)
            {
                if (ModelState.IsValid)
                {
                    await _productService.UpdateProduct(request);
                    return Ok();
                }
                return BadRequest(ModelState);
            }

            return NotFound();
        }
    }
}
