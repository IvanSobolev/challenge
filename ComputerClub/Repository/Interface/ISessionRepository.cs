namespace ComputerClub.Repository.Implementation;

public interface ISessionRepository
{
    Task<IEnumerable<float>> GetAvgPlayTime(int userId);
}