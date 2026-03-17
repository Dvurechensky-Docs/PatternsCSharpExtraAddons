/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 марта 2026 06:52:03
 * Version: 1.0.209
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
