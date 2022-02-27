using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGui
{
    public static class BookUtilities
    {
        private static List<string> MyBooks = new List<string> { "1The_Shamutanti_Hills_byLines", "", "", "" };

        public static string GetBookPath(int book)
        {
            return MyBooks[book];
        }

        public static List<Page> LoadBook(string path)
        {
            path += ".txt";
            var counter = 0;
            var pages = new List<Page>();
            foreach (string line in File.ReadLines(path))
            {
                pages.Add(ProcessLine(line, counter++));
            }
            return pages;
        }

        private static Page ProcessLine(string line, int lineNumber)
        {
            var lineSplit = line.Split(';');
            var textSplit = lineSplit[0].Replace("\\n", Environment.NewLine);
            var linkSpilt = ParseLinks(lineSplit[1]);
            List<Page.Spell> spellSpilt = null;
            List<Enemy> EnemiesSpilt = null;

            for (int i = 2; i < lineSplit.Length; i++)
            {
                var word = lineSplit[i].Split('=');
                switch (word[0])
                {
                    case "spells":
                        {
                            spellSpilt = ParseClass(word[1], l => new Page.Spell(l));
                            break;
                        }
                    case "enemies":
                        {
                            EnemiesSpilt = ParseClass(word[1], l => new Enemy(l));
                            break;
                        }
                    default:
                        {
                            break;
                            //                            throw new Exception("unknown atribute");
                        }
                }
            }

            return new Page
            {
                PageText = textSplit,
                PageLinks = linkSpilt,
                PageSpells = spellSpilt,
                PageEnemies = EnemiesSpilt,
            };
        }

        public static List<int> ParseLinks(string lineSplit)
        {
            var links = lineSplit.Contains(',') ? lineSplit.Split(',') : new string[] { lineSplit };
            return links.Select(int.Parse).ToList();
        }

        public static List<T> ParseClass<T>(string lineSplit, Func<string, T> create)
        {
            List<T> list = new List<T>();
            var EnemySplit = lineSplit.Contains(',') ? lineSplit.Split(',') : new string[] { lineSplit };
            foreach (var enemyString in EnemySplit)
            {
                list.Add(create(enemyString));
            }
            return list;
        }

        public static void WriteBook(string path, List<Page> pages)
        {
            path += ".txt";
            File.WriteAllLines(path, pages.Select(x => x.ToString()).ToArray());
        }
    }
}
