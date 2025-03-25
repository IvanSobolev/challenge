using ComputerClub.Manager.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComputerClub.Controller;

[ApiController]
[Route("session")]
public class SessionController (ISessionManager sessionManager) : ControllerBase
{
    private readonly ISessionManager _sessionManager = sessionManager;
    
    [HttpGet("GetAvgPlayerPlaytime/{playerId}")]
    public async Task<IActionResult> AddUserAsync(int playerId)
    {
        try
        {
            return Ok(await _sessionManager.GetAvgPlayerPlaytimeAsync(playerId));
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}