public class LogMessage
{
    public LogMessage(string message, LogLevel logLevel)
    {
        Message = message;
        LogLevel = logLevel;
    }
    public LogLevel LogLevel { get; init; }
    public string Message { get; init; }
    public override string ToString()
    {
        return LogLevel +" - "+ Message;
    }
}