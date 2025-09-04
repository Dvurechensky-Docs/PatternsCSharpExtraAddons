/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 сентября 2025 08:08:59
 * Version: 1.0.16
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
