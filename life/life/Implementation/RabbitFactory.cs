using System;
using System.Collections.Generic;
using Life.Domain;
using Life.Domain.Interfaces;

namespace Life.Implementation
{
    public class RabbitFactory : IRabbitFactory
    {
        protected const int SleepTicks = 5;
        private const int RandomMaxValue = 10;
        private static int _dnaElementsCount;
        private static readonly Random Rand = new Random(SleepTicks);
        private readonly Fitness.Fitness _fitness;
        private static IReproduction _reproduction;
        
        public RabbitFactory(IReproduction reproduction, Fitness.Fitness fitness, int dnaElementsCount)
        {
            if(dnaElementsCount <= 0)
                throw new ArgumentException("value of dnaElementsCount is wrong. must be positive value.");
            _reproduction = reproduction;
            _dnaElementsCount = dnaElementsCount;
            _fitness = fitness;
        }

        public Rabbit CrossingRabbits(Rabbit parent1, Rabbit parent2)
        {
            var dnk = _reproduction.Act(parent1, parent2);
            var children = new Rabbit(dnk, _fitness.GetFitness(dnk));
            return children;
        }
        
        // todo:
        public void Mutation(ref Rabbit children)
        {
            var item1 = Rand.Next(_dnaElementsCount);
            children.Dna.Gene[item1] = Rand.Next(RandomMaxValue);

            var item2 = Rand.Next(_dnaElementsCount);
            children.Dna.Gene[item2] = Rand.Next(RandomMaxValue);
        }

        public List<Rabbit> GenerateRabbits(int count)
        {
            var rabbits = new List<Rabbit>();
            for (var j = 0; j < count; j++)
                rabbits.Add(CreationOfRabbit());
            return rabbits;
        }

        private Rabbit CreationOfRabbit()
        {
            var dnk = new Dna { Gene = GenerateGene() };
            return new Rabbit(dnk, _fitness.GetFitness(dnk));
        }

        private static List<int> GenerateGene()
        {
            var result = new List<int>();
            for (var i = 0; i < _dnaElementsCount; i++)
            {
                result.Add(Rand.Next(RandomMaxValue));
            }
            return result;
        }
    }
}
