/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 13 декабря 2025 16:01:11
 * Version: 1.0.116
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}