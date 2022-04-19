namespace Abstraindo_um_jogo_de_RPG.src
{
    public abstract class Hero
    {
        public Hero(string Name, int level, string HeroType) {
            this.Name = Name;
            this.level = level;
            this.HeroType = HeroType; 
        }

        public Hero(){

        }

        public string Name;

        public int level;

        public string HeroiType;


        public override string Tostring(){
            return this.Name + " " + this.level +" " this.HeroType;
        }

        public virtual string Atack(){
            return this.Name + "Lançou Magia";
        }

        public string Atack(int Bonus){

            if(Bonus > 6){
                return this.Name + "Lançou Magia efetiva com bonus de" + Bonus;
            }else{
                return this.Name + "Lançou uma magia com força fraca com bonus de" + Bonus;
            }
        }
    }
}