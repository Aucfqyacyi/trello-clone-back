﻿using System.Collections.Generic;

namespace TrelloBackLab.ViewModels
{
    public class BoardList
    {
        public List<Board> Boards = new List<Board>();

        public class Board
        {
            public int Id { get; set; }
            public string Title { get; set; }
        }
    }
}
