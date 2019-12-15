namespace Life.Domain.Interfaces
{
    public interface IReproduction
    {
        IDna Act(Rabbit parent1, Rabbit parent2);
    }
}