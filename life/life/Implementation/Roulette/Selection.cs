using System;
using System.Collections.Generic;
using Life.Domain;

namespace Life.Implementation.Roulette
{
    public abstract class Selection
    {
        protected Random Rand = new Random();
        public abstract Rabbit Select(List<Rabbit> items, double totalFitness);
    }
}