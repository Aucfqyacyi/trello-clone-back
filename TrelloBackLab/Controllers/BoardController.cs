﻿using Microsoft.AspNetCore.Mvc;
using TrelloBackLab.Services;
using TrelloBackLab.ViewModels;

namespace TrelloBackLab.Controllers
{
    using Services;
    using ViewModels;

    public class BoardController : Controller
    {
        private readonly BoardService _boardService;

        public BoardController(BoardService boardService)
        {
            _boardService = boardService;
        }

        public IActionResult Index(int id)
        {
            var model = _boardService.GetBoard(id);

            return View(model);
        }

        public IActionResult Details(int id)
        {
            return View(_boardService.GetBoard(id));
        }

        public IActionResult AddCard(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCard(AddCard viewModel)
        {
            if (!ModelState.IsValid) return View(viewModel);

            _boardService.AddCard(viewModel);
            
            return RedirectToAction(nameof(Index), new { id = viewModel.Id });
        }
    }
}