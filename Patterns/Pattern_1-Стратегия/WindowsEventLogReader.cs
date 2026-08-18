/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 августа 2026 06:51:45
 * Version: 1.0.367
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
