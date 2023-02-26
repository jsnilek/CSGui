using System;

namespace MyGui
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Game.Instance.Run();
        }
    }
}
