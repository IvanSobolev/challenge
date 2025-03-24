namespace ComputerClub.Model.Entitys;

public class Subscription
{
    public int Id { get; set; }
    public int PlayerId { get; set; } // смысла в этой таблице мало, ибо связь 1 к 1 безсмыслена, ибо создает больше избыточности, чем убирает ее.
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Balance { get; set; } //логичнее сделать int, но зависит от полного функцианала
    
    public Player Player { get; set; }
}