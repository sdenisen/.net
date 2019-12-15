using Life.Domain.Interfaces;
using Life.Implementation;
using Life.Implementation.Fitness;
using Life.Implementation.Reproduction;
using Life.Implementation.Roulette;
using System;

namespace Life
{
    public class Program
    {
        private const int RabbitCountAtGeneration = 100; 
        private const int CountIteration = 20;           
        private const double MutationRate = 0.09;
        private const int DnaElementsCount = 15;
        private const double FitnessSolution = 7.2;
        

        private static void Main()
        {
            var fitness = new RabbitFitness(FitnessSolution);
            fitness.Stop += StopAlgorithm;
            var reproduction = new Reproduction2();
            var selection = new StrangeWhellSelection();

            var factory = new RabbitFactory(reproduction, fitness, DnaElementsCount);
            ExecuteGeneticAlgorithm(factory, selection);

            Console.ReadKey();
        }

        private static void ExecuteGeneticAlgorithm(RabbitFactory factory, Selection selection)
        {
            var rand = new Random();
            var currentPopulation = new Population(factory.GenerateRabbits(RabbitCountAtGeneration), selection);
            
            for (int iteration=0; iteration < CountIteration; iteration++) 
            {
                var newPopulation = new Population(selection);

                for (var count=0; count< RabbitCountAtGeneration; count++) 
                { 
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
                }

                currentPopulation = newPopulation;
                currentPopulation.FindBestIndivid().Display();
            }
        }

        private static void StopAlgorithm(IDna dna)
        {
            Console.WriteLine("The genome satisfy fitness criteria: ({0}), dna: {1}", FitnessSolution, string.Join(" ", dna.Gene));
        }
    }
}

