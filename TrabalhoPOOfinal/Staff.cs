using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOfinal
{
    public class Staff
    {
        public string Name { get; set; }
        public decimal Salary { get; set; }

        public Staff(string name, decimal salary)
        {
            Name = name;
            Salary = salary;
        }

        public Staff() { }
    }

    public class Jockey : Staff
    {
        public int PhysicalFitness { get; set; }
        public int RidingAbility { get; set; }
        public int RacingStrategy { get; set; }

        public Jockey(string name, int physicalFitness, int ridingAbility, int racingStrategy, decimal salary) : base(name, salary)
        {
            PhysicalFitness = physicalFitness;
            RidingAbility = ridingAbility;
            RacingStrategy = racingStrategy;
        }

        public int GenerateScore()
        {
            return PhysicalFitness + RidingAbility + RacingStrategy;
        }

        public Jockey()
        {
            List<string> firstNames = new List<string> { "John", "Jane", "Michael", "Emily", "David", "Ashley", "Chris", "Megan", "Matthew", "Katie" };

            List<string> lastNames = new List<string> { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor" };

            string firstName = firstNames[new Random().Next(firstNames.Count)];

            string lastName = lastNames[new Random().Next(lastNames.Count)];

            Name = firstName + " " + lastName;

            PhysicalFitness = new Random().Next(1, 11);
            RidingAbility = new Random().Next(1, 11);
            RacingStrategy = new Random().Next(1, 11);

            Salary = (decimal)(new Random().Next(1000, 10001)) / 100;

        }


    }

    public class Trainer : Staff
    {
        public int HorseCare { get; set; }
        public int TrainingAbility { get; set; }
        public int RacingStrategy { get; set; }
        public int Experience { get; set; }

        public Trainer(string name, int horseCare, int trainingAbility, int racingStrategy, int experience, decimal salary) : base(name, salary)
        {
            Experience = experience;
            HorseCare = horseCare;
            TrainingAbility = trainingAbility;
            RacingStrategy = racingStrategy;

        }
        public Trainer()
        {
            List<string> firstNames = new List<string> { "John", "Jane", "Michael", "Emily", "David", "Ashley", "Chris", "Megan", "Matthew", "Katie" };

            List<string> lastNames = new List<string> { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor" };

            string firstName = firstNames[new Random().Next(firstNames.Count)];

            string lastName = lastNames[new Random().Next(lastNames.Count)];

            Name = firstName + " " + lastName;

            HorseCare = new Random().Next(1, 11);
            TrainingAbility = new Random().Next(1, 11);
            RacingStrategy = new Random().Next(1, 11);
            Experience = new Random().Next(1, 11);

            HorseCare = ((TrainingAbility + RacingStrategy + Experience) * 100);


        }
        public int GenerateScore()
        {
            return HorseCare + TrainingAbility + RacingStrategy + Experience;
        }

    }
}
