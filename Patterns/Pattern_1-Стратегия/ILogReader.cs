/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 01 декабря 2025 12:49:04
 * Version: 1.0.104
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}