/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 12 ноября 2025 06:51:46
 * Version: 1.0.85
 */

namespace Behavioral;

public class LogProcessor
{
    private readonly Func<List<LogEntry>> _logimporter;

    public LogProcessor(Func<List<LogEntry>> logImporter)
    {
        _logimporter = logImporter;
    }

    public void ProcessLogs()
    {
        foreach(var logEntry in _logimporter.Invoke())
        {
            Console.WriteLine(logEntry.DateTime);
            Console.WriteLine(logEntry.Severity);
            Console.WriteLine(logEntry.Message);
        }
    }
}
