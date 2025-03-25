namespace ComputerClub.Repository.Implementation;

public interface ISessionRepository
{
    /// <summary>
    /// Get average user playtime 
    /// </summary>
    /// <param name="playerId">User Id</param>
    /// <returns>Average playtime</returns>
    Task<float> GetAvgPlayerPlaytimeAsync(int playerId);
}