namespace LoggingFramework;

public class Logger
{
    private static Logger? _instance;
    private Logger()
    {
        LogConfiguration = new LogConfiguration(new ConsoleSink());
    }

    public LogConfiguration LogConfiguration { get; set; }

    public static Logger Instance => _instance ??= new Logger();
    public void Log(LogLevel logLevel, string logMessage)
    {
        if (logLevel >= LogConfiguration.LogLevel)
        {
            LogConfiguration.LogSink.Write(new LogMessage(logMessage, logLevel));
        }
    }
    public void LogDebug(string logMessage)
    {
        Log(LogLevel.Debug, logMessage);
    }
    public void LogInfo(string logMessage)
    {
        Log(LogLevel.Info, logMessage);

    }
    public void LogWarning(string logMessage)
    {
        Log(LogLevel.Warning, logMessage);

    }
    public void LogError(string logMessage)
    {
        Log(LogLevel.Error, logMessage);

    }
    public void LogFatal(string logMessage)
    {
        Log(LogLevel.Fatal, logMessage);

    }
}
