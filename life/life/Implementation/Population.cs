using System.Collections.Generic;
using System.Linq;
using Life.Domain;
using Life.Implementation.Roulette;

namespace Life.Implementation
{
    public class Population
    {
        private readonly List<Rabbit> _rabbits;
        private readonly Selection _selection;

        public double TotalFitness { get { return _rabbits.Sum(individ => individ.Fitness); } }

        public Population(Selection selection)
        {
            _rabbits = new List<Rabbit>();
            _selection = selection;
        }

        public Population(List<Rabbit> rabbits, Selection selection) : this(selection)
        {
            _rabbits = rabbits;
        }

        public void AddNewIndivid(Rabbit rabbit)
        {
            _rabbits.Add(rabbit);
        }
      
        public Rabbit RouletteWheelSelection()
        {
            return _selection.Select(_rabbits, TotalFitness);
        }

        public Rabbit FindBestIndivid()
        {
            return _rabbits.Max();
        }
    }
}

