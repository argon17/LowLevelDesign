namespace DesignPatterns.BehavioralDesignPatterns.StrategyPattern.Template;

public class RoadStrategy : IRouteStrategy
{
    public void BuildRoute() => Console.WriteLine("Building road route");
}