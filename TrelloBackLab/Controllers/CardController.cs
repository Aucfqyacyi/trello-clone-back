using Microsoft.AspNetCore.Mvc;
using TrelloBackLab.Services;
using TrelloBackLab.ViewModels;

namespace TrelloBackLab.Controllers
{
    using Services;
    using ViewModels;

    public class CardController : Controller
    {
        private readonly CardService _cardService;

        public CardController(CardService cardService)
        {
            _cardService = cardService;
        }
        
        [HttpGet]
        public IActionResult Details(int id)
        {
            var viewModel = _cardService.GetDetails(id);

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Update(CardDetails cardDetails)
        {
            _cardService.Update(cardDetails);

            TempData["Message"] = "Saved card Details";

            return RedirectToAction(nameof(Details), new { id = cardDetails.Id });
        }
    }
}