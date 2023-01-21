using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOfinal
{
    public class RacingEvent
    {

        public Animal GetRaceWinner2(List<Animal> animals)
        {
            Animal winner = animals[0];
            float highestScore = winner.CalculateScore();
            var random = new Random();
            foreach (Animal animal in animals)
            {
                float score = animal.CalculateScore();

                int chance = random.Next(1, 11);

                //adiciona um numero random ao score
                score += chance;

                if (score > highestScore)
                {
                    highestScore = score;
                    winner = animal;
                }
            }
            return winner;
        }


        public decimal PlaceBet(decimal betAmount, Animal animal)
        {
            return betAmount * animal.CalculateOdds();
        }
    }
}
