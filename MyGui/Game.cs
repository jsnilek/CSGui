using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGui
{
    public sealed class Game
    {
        private static readonly Game instance = new Game();

        static Game() { }
        private Game() { }
        public static Game Instance { get { return instance; } }
        public Player GamePlayer { get; private set; }
        public int CurrentPageNumber { get; private set; } = 0;
        public List<Page> Pages = null;

        internal void Run()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindow());
        }

        public void StartGame(Player.PlayerClass? role = null)
        {
            Player.PlayerClass selectedRole = (Player.PlayerClass)((role != null) ? role : MainWindow.AskForClass());
            GamePlayer = Player.GenerateNewPlayer(selectedRole);
            CurrentPageNumber = 1;
        }

        public void LoadBook(int book)
        {
            Pages = BookUtilities.LoadBook(BookUtilities.GetBookPath(book));
            CurrentPageNumber = 0;
        }

        public Page GetCurrentPage() { return Pages[CurrentPageNumber]; }
        public Page TurnToPage(int page)
        {
            CurrentPageNumber = page;
            return Pages[page];
        }
    }
}
