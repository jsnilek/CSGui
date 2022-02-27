namespace MyGui
{
    public partial class Page
    {
        public struct Spell
        {
            public readonly string Name;
            public readonly int Page;

            public Spell(string spellString)
            {
                var split = spellString.Split('-');
                Name = split[0];
                Page = int.Parse(split[1]);
            }

            public override string ToString()
            {
                return $"{Name}-{Page}";
            }
        }
    }
}
