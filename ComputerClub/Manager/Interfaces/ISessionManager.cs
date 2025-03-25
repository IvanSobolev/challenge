namespace ComputerClub.Manager.Interfaces;

public interface ISessionManager
{
    /// <summary>
    /// Get average user playtime 
    /// </summary>
    /// <param name="playerId">User Id</param>
    /// <returns>Average playtime</returns>
    Task<float> GetAvgPlayerPlaytimeAsync(int playerId);
}