namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Example;

public interface IObservable
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}