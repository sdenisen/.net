using System.Collections.Generic;
using System.Linq;
using Life.Domain;

namespace Life.Implementation.Roulette
{
    public class WhellSelection : Selection
    {
        public override Rabbit Select(List<Rabbit> items, double totalFitness)
        {
            items.Sort();
            var midFitness = items[items.Count/2].Fitness;
            var newCollection = items.Where(rabbit => rabbit.Fitness >= midFitness).ToList();
            return newCollection[Rand.Next(newCollection.Count)];
        }
    }
}