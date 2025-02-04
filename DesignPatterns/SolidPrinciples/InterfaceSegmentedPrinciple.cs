namespace DesignPatterns.SolidPrinciples;

public interface IRestaurantEmployee
{
    void TakeOrder();
    void CookOrder();
    void WashDishes();
}

public class Waiter : IRestaurantEmployee
{
    public void TakeOrder() => Console.Write("Order taken");
    public void CookOrder() => throw new InvalidOperationException("Waiters don't cook");
    public void WashDishes() => throw new InvalidOperationException("Waiters don't wash dishes");
}

public class Chef : IRestaurantEmployee
{
    public void TakeOrder() => throw new InvalidOperationException("Chefs don't take orders");
    public void CookOrder() => Console.Write("Order cooked");
    public void WashDishes() => throw new InvalidOperationException("Chefs don't wash dishes");
}

public class Dishwasher : IRestaurantEmployee
{
    public void TakeOrder() => throw new InvalidOperationException("Dishwashers don't take orders");
    public void CookOrder() => throw new InvalidOperationException("Dishwashers don't cook");
    public void WashDishes() => Console.Write("Dishes washed");
}

// The IRestaurantEmployee interface violates the Interface Segregation Principle, because it has methods that are not relevant to all classes that implement it.

// The refactored code below separates the IRestaurantEmployee interface into three smaller interfaces: ITakeOrder, ICookOrder, and IWashDishes:

public interface ITakeOrder
{
    void TakeOrder();
}

public interface ICookOrder
{
    void CookOrder();
}

public interface IWashDishes
{
    void WashDishes();
}

public class WaiterGood : ITakeOrder
{
    public void TakeOrder() => Console.Write("Order taken");
}

public class ChefGood : ICookOrder
{
    public void CookOrder() => Console.Write("Order cooked");
}

public class DishwasherGood : IWashDishes
{
    public void WashDishes() => Console.Write("Dishes washed");
}