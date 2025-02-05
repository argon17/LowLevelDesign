using Xunit;

namespace LoggingFramework.Test;

public class UnitTest1
{
    [Fact]
    public void TestConsoleSink()
    {
        StringWriter stringWriter = new();
        Console.SetOut(stringWriter);

        Logger logger = Logger.Instance;
        logger.LogDebug("Debug");
        logger.LogInfo("Info");
        logger.LogWarning("Warning");
        logger.LogError("Error");
        logger.LogFatal("Fatal");

        string output = stringWriter.ToString();
        Assert.Equal("""
                     Info - Info
                     Warning - Warning
                     Error - Error
                     Fatal - Fatal

                     """, output);
    }
}