namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Template;

public interface IObservable
{
    void AddSubscriber(IObserver observer);
    void RemoveSubscriber(IObserver observer);
    void NotifySubscribers();
}