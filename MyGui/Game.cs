using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGui
{
    public class Game
    {
        public Game()
        {
            LoadBook(0);
        }

        public bool IsGameOn;
        public Player GamePlayer { get; private set; }
        public int CurrentPageNumber { get; private set; } = 0;
        public List<Page> Pages = null;

        public void StartGame(Player.PlayerClass role)
        {
            GamePlayer = Player.GenerateNewPlayer(role);
            CurrentPageNumber = 1;
            IsGameOn = true;
        }

        public void LoadBook(int book)
        {
            Pages = BookUtilities.LoadBook(BookUtilities.GetBookPath(book));
            CurrentPageNumber = 0;
        }

        public Page GetCurrentPage() { return Pages[CurrentPageNumber]; }
        public Page GetNewPage(int page)
        {
            CurrentPageNumber = page;
            return Pages[page];
        }
    }
}
