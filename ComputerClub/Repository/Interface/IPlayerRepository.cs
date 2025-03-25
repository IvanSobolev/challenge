using ComputerClub.Model.Entitys;

namespace ComputerClub.Repository.Implementation;

public interface IPlayerRepository
{
    /// <summary>
    /// Adding new user to db
    /// </summary>
    /// <param name="name">Username</param>
    /// <param name="year">User year</param>
    /// <returns>New player</returns>
    Task<Player> AddUserAsync(string name, int year);
    
    /// <summary>
    /// Get all user game
    /// </summary>
    /// <param name="userId">User id</param>
    /// <returns>All user games</returns>
    Task<IEnumerable<string>> GetAllUserGamesAsync(int userId);
}