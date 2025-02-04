namespace LoggingFramework;

public interface ILogSink
{
    public void Write(LogMessage logMessage);
}