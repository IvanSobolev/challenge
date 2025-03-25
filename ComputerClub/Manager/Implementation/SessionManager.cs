using ComputerClub.Manager.Interfaces;
using ComputerClub.Repository.Implementation;

namespace ComputerClub.Manager.Implementation;

public class SessionManager(ISessionRepository sessionRepository) : ISessionManager
{
    private readonly ISessionRepository _sessionRepository = sessionRepository;
    
    /// <inheritdoc />
    public async Task<float> GetAvgPlayerPlaytimeAsync(int playerId)
    {
        return await _sessionRepository.GetAvgPlayerPlaytimeAsync(playerId);
    }
}