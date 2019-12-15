using System.Collections.Generic;
using Life.Domain;
using Life.Domain.Interfaces;

namespace Life.Implementation.Reproduction
{
    public class Reproduction : IReproduction
    {
        /// <summary>
        /// DNA shuffling of rabbit parents. 
        /// for example:
        ///  parent1 = 000000
        ///  parent2 = 111111
        ///  children: 000111   
        /// </summary>
        public IDna Act(Rabbit parent1, Rabbit parent2)
        {
            var dnk1 = parent1.Dna;
            var count = dnk1.Gene.Count/2;

            var gene = new List<int>();

            for(var i=0; i<count; i++)
                gene.Add(parent1.Dna.Gene[i]);

            for(var i=count; i<parent2.Dna.Gene.Count; i++)
                gene.Add(parent2.Dna.Gene[i]);

            var dnk = new Dna {Gene = gene};
            return dnk;
        }
    }
}
