namespace GlobalContracts.Interfaces
{
    public interface IScore
    {
        string HoleId { get; set; }
        string PlayerId { get; set; }
        int Putts { get; set; }
    }
}