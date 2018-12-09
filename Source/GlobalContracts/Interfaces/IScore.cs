namespace GlobalContracts.Interfaces
{
    public interface IScore
    {
        string GameId { get; set; }
        string HoleId { get; set; }
        string PlayerId { get; set; }
        int Putts { get; set; }
    }
}