using Vectorize.Logging.Core;

namespace Vectorize.Logging.ConsoleLoggers;

public class ConsoleLogger : ILogger
{
    public bool IsSuccessful { get; set; }

    public void Log(LogLevel level, string message)
    {
        switch(level)
        {
            case LogLevel.Info:
                LogInternal(ConsoleColor.Blue, "INFO", message);
                break;
            case LogLevel.Debug:
                LogInternal(ConsoleColor.Green, "DEBUG", message);
                break;
            case LogLevel.Warning:
                LogInternal(ConsoleColor.Yellow, "WARN", message);
                break;
            case LogLevel.Error:
                LogInternal(ConsoleColor.Red, "ERROR", message);
                break;
            default:
                throw new NotImplementedException();
        }
    }

    public void LogFromErr(Exception ex) =>
        Log(LogLevel.Error, ex.ToString());

    private void LogInternal(
        ConsoleColor color, 
        string title, 
        string message)
    {
        Console.BackgroundColor = color;
        Console.Write($"{title}: ");
        Console.BackgroundColor = ConsoleColor.Black;
        Console.WriteLine(message);
    }
}
