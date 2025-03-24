namespace ComputerClub.Repository.Implementation;

public interface IPlayerRepository
{
    Task AddUser(string name, int year);
    Task<IEnumerable<string>> GetAllUserGames(int userId);
}