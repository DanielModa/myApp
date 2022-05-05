namespace myApp.scr.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public override string Attack(){
            return this.Name + " attack with shadows ";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
            return this.Name + " Shadow Killer, with Bonus  " + Bonus;
            }else{
                return this.Name + " Shuriken attack, with less bonus damage  " + Bonus;
            }
        }
    }
}