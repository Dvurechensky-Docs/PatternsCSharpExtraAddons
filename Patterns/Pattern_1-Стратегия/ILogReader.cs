/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 09 декабря 2025 13:33:21
 * Version: 1.0.112
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}