using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Practice.API.Entities;
using Practice.API.Services;

namespace Practice.API.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController:ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ICategoryService categoryService;

        public CategoryController(IMapper mapper,ICategoryService categoryService)
        {
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            this.categoryService = categoryService ?? throw new ArgumentNullException(nameof(categoryService));
        }
        [HttpPost]
        public async Task<ActionResult<CategoryController>> AddCategory(Category category)
        {
            if (category != null)
            {
                return Ok(await categoryService.AddCategory(category));
            }
            return null;
        }
        [HttpPut("categoryId")]

        public async Task<ActionResult<CategoryController>> UpdateCategory(Category category,int categoryId)
        {
            var existCategory = await categoryService.GetCategory(categoryId);
            if (existCategory != null)
            {
                return Ok(await categoryService.UpdateCategory(category));
            }
            return null;
        }
        [HttpGet("categoryId")]
        public async Task<ActionResult<CategoryController>> GetCategory( int categoryId)
        {           
            if (categoryId != null)
            {
                return Ok(await categoryService.GetCategory(categoryId));
            }
            return null;
        }

        [HttpGet("allCategory")]
        public async Task<ActionResult<IEnumerable<Category>>> GetAllcategories()
        {
            return Ok(await categoryService.GetAllCategories());
        }



    }
}
