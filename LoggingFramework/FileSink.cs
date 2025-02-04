namespace LoggingFramework;

public class FileSink(string logFilePath) : ILogSink
{
    private readonly FileInfo _logFileInfo = new(logFilePath);

    public void Write(LogMessage logMessage)
    {
        StreamWriter streamWriter = new StreamWriter(_logFileInfo.FullName);
        streamWriter.Write(logMessage);
    }
}