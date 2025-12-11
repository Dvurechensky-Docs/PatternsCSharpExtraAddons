/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 11 декабря 2025 14:03:55
 * Version: 1.0.114
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}