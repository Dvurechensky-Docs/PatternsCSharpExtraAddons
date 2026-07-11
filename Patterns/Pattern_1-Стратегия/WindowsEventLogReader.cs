/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 июля 2026 14:00:08
 * Version: 1.0.329
 */

namespace Behavioral;

public class WindowsEventLogReader : ILogReader
{
    public List<LogEntry> Read()
    {
        return new List<LogEntry>()
        {
            new LogEntry()
            {
                DateTime = DateTime.Now,
                Message = GetType().Name,
                Severity = LogType.Debug
            }
        };
    }
}
