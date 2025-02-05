namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Example;

public class NotificationSystem(RideTracker rideTracker) : IObserver
{
    public void Update()
    {
        Console.WriteLine($"[Notification] New Ride: {rideTracker.GetLastBike()}, {rideTracker.GetLastDistance()}km in {rideTracker.GetLastTime()}");
    }
}