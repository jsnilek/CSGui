using System;
using System.Collections.Generic;

namespace MyGui
{
    public partial class Page
    {
        public string PageText;
        public List<int> PageLinks;
        public List<Spell> PageSpells = null;
        public List<Enemy> PageEnemies = null;

        public string SerializePageLinks()
        {
            return SerializeList(PageLinks);
        }

        public string SerializePageSpells()
        {
            return "spells=" + SerializeList(PageSpells);
        }

        public string SerializePageEnemies()
        {
            return "enemies=" + SerializeList(PageEnemies);
        }

        private string SerializeList<T>(List<T> list)
        {
            if (list == null) return "";
            string retVal = list[0].ToString();
            for (int i = 1; i < list.Count; i++)
            {
                retVal += ',' + list[i].ToString();
            }
            return retVal;
        }

        public override string ToString()
        {
            var retString = PageText.Replace(Environment.NewLine, "\\n") + ';' + SerializePageLinks();
            if (PageSpells != null)
                retString += ';' + SerializePageSpells();
            if (PageEnemies != null)
                retString += ';' + SerializePageEnemies();
            return retString;
        }
    }
}
