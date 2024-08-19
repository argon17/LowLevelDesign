public class Expense
{
    Guid ExpenseId { get; set; }
    ExpenseCategory Category { get; set; }
    Dictionary<User, Balance> Users { get; } = [];
}