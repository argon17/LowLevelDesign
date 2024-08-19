public class ExpenseService
{
    public Guid CreateGroup(User[] users, Currency currency) => throw new NotImplementedException();
    public User GetUser(Guid userId) => throw new NotImplementedException();
    public IReadOnlyCollection<User> GetUsersOfGroup(Guid groupId) => throw new NotImplementedException();
    public Guid AddUserToGroup(Guid groupId, User newUser) => throw new NotImplementedException();
    /// <summary>
    /// Adds a new expense to the group
    /// </summary>
    /// <param name="addedByUserId"></param>
    /// <param name="groupId"></param>
    /// <param name="expense"></param>
    /// <returns>the newly created expenseId</returns>
    public Guid AddExpense(Guid addedByUserId, Guid groupId, Expense expense) => throw new NotImplementedException();
    /// <summary>
    /// Updates the share a user in an expense with newAmount
    /// </summary>
    /// <param name="expenseId"></param>
    /// <param name="userId"></param>
    /// <param name="amount"></param>
    /// <returns>the updated expenseId</returns>
    public Guid EditExpense(Guid expenseId, Guid userId, double newAmount) => throw new NotImplementedException();
}