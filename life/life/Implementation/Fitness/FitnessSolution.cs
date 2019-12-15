using System;
using System.Linq;
using Life.Domain.Interfaces;

namespace Life.Implementation.Fitness
{
    public class FitnessSolution : Fitness
    {
        public event PrintGene Stop;
        public FitnessSolution(double expectedSolutionValue) : base(expectedSolutionValue)
        {}

        public override double GetFitness(IDna dna)
        {
            var s = dna.Gene.Select((gen, index) => gen * index).Sum();
            var result = (int) (s - SolutionValue);
            if (result > 0.0)
                return Math.Abs(1 / (s - SolutionValue));
            
            Stop?.Invoke(dna);
            return 1;
        }
        
    }
}
