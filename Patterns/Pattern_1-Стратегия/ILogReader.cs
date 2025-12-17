/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 декабря 2025 15:25:04
 * Version: 1.0.120
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}