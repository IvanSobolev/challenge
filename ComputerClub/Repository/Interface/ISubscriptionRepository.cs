using ComputerClub.Model.Entitys;

namespace ComputerClub.Repository.Implementation;

public interface ISubscriptionRepository
{
    /// <summary>
    /// Add new subscription (start date = Time.Now)
    /// </summary>
    /// <param name="playerId">Player subscription id</param>
    /// <param name="endDate">End subscription date</param>
    /// <param name="balance">Subscription balance</param>
    /// <returns>New subscription</returns>
    Task<Subscription> AddSubscrioptionAsync(int playerId, DateTime endDate, int balance);
    
    /// <summary>
    /// Delete subscription by id
    /// </summary>
    /// <param name="subId">subscription id</param>
    Task DeleteSubscriptionAsync(int subId);
}