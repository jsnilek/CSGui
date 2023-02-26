namespace MyGui
{
    public class Enemy
    {
        public int Stamina, AP;
        public string Name;
        //public Enemy(string name, int stamina, int ap)
        //{
        //    Name = name;
        //    Stamina = stamina;
        //    Ap = ap;
        //}

        public Enemy(string EnemyString)
        {
            var split = EnemyString.Split('-');
            Name = split[0];
            AP = int.Parse(split[1]);
            Stamina = int.Parse(split[2]);
        }

        public override string ToString()
        {
            return $"{Name}-{AP}-{Stamina}";
        }
    }
}
