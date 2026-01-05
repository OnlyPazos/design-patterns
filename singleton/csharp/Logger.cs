namespace Logging
{
  // Interface to represent where log will be writed
  public interface ILogSink
  {
    void Write(string message);
  }

  // Interface for console
  public sealed class ConsoleLogSink : ILogSink
  {
    public void Write(string message)
    {
      Console.WriteLine(message);
    }
  }

  // Interface for file
  public sealed class FileLogSink : ILogSink
  {
    private readonly string _path;

    public FileLogSink(string path)
    {
      _path = path;
    }

    public void Write(string message)
    {
      File.AppendAllText(_path, message + Environment.NewLine);
    }
  }

  public enum LogLevel
  {
    Trace, // Detailed info for specific issues
    Debug, // Info for debugging
    Info, // General info about normal behavior
    Warn, // Indicator of potential issues or unexpected events
    Error, // Error that affect functionality but don't crash the app
    Fatal // Severe issues that crash the app
  }

  public sealed class LoggerConfig
  {
    public LogLevel MinimumLevel { get; init; } = LogLevel.Info;
    public bool Enabled { get; init; } = true;
    public bool IncludeTimestamp { get; init; } = true;
  }

  // Sealed prevents class inheritance through external classes and nested classes
  public sealed class Logger
  {
    // Private constructor to prevent direct construction calls with `new` operator
    private Logger() { }

    // Use `Lazy` for thread-safe by default without explicit locks
    private static readonly Lazy<Logger> _instance =
    new(() => new Logger());

    public static Logger Instance => _instance.Value;

    private LoggerConfig _config = new();
    private readonly List<ILogSink> _sinks = new();

    public void Configure(LoggerConfig config, params ILogSink[] sinks)
    {
      _config = config ?? throw new ArgumentNullException(nameof(config));
      _sinks.Clear();
      _sinks.AddRange(sinks);
    }

    private void Log(LogLevel logLevel, string traceId, string message)
    {
      if (!_config.Enabled || logLevel < _config.MinimumLevel)
        return;

      var timestamp = _config.IncludeTimestamp
        ? DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss ")
        : string.Empty;

      var logEntry = $"{timestamp}[{logLevel}] [{traceId}] {message}";

      foreach (var sink in _sinks)
      {
        sink.Write(logEntry);
      }
    }

    public void Trace(string traceId, string message) => Log(LogLevel.Trace, traceId, message);

    public void Debug(string traceId, string message) => Log(LogLevel.Debug, traceId, message);

    public void Info(string traceId, string message) => Log(LogLevel.Info, traceId, message);

    public void Warn(string traceId, string message) => Log(LogLevel.Warn, traceId, message);

    public void Error(string traceId, string message) => Log(LogLevel.Error, traceId, message);

    public void Fatal(string traceId, string message) => Log(LogLevel.Fatal, traceId, message);
  }
}