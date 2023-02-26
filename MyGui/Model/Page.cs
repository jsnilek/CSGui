using System;
using System.Collections.Generic;

namespace MyGui
{
    public partial class Page
    {
        public string Text;
        public List<int> Links;
        public List<Spell> Spells = null;
        public List<Enemy> Enemies = null;

        public string SerializePageLinks()
        {
            return SerializeList(Links);
        }

        public string SerializePageSpells()
        {
            return "spells=" + SerializeList(Spells);
        }

        public string SerializePageEnemies()
        {
            return "enemies=" + SerializeList(Enemies);
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
            var retString = Text.Replace(Environment.NewLine, "\\n") + ';' + SerializePageLinks();
            if (Spells != null)
                retString += ';' + SerializePageSpells();
            if (Enemies != null)
                retString += ';' + SerializePageEnemies();
            return retString;
        }
    }
}
