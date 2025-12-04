/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 04 декабря 2025 13:19:37
 * Version: 1.0.107
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}