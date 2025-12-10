/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 10 декабря 2025 06:51:48
 * Version: 1.0.113
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}