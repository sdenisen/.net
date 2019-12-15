using System;
using System.Collections.Generic;
using System.Linq;
using Life.Domain;
using Life.Domain.Interfaces;
using Life.Implementation;
using Life.Implementation.Fitness;
using Life.Implementation.Reproduction;
using Life.Implementation.Roulette;

namespace Life
{
    public static class InterfaceLife
    {

        private const int CountOfIndividuals = 100;
        private const int CountOfnucleotide = 4;
        private const int CountIteration = 1;
        private const double MutationRate = 0.1;

        public static List<KeyValuePair<int, double>> Execute()
        {
            IReproduction reproduction0 = new Reproduction2();
            Selection selection0 = new StrangeWhellSelection();
            var fitness0 = new FitnessSolution { Solution = 30 };
            fitness0.Stop += StopAlgorithm;

            var factory0 = new RabbitFactory(reproduction0, fitness0, CountOfnucleotide);
            return ExecuteGeneticAlgorithm0(factory0, selection0);
            
        }


        private static List<KeyValuePair<int, double>> ExecuteGeneticAlgorithm0(RabbitFactory factory, Selection selection)
        {
            var rand = new CustomRandom(2);
            var currentPopulation = new Population(factory. GenerateRabbits(CountOfIndividuals), selection);


            var result = new List<KeyValuePair<int, double>>();
            result.AddRange(currentPopulation.Individuals.Select(GetChartPoint));

            var iteration = 0;
            while (iteration < CountIteration)
            {
                var count = 0;
                var newPopulation = new Population(selection);

                while (count < CountOfIndividuals)
                {
                    // added from older populations...
                    for (int i = 0; i < 15; i++)
                    {
                        newPopulation.AddNewIndivid(currentPopulation.RouletteWheelSelection());
                        count++;
                    }

                    // Selection
                    var parent1 = currentPopulation.RouletteWheelSelection();
                    var parent2 = currentPopulation.RouletteWheelSelection();

                    // Crossover
                    var children = factory.CrossingRabbits(parent1, parent2);

                    // GeneMutation
                    if (rand.NextDouble() < MutationRate)
                        factory.Mutation(ref children);

                    // add to new population
                    newPopulation.AddNewIndivid(children);
                    count += 1;
                }
                currentPopulation = newPopulation;
                result.AddRange(currentPopulation.Individuals.Select(GetChartPoint));
                iteration++;
            }

            return result;
        }

        private static KeyValuePair<int, double> GetChartPoint(Rabbit rabbit)
        {
            var binary = string.Empty;
            for (int i = 0; i < 4; i++)
            {
                binary += Convert.ToString(rabbit.Dna.Gene[i], 2);
            }

            return new KeyValuePair<int, double>(Convert.ToInt32(binary, 2), Math.Round(rabbit.Fitness, 2));
        }

        private static void StopAlgorithm(IDna dna)
        {
            var gene = dna.Gene;
            Console.WriteLine("FIND SOLUTION:: {0} + 2*{1} + 3*{2} + 4*{3}", gene[0], gene[1], gene[2], gene[3]);
        }

    }
}
