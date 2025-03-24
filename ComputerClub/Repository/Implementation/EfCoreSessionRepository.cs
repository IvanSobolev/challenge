using ComputerClub.Model;
using ComputerClub.Model.Entitys;
using Microsoft.EntityFrameworkCore;

namespace ComputerClub.Repository.Implementation;

public class EfCoreSessionRepository(DataContext dataContext) : ISessionRepository
{
    private readonly DataContext _dataContext = dataContext;
    
    public async Task<float> GetAvgPlayerPlaytime(int playerId)
    {
        return (float)await _dataContext.Sessions.Where(s => s.PlayerId == playerId).AverageAsync(s => s.DurationMinutes);
    }
}