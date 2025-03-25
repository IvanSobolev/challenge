using ComputerClub.Manager.Interfaces;
using ComputerClub.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ComputerClub.Controller;

[ApiController]
[Route("players")]
public class PlayerController(IPlayerManager playerManager) : ControllerBase
{
    private readonly IPlayerManager _playerManager = playerManager;

    [HttpPost("add")]
    public async Task<IActionResult> AddUserAsync([FromBody] AddPlayerDto playerDto)
    {
        try
        {
            return Ok(await _playerManager.AddUserAsync(playerDto));
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpGet("GetAllUserGames/{userId}")]
    public async Task<IActionResult> GetAllUserGamesAsync(int userId)
    {
        try
        {
            return Ok(await _playerManager.GetAllUserGamesAsync(userId));
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}