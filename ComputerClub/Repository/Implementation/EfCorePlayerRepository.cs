using ComputerClub.Model;
using ComputerClub.Model.Entitys;
using Microsoft.EntityFrameworkCore;

namespace ComputerClub.Repository.Implementation;

public class EfCorePlayerRepository(DataContext dataContext) : IPlayerRepository
{
    private readonly DataContext _dataContext = dataContext;
    
    /// <inheritdoc />
    public async Task<Player> AddUserAsync(string name, int year)
    {
        Player newPlayer = new Player()
        {
            Name = name,
            GamesName = new List<string>(),
            SessionsId = new List<int>(),
            Year = year
        };
        await _dataContext.Players.AddAsync(newPlayer);
        await _dataContext.SaveChangesAsync();
        return newPlayer;
    }

    /// <inheritdoc />
    public async Task<IEnumerable<string>> GetAllUserGamesAsync(int userId)
    {
        Player? player = await _dataContext.Players.FirstOrDefaultAsync(u => u.Id == userId);
        if (player == null)
        {
            return new List<string>();
        }

        return player.GamesName;
    }
}