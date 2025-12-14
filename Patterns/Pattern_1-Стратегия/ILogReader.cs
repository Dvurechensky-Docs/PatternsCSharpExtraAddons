/*
 * Author: Nikolay Dvurechensky
 * Site: https://www.dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 14 декабря 2025 14:33:58
 * Version: 1.0.117
 */


namespace Behavioral;

public interface ILogReader
{
    List<LogEntry> Read();
}