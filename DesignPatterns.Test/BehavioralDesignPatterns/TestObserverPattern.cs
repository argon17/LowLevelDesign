using Xunit;
using DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Example;

namespace DesignPatterns.Test.BehavioralDesignPatterns;

public class TestObserverPattern
{
    [Fact]
    public void RideTracker_ShouldNotifyAllObservers_AndLogToConsole()
    {
        // Arrange
        RideTracker rideTracker = new RideTracker();
        RideLogger logger = new RideLogger(rideTracker);
        RideSummaryDashboard dashboard = new RideSummaryDashboard(rideTracker);
        NotificationSystem notifier = new NotificationSystem(rideTracker);

        // Add observers
        rideTracker.AddObserver(logger);
        rideTracker.AddObserver(dashboard);
        rideTracker.AddObserver(notifier);

        // Redirect Console output to a StringWriter
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);

        // Act
        rideTracker.LogRide("X-Pulse", 50, TimeSpan.FromMinutes(90));

        // Assert
        var output = stringWriter.ToString();

        // Check that the correct output was written to the console
        Assert.Contains("Ride logged: X-Pulse, Distance: 50km, Time: 01:30:00", output);
        Assert.Contains("[Ride Logger] Added: X-Pulse - 50km in 01:30:00", output);
        Assert.Contains("[Dashboard] Total Distance: 50km, Total Time: 01:30:00", output);
        Assert.Contains("[Notification] New Ride: X-Pulse, 50km in 01:30:00", output);
    }
}