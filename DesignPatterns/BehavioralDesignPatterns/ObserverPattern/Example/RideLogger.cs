namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Example;

public class RideLogger(RideTracker rideTracker) : IObserver
{
    public void Update()
    {
        Console.WriteLine($"[Ride Logger] Added: {rideTracker.GetLastBike()} - {rideTracker.GetLastDistance()}km in {rideTracker.GetLastTime()}");
    }
}