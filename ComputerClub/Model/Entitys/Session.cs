namespace ComputerClub.Model.Entitys;

public class Session
{
    public int Id { get; set; }
    public string GameName { get; set; }
    public DateTime StartTime { get; set; }
    public int DurationMinutes { get; set; }
    public int PlayerId { get; set; }
    
    public Player Player { get; set; }
}