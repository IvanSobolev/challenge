namespace ComputerClub.Repository.Implementation;

public interface ISubscriptionRepository
{
    Task AddSubscrioption(int userId, DateTime endDate, int balance);
    Task DeleteSubscription(int subId);
}