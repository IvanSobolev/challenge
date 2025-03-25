using ComputerClub.Manager.Interfaces;
using ComputerClub.Model.DTO;
using ComputerClub.Model.Entitys;
using ComputerClub.Repository.Implementation;

namespace ComputerClub.Manager.Implementation;

public class SubscriptionManager(ISubscriptionRepository subscriptionRepository) : ISubscriptionManager
{
    private readonly ISubscriptionRepository _subscriptionRepository = subscriptionRepository;
    
    public async Task<Subscription> AddSubscrioption(AddSubsciptionDto subsciptionDto)
    {
        return await _subscriptionRepository.AddSubscrioption(subsciptionDto.PlayerId, subsciptionDto.EndDate,
            subsciptionDto.Balance);
    }

    public async Task DeleteSubscription(int subId)
    {
        await _subscriptionRepository.DeleteSubscription(subId);
    }
}