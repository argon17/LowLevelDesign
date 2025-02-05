namespace DesignPatterns.BehavioralDesignPatterns.StrategyPattern.Template;

public class WalkingStrategy : IRouteStrategy
{
    public void BuildRoute() => Console.WriteLine("Building walking route");
}