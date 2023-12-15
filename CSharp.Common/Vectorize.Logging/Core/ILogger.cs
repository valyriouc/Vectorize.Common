namespace Vectorize.Logging.Core;

public interface ILogger
{
    public bool IsSuccessful { get; set; }

    public void Log(LogLevel level, string message);

    public void LogFromErr(Exception ex);
}
