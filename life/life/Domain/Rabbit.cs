using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Life.Domain.Interfaces;

namespace Life.Domain
{
    public class Rabbit : IComparable
    {
        private readonly IDna _dna;
        private readonly double _fitness;

        public double Fitness { get { return _fitness; } }

        public IDna Dna { get { return _dna; } }
        
        public static Rabbit Empty { get { return new Rabbit(); } }
        
        private Rabbit()
        {
            _fitness = -1;
            _dna = new Dna {Gene = (List<int>) Enumerable.Empty<int>()};
        }

        public Rabbit(IDna dna, double fitness)
        {
            _dna = dna;
            _fitness = fitness;
        }

        public int CompareTo(object obj)
        {
            if (obj is Rabbit rabbit)
                return Fitness.CompareTo(rabbit.Fitness);
            throw new ArgumentException("Object isn't a Rabbit instance");
        }

        public void Display()
        {
            Console.WriteLine("fitness: {0:0.00}, \t dna: {1}", _fitness, string.Join(" ", _dna.Gene));
        }
    }
}
