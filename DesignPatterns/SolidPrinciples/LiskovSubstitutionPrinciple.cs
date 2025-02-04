namespace DesignPatterns.SolidPrinciples;

/// <summary>
/// If S is a subtype of T, then objects of type T may be replaced with objects of type S
/// without altering any of the desirable properties of the program.
/// </summary>

public class Bike
{
    public virtual void StartEngine() => throw new NotImplementedException();
}
public class ElectricBike : Bike
{
    public bool IsEngineStarted { get; set; }
    public override void StartEngine() => IsEngineStarted = true;
}
public class PedalBike : Bike
{
    public override void StartEngine() => throw new InvalidOperationException("Pedal bikes don't have engines");
}

// The PedalBike class violates the Liskov Substitution Principle, because it throws an exception when the StartEngine method is called.

// The refactored code below separates the Bike class into two interfaces: IEngineStartable and IPedalable:

public interface IEngineStartable
{
    void StartEngine();
}

public interface IPedalable
{
    void Pedal();
}

public class ElectricBikeGood : IEngineStartable
{
    public bool IsEngineStarted { get; set; }
    public void StartEngine() => IsEngineStarted = true;
}

public class PedalBikeGood : IPedalable
{
    public void Pedal() => Console.Write("Pedaling");
}
