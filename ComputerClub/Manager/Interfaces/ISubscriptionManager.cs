using ComputerClub.Model.DTO;
using ComputerClub.Model.Entitys;

namespace ComputerClub.Manager.Interfaces;

public interface ISubscriptionManager
{
    /// <summary>
    /// Add new subscription (start date = Time.Now)
    /// </summary>
    /// <param name="subsciptionDto">Add subscription data</param>
    /// <returns>New subscription</returns>
    Task<Subscription> AddSubscrioption(AddSubsciptionDto subsciptionDto);
    
    /// <summary>
    /// Delete subscription by id
    /// </summary>
    /// <param name="subId">subscription id</param>
    Task DeleteSubscription(int subId);
}