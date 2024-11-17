using Test_one_page.Domain.Entities;


namespace Test_one_page.Application.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> SearchSuggestionsAsync(string query);
    }
}
