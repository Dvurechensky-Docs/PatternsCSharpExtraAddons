/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 декабря 2025 06:51:52
 * Version: 1.0.119
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
