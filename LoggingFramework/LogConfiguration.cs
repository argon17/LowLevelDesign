public class LogConfiguration
{
    public LogConfiguration(ILogSink logSink, LogLevel logLevel = LogLevel.Info)
    {
        LogSink = logSink;
        LogLevel = logLevel;
    }
    public LogLevel LogLevel { get; set; }
    public ILogSink LogSink { get; set; }
}