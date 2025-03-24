namespace ComputerClub.Model.Entitys;

public class Player
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> GamesName { get; set; } //Честно, по логике лучше сделать отдельную энтити с играми, ибо так может быть дублирование данных 🤷‍♂️
    public List<int> SessionsId { get; set; }
    public int Year { get; set; }
    
    public ICollection<Session> PlayerSessions { get; set; }
}