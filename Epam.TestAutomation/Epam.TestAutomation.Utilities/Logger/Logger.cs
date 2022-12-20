using Serilog;

namespace Epam.TestAutomation.Utilities.Logger
{
    public static class Logger
    {
        private static ThreadLocal<List<string>> _logs = new ThreadLocal<List<string>>(() => new List<string>());

        public static void Info(string message)
        {
            _logs.Value.Add(message);
        }

        public static void InitLogger(string filePath)
        {
            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug().WriteTo.File(Path.Combine(filePath, "logs.txt"))
                .CreateLogger();
        }

        public static void FinishTestLog()
        {
            _logs.Value.ForEach(x => Log.Logger.Information(x));
            _logs.Value.Clear();
        }
    }
}
