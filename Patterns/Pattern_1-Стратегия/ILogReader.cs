/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 02 декабря 2025 13:36:12
 * Version: 1.0.105
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}