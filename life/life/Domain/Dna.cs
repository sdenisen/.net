namespace Life.Domain
{
    using Interfaces;
    using System.Collections.Generic;
    
    public class Dna : IDna
    {
        public List<int> Gene { get; set; }
    }
}
