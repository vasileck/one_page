using Microsoft.AspNetCore.Mvc;
using Test_one_page.Application.Interfaces;

namespace Test_one_page.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        
        
            private readonly IBookRepository _repository;

            public BookController(IBookRepository repository)
            {
                _repository = repository;
            }

        [HttpGet("suggestions")]
        public async Task<IActionResult> GetSuggestions(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return BadRequest("Query cannot be empty.");
            }

            // Выполнение поиска по названию книги, где начало названия совпадает с введенным запросом
            var results = await _repository.SearchSuggestionsAsync(query.ToLower());

            return Ok(results);
        }




    }
}
