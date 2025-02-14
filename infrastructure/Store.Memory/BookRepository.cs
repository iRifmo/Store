using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;

namespace Store.Memory
{
    public class BookRepository : IBookRepository
    {
        private readonly Book[] books = new[]
        {
            new Book(1, "ISBN 12312-31231", "D. Knuth", "Art Of Programming", 
                        "Description of book number 1", 7.19M),
            new Book(2, "ISBN 12312-31232", "M. Fowler", "Refactoring", 
                        "Description of book number 2", 12.45M),
            new Book(3, "ISBN 12312-31233", "B. Kernighan, D. Ritchie", "C Programming Language",
                        "Description of book number 3", 14.98M),
        };

        public Book[] GetAllByIsbn(string isbn)
        {
            return books.Where(book => book.Isbn == isbn)
                        .ToArray();
        }

        public Book[] GetAllByTitleOrAuthor(string query)
        {
            return books.Where(book => book.Author.Contains(query)
                                    || book.Title.Contains(query))
                        .ToArray();
        }

        public Book GetById(int id)
        {
            return books.Single(book => book.Id == id);
        }
    }
}
