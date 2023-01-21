using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOfinal
{

    public class Grayhound : Animal
    {
         public string Name { get; set; }

         public Sexo Sex { get; set; }
         public int Speed { get; set; }
         public int Endurance { get; set; }
         public int Age { get; set; }
         public int Agility { get; set; }

         public int MarketVaulue;

         public Grayhound(string name, char sex, int speed, int endurance, int age, int agility)
         {
            Name = name;
            int x = new Random().Next(2);
            if (x == 1)
            {
                Sex = Sexo.M;
            }
            else Sex = Sexo.F;
            Speed = speed;
            Endurance = endurance;
            Age = age;
            Agility = agility;
         }

         public Grayhound() { }

         public decimal CalculateOdds()
         {
             decimal score = (Speed * 2) + (Endurance * 3) + (Age * 1) + (Agility * 3);
             return 1/score;
         }

         public float CalculateScore()
         {
         float odds = (Speed + Endurance + Agility) / Age;
             return odds;
         }

         public void Train(Trainer trainer, int intensity)
         {
             int addscore = trainer.GenerateScore() * intensity;
             this.Endurance += addscore;
             this.Agility += addscore;
             this.Speed += addscore;

         }
         public Grayhound Breed(Grayhound grayhound1, Grayhound grayhound2, Trainer trainer)
         {
             Grayhound child = new Grayhound();
             child.Name = "";
             child.Endurance = (int)((grayhound1.Endurance + grayhound1.Endurance) / 2 + trainer.GenerateScore() * 0.1);
             child.Speed = (int)((grayhound1.Speed + grayhound1.Speed) / 2 + trainer.GenerateScore() * 0.1);
             child.Agility = (int)((grayhound1.Agility + grayhound1.Agility) / 2 + trainer.GenerateScore() * 0.1);
             return child;
         }


         public override string ToString()
         {
            return Name.ToString() + " " + Sex.ToString() + " " + Age.ToString() + "\n";
         }

    }
}
