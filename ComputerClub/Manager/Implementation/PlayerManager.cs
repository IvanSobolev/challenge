using ComputerClub.Manager.Interfaces;
using ComputerClub.Model.DTO;
using ComputerClub.Model.Entitys;
using ComputerClub.Repository.Implementation;

namespace ComputerClub.Manager.Implementation;

public class PlayerManager(IPlayerRepository playerRepository) : IPlayerManager
{
    private readonly IPlayerRepository _playerRepository = playerRepository;
    
    /// <inheritdoc />
    public async Task<Player> AddUserAsync(AddPlayerDto player)
    {
        return await _playerRepository.AddUserAsync(player.Name, player.Year);
    }

    /// <inheritdoc />
    public async Task<IEnumerable<string>> GetAllUserGamesAsync(int userId)
    {
        return await _playerRepository.GetAllUserGamesAsync(userId);
    }
}