/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 31 декабря 2025 10:57:32
 * Version: 1.0.134
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}