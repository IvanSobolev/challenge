using ComputerClub.Manager.Interfaces;
using ComputerClub.Model.DTO;
using Microsoft.AspNetCore.Mvc;

namespace ComputerClub.Controller;

[ApiController]
[Route("subscription")]
public class SubscriptionController(ISubscriptionManager subscriptionManager) : ControllerBase
{
    private readonly ISubscriptionManager _subscriptionManager = subscriptionManager;
    
    [HttpPost("add")]
    public async Task<IActionResult> AddSubscriptionAsync([FromBody] AddSubsciptionDto subsciptionDto)
    {
        try
        {
            return Ok(await _subscriptionManager.AddSubscrioptionAsync(subsciptionDto));
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
    
    [HttpDelete("delete/{subId}")]
    public async Task<IActionResult> DeleteSubscriptionAsync(int subId)
    {
        try
        {
            await _subscriptionManager.DeleteSubscriptionAsync(subId);
            return Ok();
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}