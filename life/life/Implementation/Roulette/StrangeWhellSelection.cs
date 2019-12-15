using System.Collections.Generic;
using Life.Domain;

namespace Life.Implementation.Roulette
{
    public class StrangeWhellSelection : Selection
    {
        public override Rabbit Select(List<Rabbit> items, double totalFitness)
        {
            var randNum = totalFitness * Rand.NextDouble();
            var countOfIndividuals = items.Count;
            
            int idx;
            for (idx = 1; (idx < countOfIndividuals) && (randNum > 0); idx++)
            {
                randNum -= items[idx].Fitness;
            }
            return items[idx - 1];
        }
    }
}