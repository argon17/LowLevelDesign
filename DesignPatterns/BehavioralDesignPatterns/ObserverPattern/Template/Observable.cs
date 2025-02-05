namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Template;

public class Observable : IObservable
{
    public required string State { get; set; }

    private readonly List<IObserver> _subscribers = [];

    public void AddSubscriber(IObserver observer) => _subscribers.Add(observer);

    public void RemoveSubscriber(IObserver observer) => _subscribers.Remove(observer);

    public void NotifySubscribers()
    {
        foreach (var subscriber in _subscribers)
        {
            subscriber.Update();
        }
    }
    
    public void ChangeState(string state)
    {
        State = state;
        NotifySubscribers();
    }
}