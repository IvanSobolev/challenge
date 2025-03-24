namespace ComputerClub.Model.Entitys;

public class Subscription
{
    public int Id { get; set; }
    public int PlayerId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Balance { get; set; }
    
    public Player Player { get; set; }
}