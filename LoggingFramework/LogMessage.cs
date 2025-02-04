namespace LoggingFramework;

public class LogMessage(string message, LogLevel logLevel)
{
    private LogLevel LogLevel { get; init; } = logLevel;
    private string Message { get; init; } = message;

    public override string ToString()
    {
        return LogLevel +" - "+ Message;
    }
}