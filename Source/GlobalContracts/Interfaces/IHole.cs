using System;

namespace GlobalContracts.Interfaces
{
    public interface IHole
    {
        DateTime Finished { get; set; }
        string GameId { get; set; }
        string Number { get; set; }
        DateTime Started { get; set; }
    }
}