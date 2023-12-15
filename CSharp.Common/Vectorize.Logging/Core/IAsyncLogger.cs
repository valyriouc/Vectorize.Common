namespace Vectorize.Logging.Core;

public interface IAsyncLogger
{
    public bool IsSuccessful { get; set; }

    public Task LogAsync(LogLevel level, string message);

    public Task LogFromErrAsync(Exception ex);
}
