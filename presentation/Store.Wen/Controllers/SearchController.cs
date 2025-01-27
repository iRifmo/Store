using Microsoft.AspNetCore.Mvc;

namespace Store.Wen.Controllers
{
    public class SearchController : Controller
    {
        private readonly IBookRepository bookRepository;

        public SearchController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }
        public IActionResult Index(string query)
        {

            var books = bookRepository.GetAllByTitle(query);

            return View();
        }
    }
}
