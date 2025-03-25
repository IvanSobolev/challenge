using ComputerClub.Manager.Interfaces;
using ComputerClub.Repository.Implementation;

namespace ComputerClub.Manager.Implementation;

public class SessionManager(ISessionRepository sessionRepository) : ISessionManager
{
    private readonly ISessionRepository _sessionRepository = sessionRepository;
    
    /// <inheritdoc />
    public async Task<float> GetAvgPlayerPlaytime(int playerId)
    {
        return await _sessionRepository.GetAvgPlayerPlaytime(playerId);
    }
}