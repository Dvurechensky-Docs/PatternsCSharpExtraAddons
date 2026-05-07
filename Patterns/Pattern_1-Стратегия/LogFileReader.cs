/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 07 мая 2026 15:26:24
 * Version: 1.0.263
 */

namespace Behavioral;

public class LogFileReader : ILogReader
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
