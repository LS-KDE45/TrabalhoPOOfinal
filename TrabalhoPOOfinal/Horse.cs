using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOfinal
{

    public enum Sexo
    {
        M,
        F
    }
    public class Horse : Animal
    {
        public string Name { get; set; }
        public Sexo Sex { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public float value;
        public float Score;

        public Horse()
        {

            List<string> names = new List<string> { "Thunder", "Lightning", "Storm", "Rain", "Cloud", "Sky" };
            Name = names[new Random().Next(names.Count)];

            int x = new Random().Next(2);
            if(x == 1)
            {
                Sex = Sexo.M;
            }
            else Sex= Sexo.F;

            Speed = new Random().Next(1, 11);
            Stamina = new Random().Next(1, 11);
            Age = new Random().Next(1, 11);
            Experience = new Random().Next(1, 11);

        }


        public Horse(string name, Sexo sex, int speed, int stamina, int age, int experience)
        {
            Name = name;
            Sex = sex;
            Speed = speed;
            Stamina = stamina;
            Age = age;
            Experience = experience;
        }

        public float CalculateScore()
        {
            int score = (Speed * 2) + (Stamina * 3) + (Age * 1) + (Experience * 3);
            Score = score;
            return score;
        }

        public decimal CalculateOdds()
        {
            // ajustar formula
            decimal odds = (Speed + Stamina + Experience) / Age;
            return odds;
        }

        public void Train(Trainer trainer, int intensity)
        {
            int addscore = trainer.GenerateScore() * intensity;
            this.Stamina += addscore;
            this.Experience += addscore;
            this.Speed += addscore;
        }

        public Horse Breed(Horse horse1, Horse horse2, Trainer trainer)
        {
            Horse child = new Horse();
            child.Name = "";
            child.Stamina = (int)((horse1.Stamina + horse2.Stamina) / 2 + trainer.GenerateScore() * 0.1);
            child.Speed = (int)((horse1.Speed + horse2.Speed) / 2 + trainer.GenerateScore() * 0.1);
            child.Stamina = (int)((horse1.Experience + horse2.Experience) / 2 + trainer.GenerateScore() * 0.1);
            return child;
        }

        public override string ToString()
        {
            return Name.ToString() + " " + Sex.ToString() + " " + Age.ToString() + "\n";
        }


    }
}
