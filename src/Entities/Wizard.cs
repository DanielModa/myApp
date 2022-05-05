namespace myApp.scr.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public override string Attack(){
            return this.Name + " Cast magic ";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
            return this.Name + " Cast attack spell with bonus  " + Bonus;
            }else{
                return this.Name + " Cast magic with less impact, with bonus " + Bonus;
            }
        }
    }
}