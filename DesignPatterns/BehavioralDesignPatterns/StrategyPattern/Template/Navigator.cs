namespace DesignPatterns.BehavioralDesignPatterns.StrategyPattern.Template;

/// <summary>
/// Fixes code reusability problem across different classes in an inheritance tree
/// </summary>

public class Navigator
{
    public required IRouteStrategy RouteStrategy { get; set; }
    public void BuildRoute() => RouteStrategy.BuildRoute();
}