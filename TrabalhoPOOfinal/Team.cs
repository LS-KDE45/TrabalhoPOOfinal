using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOfinal
{
    public class Team
    {
        public string Name { get; set; }

        int Budget { get; set; }

        public List<Horse> Horses { get; set; }
        public List<Grayhound> Grayhounds { get; set; }

        // public List<Staff> Staff { get; set; }
    public List<Trainer> trainers { get; set; }
        public List<Jockey> jockeys { get; set; }

        public Team(string name, int budget)
        {
            Name = name;
            Budget = budget;
            Horses = new List<Horse>();
            Grayhounds = new List<Grayhound>();
        }

        public Team(string name, List<Horse> horses)
        {
            Horses = horses;
            Name = name;
            Budget = new Random().Next(400, 1100);

        }

        public void BuyTrainer(Marketplace marketplace, Trainer trainer)
        {
            trainers.Add(trainer);
            marketplace.Removertrainer(trainer);
            Budget -= ((int)trainer.Salary);
        }

        public void BuyJockey(Marketplace marketplace, Jockey jockey)
        {
            jockeys.Add(jockey);
            marketplace.RemoveJockey(jockey);
            Budget -= (int)jockey.Salary;
        }

        public void BuyAnimal(Marketplace marketplace, Animal animal)
        {
            if (animal is Horse)
            {
                Horses.Add((Horse)animal);
                marketplace.RemoveAnimal(animal);

            }

            else if (animal is Grayhound)
            {
                Grayhounds.Add((Grayhound)animal);
                marketplace.RemoveAnimal(animal);
            }
        }

        public void SellAnimal(Marketplace marketplace, Animal animal)
        {
            if (animal is Horse)
            {
                Horses.Remove((Horse)animal);
                marketplace.RemoveAnimal(animal);
            }
            else if (animal is Grayhound)
            {
                Grayhounds.Remove((Grayhound)animal);
                marketplace.RemoveAnimal(animal);
            }
        }

        public void TrainAnimal(Animal animal, int investment, Trainer trainer)
        {
            animal.Train(trainer, investment / 100);
        }

        public void Breed(Animal animal1, Animal animal2, Trainer trainer)
        {
            if (animal1 is Horse && animal2 is Horse)
            {
                var horse1 = (Horse)animal1;
                horse1.Breed(horse1, (Horse)animal2, trainer);
            }
            else if (animal1 is Grayhound && animal2 is Horse || animal1 is Horse && animal2 is Grayhound)
            {
                //dá erro 
            }
            else if (animal1 is Grayhound && animal2 is Grayhound)
            {
                var grayhound1 = (Grayhound)animal1;
                grayhound1.Breed(grayhound1, (Grayhound)animal2, trainer);
            }
        }


    }
}
