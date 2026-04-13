/*
 * Author: Nikolay Dvurechensky
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 апреля 2026 12:59:06
 * Version: 1.0.237
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
