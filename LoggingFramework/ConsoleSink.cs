public class ConsoleSink : ILogSink
{
    public void Write(LogMessage logMessage)
    {
        Console.WriteLine(logMessage);
    }
}