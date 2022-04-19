namespace Abstraindo_um_jogo_de_RPG.src
{
    public class wizard : Hero
    {

        public Wizard(string Name, int level, string HeroType)
        {
            this.Name = Name;
            this.level = Level;
            this.HeroType = HeroType;
        }
        
       public override string Atack(){
           return this.Name + "Lançou Magia";
       } 
    }
}