namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Example;

public class RideTracker : IObservable
{
    private readonly List<IObserver> _observers = [];
    private string? _lastBike;
    private int _lastDistance;
    private TimeSpan _lastTime;

    public void AddObserver(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void RemoveObserver(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in _observers)
        {
            observer.Update();
        }
    }

    public void LogRide(string? bike, int distance, TimeSpan time)
    {
        _lastBike = bike;
        _lastDistance = distance;
        _lastTime = time;

        Console.WriteLine($"Ride logged: {bike}, Distance: {distance}km, Time: {time}");
        NotifyObservers();
    }

    // Getters for observers to access the latest ride details
    public string? GetLastBike() => _lastBike;
    public int GetLastDistance() => _lastDistance;
    public TimeSpan GetLastTime() => _lastTime;
}