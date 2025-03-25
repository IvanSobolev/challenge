using ComputerClub.Model.DTO;
using ComputerClub.Model.Entitys;

namespace ComputerClub.Manager.Interfaces;

public interface IPlayerManager
{
    /// <summary>
    /// Adding new user to db
    /// </summary>
    /// <param name="player">Add player dto data</param>
    /// <returns>New player</returns>
    Task<Player> AddUserAsync(AddPlayerDto player);
    
    /// <summary>
    /// Get all user game
    /// </summary>
    /// <param name="userId">User id</param>
    /// <returns>All user games</returns>
    Task<IEnumerable<string>> GetAllUserGamesAsync(int userId);
}