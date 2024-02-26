using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccesLayer.Concrete;
using SignalR.DtoLayer.ProductDto;
using SignalR.EntityLayer.Entities;
using SignalRApi.DAL.Entities;

namespace SignalRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
        public class ProductController : ControllerBase
        {
       
            private readonly IProductService _productService;
            private readonly IMapper _mapper;

            public ProductController(IProductService productService, IMapper mapper)
            {
                _productService = productService;
                _mapper = mapper;
            }

            [HttpGet]
            public IActionResult ProductList()
            {
                var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
                return Ok(value);
            }

            [HttpGet("ProductCount")]
            public IActionResult ProductCount()
            {
                var value = _productService.TProductCount();
                return Ok(value);
            }

		    [HttpGet("ProductCountByCategoryNameHamburger")]
		    public IActionResult ProductCountByCategoryNameHamburger()
		    {
			    return Ok(_productService.TProductCountByCategoryNameHamburger());
		    }
		
			[HttpGet("ProductCountByCategoryNameDrink")]
		    public IActionResult ProductCountByCategoryNameDrink()
		    {
			    return Ok(_productService.TProductCountByCategoryNameDrink());
		    }

		    [HttpGet("ProductPriceAvg")]
		    public IActionResult ProductPriceAvg()
		    {
			    return Ok(_productService.TProductPriceAcg());
		    }
		    [HttpGet("ProductNameByMaxPrice")]
		    public IActionResult ProductNameByMaxPrice()
		    {
			    return Ok(_productService.TProductNameByMaxPrice());
		    }
		    [HttpGet("ProductNameByMinPrice")]
		    public IActionResult ProductNameByMinPrice()
		    {
			    return Ok(_productService.TProductNameByMinPrice());
		    }

            [HttpGet ("ProductAvgPriceByHamburger")]
		    public IActionResult ProductAvgPriceByHamburger()
		    {
			    return Ok(_productService.TProductAvgPriceByHamburger());
		    }

		    [HttpGet("ProductListWithCategory")]
            public IActionResult ProductListWithCategory()
            {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Description = y.Description,
                ImageURL = y.ImageURL,
                Price = y.Price,
                ProductID = y.ProductID,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName
            });
            return Ok(values.ToList());
            }
            [HttpGet("TotalPriceByDrinkCategory")]
            public IActionResult TotalPriceByDrinkCategory()
            {
                return Ok(_productService.TTotalPriceByDrinkCategory());
            }

            [HttpGet("TotalPriceBySaladCategory")]
            public IActionResult TotalPriceBySaladCategory()
            {
                return Ok(_productService.TTotalPriceBySaladCategory());
            }
            [HttpGet("ProductPriceBySteakBurger")]
            public IActionResult ProductPriceBySteakBurger()
            {
                return Ok(_productService.TProductPriceBySteakBurger());
            }

        [HttpPost]
            public IActionResult CreateProduct(CreateProductDto createProductDto)
            {
                _productService.TAdd(new Product()
                {
                    ProductName = createProductDto.ProductName,
                    Description = createProductDto.Description,
                    Price = createProductDto.Price,
                    ImageURL = createProductDto.ImageURL,
                    ProductStatus = createProductDto.ProductStatus,
                    CategoryID = createProductDto.CategoryID
                });
                return Ok("Ürün Bilgisi Eklendi");
            }

            [HttpDelete]
            public IActionResult DeleteProduct(int id)
            {
                var value = _productService.TGetByID(id);
                _productService.TDelete(value);
                return Ok("Ürün Bilgisi Silindi");
            }

            [HttpGet("{id}")]
            public IActionResult GetProduct(int id)
            {
                var value = _productService.TGetByID(id);
                return Ok(value);
            }

            [HttpPut]
            public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
            {
                _productService.TUpdate(new Product()
                {
                    ProductID = updateProductDto.ProductID,
                    ProductName = updateProductDto.ProductName,
                    Description = updateProductDto.Description,
                    Price = updateProductDto.Price,
                    ImageURL = updateProductDto.ImageURL,
                    ProductStatus = updateProductDto.ProductStatus,
                    CategoryID = updateProductDto.CategoryID
                });
                return Ok("Ürün Bilgisi Güncellendi");
            }
        
        }
}
