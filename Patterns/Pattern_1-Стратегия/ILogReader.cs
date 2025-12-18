/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 декабря 2025 06:51:49
 * Version: 1.0.121
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}