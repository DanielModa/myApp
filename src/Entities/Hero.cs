namespace myApp.scr.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType, int Hp, int Mp){
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }

        public Hero()
        {

        }

        public string Name;
        public int Level;
        public string HeroType;
        public int Hp;
        public int Mp;

        
        public override string ToString(){
            return this.Name + "" + " Level: " + this.Level + " | " + this.HeroType + " | " + " Hp:" + this.Hp + " Mp:"  + this.Mp;
        }

        public virtual string Attack(){
            return this.Name + " Attacked whit his sword ";
        }
    }
}