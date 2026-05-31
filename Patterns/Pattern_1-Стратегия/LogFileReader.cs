/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 мая 2026 14:54:30
 * Version: 1.0.287
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
