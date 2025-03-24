namespace ComputerClub.Repository.Implementation;

public interface ISessionRepository
{
    Task<float> GetAvgPlayerPlaytime(int playerId);
}