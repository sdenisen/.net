using Life.Domain.Interfaces;

namespace Life.Implementation.Fitness
{
    public abstract class Fitness
    {
        public Fitness(double expectedSolutionValue)
        {
            SolutionValue = expectedSolutionValue;
        }

        public double SolutionValue { get; private set; }
        public abstract double GetFitness(IDna dna);

        public delegate void PrintGene(IDna dna);
    }
}