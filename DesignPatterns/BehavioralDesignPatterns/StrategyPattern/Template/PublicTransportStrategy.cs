namespace DesignPatterns.BehavioralDesignPatterns.StrategyPattern.Template;

public class PublicTransportStrategy : IRouteStrategy
{
    public void BuildRoute() => Console.WriteLine("Building public transport route");
}