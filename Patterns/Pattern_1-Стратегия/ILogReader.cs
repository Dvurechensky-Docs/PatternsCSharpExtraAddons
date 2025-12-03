/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 03 декабря 2025 11:20:15
 * Version: 1.0.106
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}