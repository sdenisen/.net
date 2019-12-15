namespace Life.Domain.Interfaces
{
    using System.Collections.Generic;

    public interface IDna
    {
        List<int> Gene { get; set; }
    }
}