using Microsoft.AspNetCore.Mvc;

namespace Store.Wen.Controllers
{
    public class SearchController(IBookRepository bookRepository) : Controller
    {
        private readonly IBookRepository bookRepository = bookRepository;

        public IActionResult Index([FromForm] string query)
        {
            Console.WriteLine(query);
            var books = bookRepository.GetAllByTitle(query);
            return View(books);
        }
    }
}
