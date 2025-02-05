namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Example;

public class RideSummaryDashboard(RideTracker rideTracker) : IObserver
{
    private int _totalDistance = 0;
    private TimeSpan _totalTime = TimeSpan.Zero;

    public void Update()
    {
        _totalDistance += rideTracker.GetLastDistance();
        _totalTime += rideTracker.GetLastTime();
        Console.WriteLine($"[Dashboard] Total Distance: {_totalDistance}km, Total Time: {_totalTime}");
    }
}