using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOfinal
{
    class Game
    {

        public Game() { }

        public Team Player;
        public List<Team> Opponents;
        public Calendar Calendar;
        public Marketplace Marketplace;

        public Game(Team player, List<Team> opponents, Calendar calendar, Marketplace marketplace)
        {
            Player = player;
            Opponents = opponents;
            Calendar = calendar;
            Marketplace = marketplace;
        }

        public Game LoadGame(Stream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            return (Game)formatter.Deserialize(stream);
        }


        public void SaveGame(string fileName, Game game)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(fileName, FileMode.Create))
            {
                formatter.Serialize(stream, game);
            }
        }

        public Game NewGame()
        {
            string name = "new player";

            Team NewPlayer = new Team(name, 5000);
            List<Team> npc = GetRandomNPC();
            Marketplace marketplace = GenerateRandomMarketplace();
            List<int> raceday = new List<int>();
            raceday.Add(5); raceday.Add(9); raceday.Add(12); raceday.Add(20);
            Calendar calendar = new Calendar(raceday, 1);
            Game game = new Game(NewPlayer, npc, calendar, marketplace);

            return game;
        }

        public void StartGame(Game game)
        {
            game.Calendar.DisplayCalendar();

        }

        public List<Team> GetRandomNPC()
        {
            List<Team> npcs = new List<Team>();




            for (int i = 0; i < 11; i++)
            {
                var horse1 = new Horse();
                var horse2 = new Horse();
                var horse3 = new Horse();
                var horse4 = new Horse();


                var horses = new List<Horse> { horse1, horse2, horse3, horse4 };
                Team team = new Team(generateTeamNames(), horses);

                npcs.Add(team);
            }

            string generateTeamNames()
            {
                List<string> words = new List<string> { "Horse", "Equestrian", "Riders", "Stables", "Academy", "Team", "Racing", "Jumping", "Dressage", "Eventing", "Foxhunting", "Pony", "Show", "Trail", "Endurance", "Polo", "Rodeo", "Steeplechase" };

                string word1 = words[new Random().Next(words.Count)];

                string word2 = words[new Random().Next(words.Count)];

                string teamName = word1 + " " + word2;

                return teamName;
            }


            return npcs;
        }


        public Marketplace GenerateRandomMarketplace()
        {
            var horse1 = new Horse();
            var horse2 = new Horse();
            var horse3 = new Horse();
            var horse4 = new Horse();
            var horse5 = new Horse();
            //fazer o mesmo com grayhounds

            var animals = new List<Animal> { horse1, horse2, horse3, horse4, horse5 };

            var trainer1 = new Trainer();
            var trainer2 = new Trainer();
            var trainer3 = new Trainer();
            List<Trainer> trainers = new List<Trainer>{trainer1, trainer2, trainer3};

            var jockey1 = new Jockey();
            var jockey2 = new Jockey();
            var jockey3 = new Jockey();

            List<Jockey> jockeys = new List<Jockey> { jockey1, jockey2, jockey3 };

            var staff = new List<Staff> { trainer1, trainer2, trainer3, jockey1, jockey2, jockey3 };

            Marketplace marketplace = new Marketplace(animals, jockeys, trainers);


            return marketplace;
        }

    }
}
