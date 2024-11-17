using Test_one_page.Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Test_one_page.Domain.Entities;
using Test_one_page.Infrastructure.Data;

namespace Test_one_page.Infrastructure.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _context;

        public BookRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> SearchSuggestionsAsync(string query)
        {
            query = query.ToLower();

            return await _context.Books
                .Where(b => b.Title.ToLower().Contains(query) || b.Author.ToLower().Contains(query))
                .Take(10)
                .ToListAsync();
        }

    }
}
