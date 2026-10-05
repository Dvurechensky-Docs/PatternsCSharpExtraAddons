/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 05 октября 2026 08:10:54
 * Version: 1.0.415
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
