namespace ComputerClub.Repository.Implementation;

public interface IPlayerRepository
{
    Task AddUserAsync(string name, int year);
    Task<IEnumerable<string>> GetAllUserGamesAsync(int userId);
}