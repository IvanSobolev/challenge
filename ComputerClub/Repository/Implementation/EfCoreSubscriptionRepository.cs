using ComputerClub.Model;
using ComputerClub.Model.Entitys;
using Microsoft.EntityFrameworkCore;

namespace ComputerClub.Repository.Implementation;

public class EfCoreSubscriptionRepository(DataContext dataContext) : ISubscriptionRepository
{
    private readonly DataContext _dataContext = dataContext;
    
    /// <inheritdoc />
    public async Task<Subscription> AddSubscrioption(int playerId, DateTime endDate, int balance)
    {
        var subscription = new Subscription()
        {
            PlayerId = playerId,
            StartDate = DateTime.Now,
            EndDate = endDate,
            Balance = balance
        };

        await _dataContext.Subscriptions.AddAsync(subscription);
        await _dataContext.SaveChangesAsync();
        return subscription;
    }

    /// <inheritdoc />
    public async Task DeleteSubscription(int subId)
    {
        Subscription? subscription = await _dataContext.Subscriptions.FirstOrDefaultAsync(s => s.Id == subId);
        if (subscription == null)
        {
            Console.WriteLine("subscription is not delete");
            return;
        }

        _dataContext.Subscriptions.Remove(subscription);
        await _dataContext.SaveChangesAsync();
    }
}