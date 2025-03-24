namespace ComputerClub.Repository.Implementation;

public interface ISubscriptionRepository
{
    Task AddSubscrioption(int playerId, DateTime endDate, int balance);
    Task DeleteSubscription(int subId);
}