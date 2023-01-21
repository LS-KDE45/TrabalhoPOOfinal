using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOfinal
{
    public class Marketplace
    {

        public List<Animal> animals;
        public List<Jockey> jockeys;
        public List<Trainer> trainers;


        public Marketplace(List<Animal> animals, List<Jockey> jockeys, List<Trainer> trainers)
        {
        animals = new List<Animal>();
        }


        public void addJockey(Jockey jockey)
        {
            jockeys.Add(jockey);
        }

        public void addTrainer(Trainer trainer)
        {
            trainers.Add(trainer);
        }


        public void Removertrainer(Trainer trainer)
        {
            trainers.Remove(trainer);
        }

        public void RemoveJockey(Jockey jockey)
        {
            jockeys.Remove(jockey);
        }



        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }

        public void AvailableStaffJockeys()
        {
            foreach (Jockey jockey in jockeys)
            {
                Console.WriteLine("" + jockey.Name + jockey.Salary);
            }
        }

        public void AvailableStaffTrainers()
        {
            foreach (Trainer trainer in trainers)
            {
                Console.WriteLine("" + trainer.Name + trainer.Salary);
            }
        }


        public void DisplayHorses()
        {
            foreach (Animal animal in animals)
            {
                if (animal is Horse)
                {
                    Horse DisplayHorse = (Horse)animal;
                    Console.WriteLine(DisplayHorse.ToString());
                }
            }
        }

        public void DisplayGreyHounds()
        {
            foreach (Animal animal in animals)
            {
                if (animal is Grayhound)
                {
                    Grayhound DisplayGrayhound = (Grayhound)animal;
                    Console.WriteLine(DisplayGrayhound.ToString());
                }
            }
        }

    }
}

