using System;
using System.Linq;
using Life.Domain.Interfaces;

namespace Life.Implementation.Fitness
{
    public class RabbitFitness : Fitness
    {
        public event PrintGene Stop;
        
        public RabbitFitness(double expectedSolutionValue) : base(expectedSolutionValue)
        {}

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dna"></param>
        /// <returns></returns>
        public override double GetFitness(IDna dna)
        {
            var fitness = dna.Gene.Sum() / (double) dna.Gene.Count;
            if (Math.Abs(fitness - SolutionValue) > 0.0) 
                return dna.Gene.Sum() / (double) dna.Gene.Count;
            
            Stop?.Invoke(dna);
            return 1;
        }

        
    }
}
