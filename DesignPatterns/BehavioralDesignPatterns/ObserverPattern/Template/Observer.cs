namespace DesignPatterns.BehavioralDesignPatterns.ObserverPattern.Template;

public class Observer(Observable observable): IObserver
{
    public void Update()
    {
        Console.WriteLine("State updated to: " + observable.State);
    }
}