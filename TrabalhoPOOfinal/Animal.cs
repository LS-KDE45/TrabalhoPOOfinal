using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOOfinal
{
    public interface Animal
    {
        float CalculateScore();
        decimal CalculateOdds();
        void Train(Trainer trainer, int intensity);
    }
}
