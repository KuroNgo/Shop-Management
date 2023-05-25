using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyShopNet7.Entities;

namespace MyShopNet7.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly MyshopContext _context;
        public CategoriesController(MyshopContext ctx)
        {
            _context = ctx;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_context.Categories.ToList());
        }
    }
}
