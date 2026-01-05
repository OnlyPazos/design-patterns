using System;
using Logging;

namespace App
{
  class Program
  {
    static void Main(string[] args)
    {
      Logger.Instance.Configure(
        new LoggerConfig
        {
          MinimumLevel = LogLevel.Info
        },
        new ConsoleLogSink(),
        new FileLogSink("app.log")
      );

      Logger logger1 = Logger.Instance;
      Logger logger2 = Logger.Instance;

      if (logger1 == logger2)
      {
        Console.WriteLine("Logger is working as Singleton");
      }
      else
      {
        Console.WriteLine("Check Logger class. Instances are different");
      }

      logger1.Info("MAIN", "Aplicación iniciada");
      logger2.Error("DB", "Error de conexión");
    }
  }
}