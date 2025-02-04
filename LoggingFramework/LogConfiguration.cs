namespace LoggingFramework;

public class LogConfiguration(ILogSink logSink, LogLevel logLevel = LogLevel.Info)
{
    public LogLevel LogLevel { get; set; } = logLevel;
    public ILogSink LogSink { get; set; } = logSink;
}