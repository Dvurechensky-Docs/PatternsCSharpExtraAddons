/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 08 мая 2026 06:51:18
 * Version: 1.0.264
 */

namespace Behavioral;

public enum LogType
{
    Debug,
    Warning,
    Fatal
}

public struct LogEntry
{
    public DateTime DateTime { get; set; }
    public LogType Severity { get; set; }
    public string Message { get; set; }
}
