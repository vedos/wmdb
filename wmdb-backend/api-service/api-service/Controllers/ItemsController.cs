using api_service.Controllers.Base;
using api_service.Model;
using api_service.Model.RestModels;
using api_service.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.Kestrel.Core.Features;

namespace api_service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : BaseController<Item, ItemRepository>
    {
        private ItemRepository _itemRepository;
        public ItemsController(ItemRepository repository) : base(repository)
        {
            _itemRepository = repository;
        }


        [HttpGet("Search")]
        public IActionResult Search(
            [FromQuery(Name = "search")] string search,
            [FromQuery(Name = "category")] string category,
            [FromQuery(Name = "pageSize")] int pageSize,
            [FromQuery(Name = "page")] int page)
        {
            return Ok(_itemRepository.GetItems(category,search,page, pageSize));
        }

        [HttpPost("Rate")]
        public IActionResult Rate(Rate rating)
        {
            return Ok(_itemRepository.Rate(rating));
        }
    }
}
