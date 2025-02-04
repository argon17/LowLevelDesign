namespace Splitwise;

public class Group
{
    Currency Currency { get; } = Currency.Inr;
    Guid GroupId { get; set; }
    List<User> Users { get; set; } = [];
}