namespace myApp.scr.Entities
{
    public class BlackWizard : Hero
    {
        public BlackWizard(string Name, int Level, string HeroType, int Hp, int Mp)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.Hp = Hp;
            this.Mp = Mp;
        }
        public override string Attack(){
            return this.Name + " Superior Spells ";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
            return this.Name + " Cast Darkness Spell, with Bonus  " + Bonus;
            }else{
                return this.Name + " Cast Light Darts spell with less impact, with bonus " + Bonus;
            }
        }
    }
}   