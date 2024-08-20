public class FileSink : ILogSink
{
    public FileInfo logFileInfo;
    public FileSink(string logFilePath)
    {
        logFileInfo = new FileInfo(logFilePath);
    }
    public void Write(LogMessage logMessage)
    {
        StreamWriter streamWriter = new StreamWriter(logFileInfo.FullName);
        streamWriter.Write(logMessage);
    }
}